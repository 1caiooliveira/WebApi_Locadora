using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLocadora.ViewModels
{
    public class LocacaoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid FilmeId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, 7, ErrorMessage = "Você deve escolher a quantidade de dias entre 1 e 7 dias.")]
        public int QuantidadeDiasLocacao { get; set; }
        public DateTime? DataLocacao { get; set; }
        public DateTime? DataMaximaDevolucao { get; set; }
        public bool Ativo { get; set; }

    }
}
