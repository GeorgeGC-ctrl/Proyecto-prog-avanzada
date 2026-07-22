using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }= string.Empty;
        public decimal? UnitPrice { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string? QuantityPerUnit { get; set; }
        public string Estado => Discontinued ? "Descontinuado" : "Activo";

    }
}

