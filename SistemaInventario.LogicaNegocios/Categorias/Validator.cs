using FluentValidation;
using Northwind.Entidades.DTOs;
using SistemaInventario.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.LogicaNegocios.Categorias
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre de la categoría es obligatorio.")
            .MaximumLength(50).WithMessage("El nombre de la categoría no puede exceder los 50 caracteres.");

            RuleFor(x => x.Descripcion)
                .MaximumLength(200).WithMessage("La descripción de la categoría no puede exceder los 200 caracteres.")
            .When(x => !string.IsNullOrEmpty(x.Descripcion));
         
        }
        public class DeleteCategoryValidator: AbstractValidator<int>
        {
            public DeleteCategoryValidator(IUnitOfWork unitOfWork)
            {
                RuleFor(id => id)
                    .MustAsync(async (id, cancellation) =>
                    {
                        var productos = await unitOfWork.Productos.GetAllAsync();
                        return !productos.Any(p => p.CategoryID == id);
                    })
                    .WithMessage("No se puede eliminar la categoría porque tiene productos asociados.");
            }
        }

    }
}
