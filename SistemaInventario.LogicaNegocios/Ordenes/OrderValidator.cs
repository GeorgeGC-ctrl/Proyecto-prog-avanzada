using FluentValidation;
using Northwind.Entities.DTOs;

namespace Northwind.LogicaNegocios.Ordenes
{
    public class OrderValidator : AbstractValidator<CreateOrderDto>
    {
        public OrderValidator()
        {
            RuleFor(o => o.CustomerID)
                .NotEmpty().WithMessage("El ID del cliente es obligatorio.");

            RuleFor(o => o.Detalles)
                .NotEmpty().WithMessage("La orden debe tener al menos un producto.")
                .Must(d => d != null && d.Count > 0)
                .WithMessage("Debe agregar al menos una línea de detalle.");

            RuleForEach(o => o.Detalles).ChildRules(detalle =>
            {
                detalle.RuleFor(d => d.ProductID)
                    .GreaterThan(0).WithMessage("Debe seleccionar un producto válido.");

                detalle.RuleFor(d => d.Quantity)
                    .GreaterThan((short)0).WithMessage("La cantidad debe ser mayor a 0.");

                detalle.RuleFor(d => d.UnitPrice)
                    .GreaterThanOrEqualTo(0).WithMessage("El precio no puede ser negativo.");
            });
        }
    }
}
