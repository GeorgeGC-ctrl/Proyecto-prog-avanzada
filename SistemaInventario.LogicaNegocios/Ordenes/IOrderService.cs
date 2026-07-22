using Northwind.Entities.DTOs;

namespace Northwind.LogicaNegocios.Ordenes
{
    public interface IOrderService
    {
        Task<IEnumerable<OrdersDto>> GetAllOrdersAsync();
        Task<OrdersDto> GetOrderByIdAsync(int id);
        Task<OrdersDto> CreateOrderAsync(CreateOrderDto orderDto);
        Task DeleteOrderAsync(int id);
    }
}
