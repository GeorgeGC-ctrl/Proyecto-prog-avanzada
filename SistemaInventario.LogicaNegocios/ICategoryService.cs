using Northwind.Entidades.DTOs;

namespace SistemaInventario.LogicaNegocios
{
    public interface ICategoryService
    {
        Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync();

        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<CategoryDto> UpdateCategoryAsync(int id, CreateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(int id);

    }
}
