using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Interfaces
{
    public interface ILocacaoService : IDisposable
    {
        Task<bool> LocarFilme(Locacao locacao);
        Task<string> DevolverFilme(Guid filmeId, Guid clienteId);

    }
}
