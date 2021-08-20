using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Services
{

    public class LocacaoService : BaseService, ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository, INotificador notificador) : base(notificador)
        {
            _locacaoRepository = locacaoRepository;
        }

        public async Task<bool> LocarFilme(Locacao locacao)
        {
            var verifica = await _locacaoRepository.Verifica(locacao.FilmeId);

            if (verifica != null)
            {
                Notificar("O filme já está locado.");
                return false;
            }

            locacao.DataLocacao = DateTime.Now;
            locacao.DataMaximaDevolucao = DateTime.Now.AddDays(locacao.QuantidadeDiasLocacao);
            locacao.Ativo = true;

            await _locacaoRepository.Adicionar(locacao);
            return true;
        }

        public async Task<string> DevolverFilme(Guid filmeId, Guid clienteId)
        {
            var result = await _locacaoRepository.ObterLocacao(filmeId, clienteId);

            if (result == null)
            {
                Notificar("Não existe filme para ser devolvido.");
                return "";
            }

            result.Ativo = false;
            
            await _locacaoRepository.Atualizar(result);


            if (result.DataMaximaDevolucao < DateTime.Now)
                return "Filme devolvido com sucesso. Você passou do prazo de entrega do filme.";

            return "Filme devolvido com sucesso.";
        }

        public void Dispose()
        {
            _locacaoRepository?.Dispose();
        }

    }
}
