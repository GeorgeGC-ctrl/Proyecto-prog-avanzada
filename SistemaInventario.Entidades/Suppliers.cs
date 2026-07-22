using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaInventario.Entidades
{
    [Table("Suppliers")]
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; } // Permitir nulos
        public string? Address { get; set; }     // Permitir nulos
        public string? City { get; set; }        // Permitir nulos
        public string? Country { get; set; }     // Permitir nulos
        public string? Phone { get; set; }       // Permitir nulos
        public string? Fax { get; set; }
    }
}
//nombre de empresa, contacto, dirección, ciudad, país, teléfono y fax.