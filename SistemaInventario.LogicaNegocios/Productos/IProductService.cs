using Northwind.Entities.DTOs;

namespace Northwind.LogicaNegocios.Productos
{
    public interface IProductService
    {
        Task<IReadOnlyList<ProductsDto>> GetAllProductsAsync();

        Task<ProductsDto> GetProductByIdAsync(int ProductID);
        Task<ProductsDto> CreateProductAsync(CreateProductDto createProductDto);
        Task<ProductsDto> UpdateProductAsync(int ProductID, CreateProductDto updateProductDto);
        Task DeleteProductAsync(int id);

    }
}
