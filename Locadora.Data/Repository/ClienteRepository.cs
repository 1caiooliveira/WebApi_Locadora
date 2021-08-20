using Locadora.Business.Interfaces;
using Locadora.Business.Models;
using Locadora.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MeuDbContext context) : base(context) { }
    }
}
