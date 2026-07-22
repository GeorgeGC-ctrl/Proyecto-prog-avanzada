using Northwind.Entities.DTOs;

namespace Northwind.LogicaNegocios.Suplidores
{
    public interface ISuppliersService
    {
        Task<IEnumerable<SuppliersDto>> GetAllSuppliersAsync();
        Task<SuppliersDto> GetSupplierByIdAsync(int id);
        Task<SuppliersDto> AddSupplierAsync(CreateSuppliersDto supplier);
        Task<SuppliersDto> UpdateSupplierAsync(int id, CreateSuppliersDto supplier);
        Task DeleteSupplierAsync(int id);
    }
}