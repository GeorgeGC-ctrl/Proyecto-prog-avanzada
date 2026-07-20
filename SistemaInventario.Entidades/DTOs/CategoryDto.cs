using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entidades.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class CreateCategoryDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
