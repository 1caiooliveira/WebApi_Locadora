using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLocadora.ViewModels
{
    public class DevolverLocacaoViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid ClienteId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid FilmeId { get; set; }
    }
}
