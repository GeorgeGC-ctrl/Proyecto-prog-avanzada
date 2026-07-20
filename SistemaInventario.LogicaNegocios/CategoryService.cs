using FluentValidation;
using Northwind.Entidades.DTOs;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;
using System.Data;

namespace SistemaInventario.LogicaNegocios
{
    public class CategoryService : ICategoryService
    {
        
        private readonly IUnitOfWork unitOfWork1;
        private readonly IValidator<CreateCategoryDto> _createCategoryValidator;

        public CategoryService(IUnitOfWork unitOfWork, IValidator<CreateCategoryDto> createCategoryValidator)
        {
           this.unitOfWork1 = unitOfWork;
           this._createCategoryValidator = createCategoryValidator;
        }
        public async Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await unitOfWork1.Categorias.GetAllAsync();
            return categories.Select (c => new CategoryDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion
            }).ToList();

        }
        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
           var category = await unitOfWork1.Categorias.GetByIdAsync(id);
            if (category == null)
            {
                throw new Exception($"Categoría con ID {id} no encontrada.");
            }
            return new CategoryDto
            {
                Id = category.Id,
                Nombre = category.Nombre,
                Descripcion = category.Descripcion
            };
        }
        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var validationResult = _createCategoryValidator.Validate(createCategoryDto);
            
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var category = new Categorias
            {
                Nombre = createCategoryDto.Nombre,
                Descripcion = createCategoryDto.Descripcion,
                Activo = true
            };
           
            await unitOfWork1.Categorias.AddAsync(category);
            await unitOfWork1.SaveChangesAsync();

            return new CategoryDto
            {
                Id = category.Id,
                Nombre = category.Nombre,
                Descripcion = category.Descripcion
            };
        }
        public async Task DeleteCategoryAsync(int id)
        {
            var category = await unitOfWork1.Categorias.GetByIdAsync(id);
            if (category == null)
            {
                throw new Exception($"Categoría con ID {id} no encontrada.");
            }
            await unitOfWork1.Categorias.DeleteAsync(id);
            await unitOfWork1.SaveChangesAsync();
            
        }
    }
}
