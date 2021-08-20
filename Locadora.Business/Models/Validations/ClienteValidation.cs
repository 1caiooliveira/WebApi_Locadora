using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Business.Models.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Rg)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(9).WithMessage("O campo {PropertyName} precisa ter 9 digitos.");
        }
    }
}
