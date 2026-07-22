using FluentValidation;
using Northwind.Entities.DTOs;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace Northwind.LogicaNegocios.Productos
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IValidator<CreateProductDto> _createProductValidator;
        public ProductService(IUnitOfWork unitOfWork, IValidator<CreateProductDto> createProductValidator)
        {
            this.unitOfWork = unitOfWork;
            _createProductValidator = createProductValidator;
        }
        public async Task<IReadOnlyList<ProductsDto>> GetAllProductsAsync()
        {
            var products    = await unitOfWork.Productos.GetAllAsync();
            var categorias  = await unitOfWork.Categorias.GetAllAsync();
            var suplidores  = await unitOfWork.Suplidores.GetAllAsync();

            // Diccionarios para búsqueda rápida por ID
            var dictCategorias = categorias.ToDictionary(c => c.CategoryId, c => c.CategoryName);
            var dictSuplidores = suplidores.ToDictionary(s => s.SupplierID,            s => s.CompanyName);

            return products.Select(p => new ProductsDto
            {
                ProductID       = p.ProductID,
                ProductName     = p.ProductName,
                SupplierID      = p.SupplierID,
                CategoryID      = p.CategoryID,
                CategoriaNombre = p.CategoryID != null && dictCategorias.TryGetValue(p.CategoryID.GetValueOrDefault(), out var cat) ? cat : "Sin categoría",
                SuplidorNombre  = dictSuplidores.TryGetValue(p.SupplierID.GetValueOrDefault(), out var sup) ? sup : "Sin suplidor",
                UnitPrice       = p.UnitPrice,
                UnitsInStock     = p.UnitsInStock,
                UnitsOnOrder    = p.UnitsOnOrder,
                ReorderLevel    = p.ReorderLevel,
                Discontinued    = p.Discontinued
            }).ToList();
        }
        public async Task<ProductsDto> GetProductByIdAsync(int ProductID)
        {
            var product = await unitOfWork.Productos.GetByIdAsync(ProductID);
            if (product == null)
            {
                throw new Exception($"Producto con ID {ProductID} no encontrado.");
            }
            return new ProductsDto
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                SupplierID = product.SupplierID,
                CategoryID = product.CategoryID,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            };
        }
        public async Task<ProductsDto> CreateProductAsync(CreateProductDto createCategoryDto)
        {
            var validationResult = _createProductValidator.Validate(createCategoryDto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var newProduct = new Products
            {
                ProductName = createCategoryDto.ProductName,
                SupplierID = createCategoryDto.SupplierID,
                CategoryID = createCategoryDto.CategoryID,
                UnitPrice = createCategoryDto.UnitPrice,
                UnitsInStock = createCategoryDto.UnitsInStock,
                UnitsOnOrder = createCategoryDto.UnitsOnOrder,
                ReorderLevel = createCategoryDto.ReorderLevel,
                Discontinued = createCategoryDto.Discontinued
            };
            await unitOfWork.Productos.AddAsync(newProduct);
            await unitOfWork.SaveChangesAsync();

            return new ProductsDto
            {
                ProductID = newProduct.ProductID,
                ProductName = newProduct.ProductName,
                SupplierID = newProduct.SupplierID,
                CategoryID = newProduct.CategoryID,
                UnitPrice = newProduct.UnitPrice,
                UnitsInStock = newProduct.UnitsInStock,
                UnitsOnOrder = newProduct.UnitsOnOrder,
                ReorderLevel = newProduct.ReorderLevel,
                Discontinued = newProduct.Discontinued
            };
        }
        public async Task<ProductsDto> UpdateProductAsync(int ProductID, CreateProductDto updateProductDto)
        {
            var validationResult = _createProductValidator.Validate(updateProductDto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var product = await unitOfWork.Productos.GetByIdAsync(ProductID);
            if (product == null)
            {
                throw new Exception($"Producto con ID {ProductID} no encontrado.");
            }
            product.ProductName = updateProductDto.ProductName;
            product.SupplierID = updateProductDto.SupplierID;
            product.CategoryID = updateProductDto.CategoryID;
            product.UnitPrice = updateProductDto.UnitPrice;
            product.UnitsInStock = updateProductDto.UnitsInStock;
            product.UnitsOnOrder = updateProductDto.UnitsOnOrder;
            product.ReorderLevel = updateProductDto.ReorderLevel;
            product.Discontinued = updateProductDto.Discontinued;

            await unitOfWork.Productos.UpdateAsync(product);
            await unitOfWork.SaveChangesAsync();

            return new ProductsDto
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                SupplierID = product.SupplierID,
                CategoryID = product.CategoryID,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            };

        }
        public async Task DeleteProductAsync(int id)
        {
           if (await unitOfWork.Productos.GetByIdAsync(id) != null)
            {
                throw new Exception($"Producto con ID {id} no encontrado.");
            }

            await unitOfWork.Productos.DeleteAsync(id);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
