using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using Locadora.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Data.Repository
{
    public class LocacaoRepository : Repository<Locacao>, ILocacaoRepository
    {
        public LocacaoRepository(MeuDbContext context) : base(context) { }

        public async Task<Locacao> Verifica(Guid filmeId)
        {
            var result = await DbSet.AsNoTracking()
               .FirstOrDefaultAsync(l => l.FilmeId == filmeId && l.Ativo == true);

            return result;
        }

        public async Task<Locacao> ObterLocacao(Guid FilmeId, Guid ClienteId)
        {
            return await Db.Locacoes.AsNoTracking()
                .FirstOrDefaultAsync(l => l.FilmeId == FilmeId && l.ClienteId == ClienteId && l.Ativo == true);
        }


    }
}
