using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Services
{
    public class FilmeService : BaseService, IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        public FilmeService(IFilmeRepository filmeRepository, INotificador notificador)
             : base(notificador)
        {
            _filmeRepository = filmeRepository;
        }

        public async Task<bool> Adicionar(Filme filme)
        {

            if (_filmeRepository.Buscar(c => c.Nome == filme.Nome && c.Sinopse == filme.Sinopse).Result.Any())
            {
                Notificar("Já existe um filme cadastrado com este nome e com essa sinopse.");
                return false;
            }

            filme.Ativo = true;
            await _filmeRepository.Adicionar(filme);
            return true;
        }

        public async Task<bool> Atualizar(Filme filme)
        {
            if (_filmeRepository.Buscar(c => c.Nome == filme.Nome && c.Sinopse == filme.Sinopse).Result.Any())
            {
                Notificar("Já existe um filme cadastrado com este nome e com essa sinopse.");
                return false;
            }
            
            filme.Ativo = true;
            await _filmeRepository.Atualizar(filme);
            return true;

        }
        public void Dispose()
        {
            _filmeRepository?.Dispose();
        }

    }
}
