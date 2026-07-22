namespace Northwind.Entities.DTOs
{
    // Para mostrar un detalle
    public class OrderDetailsDto
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        // Subtotal calculado
        public decimal Subtotal => UnitPrice * Quantity * (1 - (decimal)Discount);
    }

    // Para crear una línea de detalle
    public class CreateOrderDetailDto
    {
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
