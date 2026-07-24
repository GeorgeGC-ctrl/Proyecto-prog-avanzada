using FluentValidation;
using Northwind.Entidades.DTOs;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;
using System.Data;
using static Northwind.LogicaNegocios.Categorias.CreateCategoryValidator;

namespace Northwind.LogicaNegocios.Categorias
{
    public class CategoryService : ICategoryService
    {
        
        private readonly IUnitOfWork unitOfWork1;
        private readonly IValidator<CreateCategoryDto> _createCategoryValidator;
        private readonly IValidator<int> _deleteCategoryIdValidator;

        public CategoryService(IUnitOfWork unitOfWork, IValidator<CreateCategoryDto> createCategoryValidator, IValidator<int> deleteCategoryIdValidator)
        {
            unitOfWork1 = unitOfWork;
            _createCategoryValidator = createCategoryValidator;
            _deleteCategoryIdValidator = deleteCategoryIdValidator;

        }
        public async Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await unitOfWork1.Categorias.GetAllAsync();
            return categories.Select (c => new CategoryDto
            {
                Id = c.CategoryId,
                Nombre = c.CategoryName,
                Descripcion = c.Description
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
                Id = category.CategoryId,
                Nombre = category.CategoryName,
                Descripcion = category.Description
            };
        }
        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var validationResult = _createCategoryValidator.Validate(createCategoryDto);
            
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var category = new Categories
            {
                CategoryName = createCategoryDto.Nombre,
                Description = createCategoryDto.Descripcion,
                
            };
           
            await unitOfWork1.Categorias.AddAsync(category);
            await unitOfWork1.SaveChangesAsync();

            return new CategoryDto
            {
                Id = category.CategoryId,
                Nombre = category.CategoryName,
                Descripcion = category.Description
            };
        }

        public async Task<CategoryDto> UpdateCategoryAsync(int id, CreateCategoryDto updateCategoryDto)
        {
            var validationResult = _createCategoryValidator.Validate(updateCategoryDto);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var category = await unitOfWork1.Categorias.GetByIdAsync(id);
            if (category == null)
            {
                throw new Exception($"Categoría con ID {id} no encontrada.");
            }

            category.CategoryName = updateCategoryDto.Nombre;
            category.Description = updateCategoryDto.Descripcion;

            await unitOfWork1.Categorias.UpdateAsync(category); // Actualiza y guarda en DB

            return new CategoryDto
            {
                Id = category.CategoryId,
                Nombre = category.CategoryName,
                Descripcion = category.Description
            };
        }
        public async Task DeleteCategoryAsync(int id)
        {
            var category = await unitOfWork1.Categorias.GetByIdAsync(id);
            if (category == null)
            {
                throw new Exception($"Categoría con ID {id} no encontrada.");
            }
            var validationResult = await _deleteCategoryIdValidator.ValidateAsync(id);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);
    
            await unitOfWork1.Categorias.DeleteAsync(id);
            await unitOfWork1.SaveChangesAsync();
            
        }
    }

}
