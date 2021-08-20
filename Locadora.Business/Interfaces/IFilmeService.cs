using Locadora.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business.Interfaces
{
    public interface IFilmeService : IDisposable
    {
        Task<bool> Adicionar(Filme filme);
        Task<bool> Atualizar(Filme filme);
    }
}
