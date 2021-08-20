using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Business.Models
{
    public class Filme : Entity
    {
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public string Genero { get; set; }
        public bool Ativo { get; set; }
    }
}
