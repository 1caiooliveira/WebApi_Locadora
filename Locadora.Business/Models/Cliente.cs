using System;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Business.Models
{
    public class Cliente : Entity
    {

        public string Nome { get; set; }
        public string Rg { get; set; }
        public bool Ativo { get; set; }
    }
}
