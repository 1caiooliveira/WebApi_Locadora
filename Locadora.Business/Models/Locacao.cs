using System;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Business.Models
{
    public class Locacao : Entity
    {
        public Guid ClienteId { get; set; }
        public Guid FilmeId { get; set; }
        public int QuantidadeDiasLocacao { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime? DataMaximaDevolucao { get; set; }
        public bool Ativo { get; set; }
        
        /* EF Relation */
        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
    }
}
