namespace Northwind.Entities.DTOs
{
    // Para mostrar en el DataGridView
    public class OrdersDto
    {
        public int OrderID { get; set; }
        public string? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipCountry { get; set; }

        // Propiedad calculada para mostrar el total de la orden
        public decimal Total { get; set; }

        // Los detalles de esta orden
        public List<OrderDetailsDto> Detalles { get; set; } = new();
    }

    // Para crear una orden nueva (cabecera + líneas)
    public class CreateOrderDto
    {
        public string? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? RequiredDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipCountry { get; set; }

        // Las líneas del detalle
        public List<CreateOrderDetailDto> Detalles { get; set; } = new();
    }
}
