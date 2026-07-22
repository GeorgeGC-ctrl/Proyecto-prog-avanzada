using FluentValidation;
using Northwind.Entities.DTOs;

namespace Northwind.LogicaNegocios.Productos
{
    public class CreateProductValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("El nombre del producto es obligatorio.");
            RuleFor(x => x.SupplierID).NotEmpty().WithMessage("Seleccione un Suplidor.");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Seleccione una categoria.");
            RuleFor(x => x.UnitPrice).GreaterThanOrEqualTo(0).WithMessage("El precio unitario debe ser mayor o igual a cero.");

        }
    }
}
