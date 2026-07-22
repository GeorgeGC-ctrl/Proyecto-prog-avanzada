using FluentValidation;
using Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.LogicaNegocios.Suplidores
{
    public class SuppliersValidator : AbstractValidator<CreateSuppliersDto>
    {
        public SuppliersValidator()
        {
            RuleFor(s => s.CompanyName)
                .NotEmpty().WithMessage("El nombre de la compañía es obligatorio.")
                .MaximumLength(40).WithMessage("El nombre de la compañía no puede exceder los 40 caracteres.");
            RuleFor(s => s.ContactName)
                .NotEmpty().WithMessage("El nombre del contacto no puede estar vacio.");
            RuleFor(s => s.Address)
                .MaximumLength(60).WithMessage("La dirección no puede exceder los 60 caracteres.");
            RuleFor(s => s.City)
                .MaximumLength(15).WithMessage("La ciudad no puede exceder los 15 caracteres.");
            RuleFor(s => s.Country)
                .MaximumLength(15).WithMessage("El país no puede exceder los 15 caracteres.");
            RuleFor(s => s.Phone)
                .MaximumLength(24).WithMessage("El teléfono no puede exceder los 24 caracteres.");
            RuleFor(s => s.Fax)
                .MaximumLength(24).WithMessage("El fax no puede exceder los 24 caracteres.");
        }

    }
}