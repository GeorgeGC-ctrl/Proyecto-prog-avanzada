using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaInventario.Entidades
{
    [Table("Order Details")]
    public class OrderDetails
    {
        // Clave compuesta: OrderID + ProductID
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        // Navegación
        [ForeignKey("OrderID")]
        public Orders? Order { get; set; }

        [ForeignKey("ProductID")]
        public Products? Product { get; set; }
    }
}
