using FluentValidation;
using Northwind.Entities.DTOs;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace Northwind.LogicaNegocios.Suplidores
{
    public class SuppliersService : ISuppliersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<CreateSuppliersDto> _createSupplierValidator;
        public SuppliersService(IUnitOfWork unitOfWork, IValidator<CreateSuppliersDto> createSupplierValidator)
        {
            this._createSupplierValidator = createSupplierValidator;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<SuppliersDto>> GetAllSuppliersAsync()
        {
            var suppliers = await _unitOfWork.Suplidores.GetAllAsync();
            return suppliers.Select(s => new SuppliersDto
            {
                SupplierID = s.SupplierID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
                Address = s.Address,
                City = s.City,
                Country = s.Country,
                Phone = s.Phone,
                Fax = s.Fax,
                // Map properties from the entity to SuppliersDto
            }).ToList();
        }
        public async Task<SuppliersDto> GetSupplierByIdAsync(int id)
        {
            var supplier = await _unitOfWork.Suplidores.GetByIdAsync(id);
            if (supplier == null)
            {
                throw new Exception($"Suplidor con ID {id} no encontrado.");
            }
            return new SuppliersDto
            {
                SupplierID = supplier.SupplierID,
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                Address = supplier.Address,
                City = supplier.City,
                Country = supplier.Country,
                Phone = supplier.Phone,
                Fax = supplier.Fax,
                // Map properties from the entity to SuppliersDto
            };
        }
        public async Task<SuppliersDto> AddSupplierAsync(CreateSuppliersDto supplier)
        {
            var validationResult = _createSupplierValidator.Validate(supplier);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var newSupplier = new Suppliers
            {
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                Address = supplier.Address,
                City = supplier.City,
                Country = supplier.Country,
                Phone = supplier.Phone,
                Fax = supplier.Fax,

            };

            await _unitOfWork.Suplidores.AddAsync(newSupplier);
            await _unitOfWork.SaveChangesAsync();

            return new SuppliersDto
            {
                SupplierID = newSupplier.SupplierID,
                CompanyName = newSupplier.CompanyName,
                ContactName = newSupplier.ContactName,
                Address = newSupplier.Address,
                City = newSupplier.City,
                Country = newSupplier.Country,
                Phone = newSupplier.Phone,
                Fax = newSupplier.Fax,
                // Map properties from SuppliersDto to Suplidores entity
            };
        }
        public async Task<SuppliersDto> UpdateSupplierAsync(int id, CreateSuppliersDto supplier)
        {
            var existingSupplier = await _unitOfWork.Suplidores.GetByIdAsync(id);
            if (existingSupplier == null)
            {
                throw new Exception($"Suplidor con ID {id} no encontrado.");
            }
            var validationResult = _createSupplierValidator.Validate(supplier);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            existingSupplier.CompanyName = supplier.CompanyName;
            existingSupplier.ContactName = supplier.ContactName;
            existingSupplier.Address = supplier.Address;
            existingSupplier.City = supplier.City;
            existingSupplier.Country = supplier.Country;
            existingSupplier.Phone = supplier.Phone;
            existingSupplier.Fax = supplier.Fax;

            await _unitOfWork.Suplidores.UpdateAsync(existingSupplier);
            await _unitOfWork.SaveChangesAsync();

            return new SuppliersDto
            {
                SupplierID = existingSupplier.SupplierID,
                CompanyName = existingSupplier.CompanyName,
                ContactName = existingSupplier.ContactName,
                Address = existingSupplier.Address,
                City = existingSupplier.City,
                Country = existingSupplier.Country,
                Phone = existingSupplier.Phone,
                Fax = existingSupplier.Fax,
                // Map properties from SuppliersDto to Suplidores entity
            };

        }
        public async Task DeleteSupplierAsync(int id)
        {
            var existingSupplier = await _unitOfWork.Suplidores.GetByIdAsync(id);
            if (existingSupplier == null)
            {
                throw new Exception($"Suplidor con ID {id} no encontrado.");
            }
            var productos = await _unitOfWork.Productos.GetAllAsync();
            bool tieneProductos = productos.Any(p => p.SupplierID == id);
            if (tieneProductos)
            {
                throw new InvalidOperationException(
                    $"No se puede eliminar el suplidor '{existingSupplier.CompanyName}' porque tiene productos asociados.");
            }
            await _unitOfWork.Suplidores.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();

        }

    }
}