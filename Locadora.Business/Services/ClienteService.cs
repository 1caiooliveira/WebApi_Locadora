using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository, INotificador notificador)
            : base(notificador)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Adicionar(Cliente cliente)
        {
            
            if (_clienteRepository.Buscar(c => c.Nome == cliente.Nome && c.Rg == cliente.Rg).Result.Any())
            {
                Notificar("Já existe um cliente cadastrado com este nome e RG.");
                return false;
            }

            cliente.Ativo = true;

            await _clienteRepository.Adicionar(cliente);
            return true;
        }

        public async Task<bool> Atualizar(Cliente cliente)
        {
            if (_clienteRepository.Buscar(c => c.Nome == cliente.Nome && c.Rg == cliente.Rg).Result.Any())
            {
                Notificar("Já existe um cliente cadastrado com este nome e RG.");
                return false;
            }

            await _clienteRepository.Atualizar(cliente);
            return true;
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }
    }
}
