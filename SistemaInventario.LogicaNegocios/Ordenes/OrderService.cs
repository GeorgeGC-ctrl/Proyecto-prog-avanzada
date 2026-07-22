using FluentValidation;
using Northwind.Entities.DTOs;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;

namespace Northwind.LogicaNegocios.Ordenes
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<CreateOrderDto> _validator;

        public OrderService(IUnitOfWork unitOfWork, IValidator<CreateOrderDto> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        // ── Listar todas las órdenes ─────────────────────────
        public async Task<IEnumerable<OrdersDto>> GetAllOrdersAsync()
        {
            var orders = await _unitOfWork.Ordenes.GetAllAsync();

            return orders.Select(o => new OrdersDto
            {
                OrderID = o.OrderID,
                CustomerID = o.CustomerID,
                EmployeeID = o.EmployeeID,
                OrderDate = o.OrderDate,
                RequiredDate = o.RequiredDate,
                ShippedDate = o.ShippedDate,
                Freight = o.Freight,
                ShipName = o.ShipName,
                ShipAddress = o.ShipAddress,
                ShipCity = o.ShipCity,
                ShipCountry = o.ShipCountry,
            }).ToList();
        }

        // ── Obtener una orden con sus detalles ───────────────
        public async Task<OrdersDto> GetOrderByIdAsync(int id)
        {
            var order = await _unitOfWork.Ordenes.GetByIdAsync(id);
            if (order == null)
                throw new Exception($"Orden con ID {id} no encontrada.");

            // Buscar los detalles de esta orden
            var todosDetalles = await _unitOfWork.DetallesOrdenes.GetAllAsync();
            var detallesOrden = todosDetalles.Where(d => d.OrderID == id).ToList();

            // Buscar nombres de productos
            var productos = await _unitOfWork.Productos.GetAllAsync();
            var productosDict = productos.ToDictionary(p => p.ProductID, p => p.ProductName);

            var dto = new OrdersDto
            {
                OrderID = order.OrderID,
                CustomerID = order.CustomerID,
                EmployeeID = order.EmployeeID,
                OrderDate = order.OrderDate,
                RequiredDate = order.RequiredDate,
                ShippedDate = order.ShippedDate,
                Freight = order.Freight,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipCity = order.ShipCity,
                ShipCountry = order.ShipCountry,
                Detalles = detallesOrden.Select(d => new OrderDetailsDto
                {
                    OrderID = d.OrderID,
                    ProductID = d.ProductID,
                    ProductName = productosDict.ContainsKey(d.ProductID)
                        ? productosDict[d.ProductID] : "Desconocido",
                    UnitPrice = d.UnitPrice,
                    Quantity = d.Quantity,
                    Discount = d.Discount,
                }).ToList()
            };

            // Calcular total
            dto.Total = dto.Detalles.Sum(d => d.Subtotal);

            return dto;
        }

        // ── Crear orden con detalles (TRANSACCIÓN) ───────────
        public async Task<OrdersDto> CreateOrderAsync(CreateOrderDto orderDto)
        {
            // Validar
            var validationResult = _validator.Validate(orderDto);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            try
            {
                // 1. Iniciar transacción
                await _unitOfWork.BeginTransaction();

                // 2. Crear la cabecera de la orden
                var newOrder = new Orders
                {
                    CustomerID = orderDto.CustomerID,
                    EmployeeID = orderDto.EmployeeID,
                    OrderDate = DateTime.Now,
                    RequiredDate = orderDto.RequiredDate,
                    ShipVia = orderDto.ShipVia,
                    Freight = orderDto.Freight,
                    ShipName = orderDto.ShipName,
                    ShipAddress = orderDto.ShipAddress,
                    ShipCity = orderDto.ShipCity,
                    ShipCountry = orderDto.ShipCountry,
                };

                await _unitOfWork.Ordenes.AddAsync(newOrder);
                // Después de AddAsync, newOrder.OrderID ya tiene el ID generado

                // 3. Crear cada línea de detalle
                foreach (var detalle in orderDto.Detalles)
                {
                    var newDetail = new OrderDetails
                    {
                        OrderID = newOrder.OrderID,
                        ProductID = detalle.ProductID,
                        UnitPrice = detalle.UnitPrice,
                        Quantity = detalle.Quantity,
                        Discount = detalle.Discount,
                    };

                    await _unitOfWork.DetallesOrdenes.AddAsync(newDetail);
                }

                // 4. Confirmar la transacción
                await _unitOfWork.CommitTransaction();

                // 5. Retornar la orden creada
                return await GetOrderByIdAsync(newOrder.OrderID);
            }
            catch
            {
                // Si algo falla, revertir TODO
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }

        // ── Eliminar orden y sus detalles ────────────────────
        public async Task DeleteOrderAsync(int id)
        {
            var order = await _unitOfWork.Ordenes.GetByIdAsync(id);
            if (order == null)
                throw new Exception($"Orden con ID {id} no encontrada.");

            try
            {
                await _unitOfWork.BeginTransaction();

                // Primero eliminar los detalles (por la FK)
                var todosDetalles = await _unitOfWork.DetallesOrdenes.GetAllAsync();
                var detallesOrden = todosDetalles.Where(d => d.OrderID == id).ToList();

                foreach (var detalle in detallesOrden)
                {
                    // Usar DeleteEntityAsync porque la clave es compuesta
                    await _unitOfWork.DetallesOrdenes.DeleteEntityAsync(detalle);
                }

                // Luego eliminar la orden
                await _unitOfWork.Ordenes.DeleteAsync(id);

                await _unitOfWork.CommitTransaction();
            }
            catch
            {
                await _unitOfWork.RollbackTransaction();
                throw;
            }
        }
    }
}
