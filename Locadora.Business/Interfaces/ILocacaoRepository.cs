using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Interfaces
{
    public interface ILocacaoRepository : IRepository<Locacao>
    {
        Task<Locacao> Verifica(Guid FilmeId);
        Task<Locacao> ObterLocacao(Guid FilmeId, Guid ClienteId);

    }
}
