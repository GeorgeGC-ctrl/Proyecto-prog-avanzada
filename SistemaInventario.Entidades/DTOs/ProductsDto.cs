using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.DTOs
{
    public class ProductsDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string? QuantityPerUnit { get; set; }
        // Nombres resueltos para mostrar en el DataGridView
        public string? CategoriaNombre { get; set; }
        public string? SuplidorNombre { get; set; }
        public string Estado => Discontinued ? "Descontinuado" : "Activo";

    }

    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string? QuantityPerUnit { get; set; }
    }

}