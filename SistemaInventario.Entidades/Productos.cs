using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades
{
     public class Productos
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int SuplidorId { get; set; }
            public string Categoria { get; set; }
        public string CategoriaNombre { get; set; }
        public string SuplidorNombre { get; set; }

        public string Suplidor {  get; set; }
            public int CategoriaId { get; set; }
            public bool Activo { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaModificacion { get; set; }
        }
    }

