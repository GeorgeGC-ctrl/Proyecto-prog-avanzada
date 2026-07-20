using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;
using System;
using System.Text.RegularExpressions;
using static SistemaInventario.AccesoDatos.NorthwindDbContext;

namespace SistemaInventario.LogicaNegocios
{
    public class BL
    {
        private readonly NorthwindDbContext _dal;
        public BL()
        {
            _dal = new NorthwindDbContext();
        }

        public List<Entidades.Categorias> ObtenerCategorias()
        {
            return _dal.ObtenerCategorias();
        }
        public List<Entidades.Categorias> ComboCategorias()
        {
            return _dal.ListarCategorias();
        }
        public void RegistrarCategoria(Categorias categorias)
        {
            if (string.IsNullOrWhiteSpace(categorias.Nombre))
                throw new Exception("El nombre de la categoría no puede estar vacío.");

            if (categorias.Nombre.Trim().Length > 100)
                throw new Exception("El nombre de la categoría no puede superar 100 caracteres.");

            _dal.AgregarCategoria(categorias);
        }
        public void EliminarCategoria(int id)
        {
            _dal.EliminarCategoria(id);
        }
    }

    public class ProductosBL
    {
        private readonly NorthwindDbContext _dal;
        public ProductosBL()
        {
            _dal = new NorthwindDbContext();
        }

        public List<Entidades.Productos> ObtenerProductos()
        {
            return _dal.ObtenerProductos();
        }

        public void RegistrarProducto(Productos productos)
        {
            ValidarProducto(productos);
            _dal.AgregarProducto(productos);
        }

        public void ActualizarProducto(Productos productos)
        {
            ValidarProducto(productos);
            _dal.ActualizarProducto(productos);
        }

        public void EliminarProduct(int id)
        {
            _dal.EliminarProducto(id);
        }

        private void ValidarProducto(Productos p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del producto no puede estar vacío.");

            if (p.Nombre.Trim().Length > 100)
                throw new Exception("El nombre del producto no puede superar 100 caracteres.");

            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (decimal.Round(p.Precio, 2) != p.Precio)
                throw new Exception("El precio no puede tener más de 2 decimales.");

            if (p.CategoriaId <= 0)
                throw new Exception("Debe seleccionar una categoría válida.");

            if (p.SuplidorId <= 0)
                throw new Exception("Debe seleccionar un suplidor válido.");
        }
        // LINQ 1: Productos agrupados por categoría con conteo
        public List<(string Categoria, int Total)> ProductosPorCategoria()
        {
            return _dal.ObtenerProductos()
                .GroupBy(p => p.CategoriaNombre)
                .Select(g => (Categoria: g.Key ?? "Sin categoría", Total: g.Count()))
                .OrderByDescending(x => x.Total)
                .ToList();
        }

        public List<(string Suplidor, int Total)> Top5Suplidores()
        {
            return _dal.ObtenerProductos()
                .GroupBy(p => p.SuplidorNombre)
                .Select(g => (Suplidor: g.Key ?? "Sin suplidor", Total: g.Count()))
                .OrderByDescending(x => x.Total)
                .Take(5)
                .ToList();
        }

        public List<Productos> ProductosPorRangoYCategoria(decimal precioMin, decimal precioMax, string categoria)
        {
            return _dal.ObtenerProductos()
                .Where(p => p.Precio >= precioMin && p.Precio <= precioMax
                         && (string.IsNullOrEmpty(categoria) ||
                             p.CategoriaNombre.Equals(categoria, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(p => p.Precio)
                .ToList();
        }

        public List<Productos> BuscarProductos(string termino)
        {
            return _dal.ObtenerProductos()
                .Where(p => p.Nombre.Contains(termino, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<(string Categoria, decimal Promedio)> PromedioPrecioPorCategoria()
        {
            return _dal.ObtenerProductos()
                .GroupBy(p => p.CategoriaNombre)
                .Select(g => (
                    Categoria: g.Key ?? "Sin categoría",
                    Promedio: Math.Round(g.Average(p => p.Precio), 2)
                ))
                .OrderByDescending(x => x.Promedio)
                .ToList();
        }
    }

    public class SuplidoresBL
    {
        private readonly NorthwindDbContext _dal;
        public SuplidoresBL()
        {
            _dal = new NorthwindDbContext();
        }

        public List<Entidades.Suplidores> ObtenerSuplidores()
        {
            return _dal.ObtenerSuplidores();
        }

        public List<Entidades.Suplidores> ComboSuplidores()
        {
            return _dal.ListarSuplidores();
        }

        public void RegistrarSuplidor(Suplidores suplidores)
        {
            ValidarSuplidor(suplidores);
            _dal.AgregarSuplidor(suplidores);
        }

        public void EliminarProducto(int id)
        {
            _dal.EliminarSuplidor(id);
        }

        private void ValidarSuplidor(Suplidores s)
        {
            if (string.IsNullOrWhiteSpace(s.Empresa))
                throw new Exception("El nombre de la empresa no puede estar vacío.");

            if (s.Empresa.Trim().Length > 100)
                throw new Exception("El nombre de la empresa no puede superar 100 caracteres.");

            if (string.IsNullOrWhiteSpace(s.Contacto))
                throw new Exception("El nombre de contacto no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(s.Telefono) || s.Telefono.Trim() == "--")
                throw new Exception("El teléfono es obligatorio.");

            if (!Regex.IsMatch(s.Telefono.Trim(), @"^(809|829|849)-\d{3}-\d{4}$"))
                throw new Exception("Formato de teléfono inválido. Use (809|829|849)-000-0000.");

            if (string.IsNullOrWhiteSpace(s.Email))
                throw new Exception("El correo electrónico es obligatorio.");

            if (!Regex.IsMatch(s.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new Exception("Ingrese un correo electrónico válido.");

            if (!string.IsNullOrWhiteSpace(s.website))
            {
                bool esUrl = Uri.TryCreate(s.website.Trim(), UriKind.Absolute, out Uri uri)
                             && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
                if (!esUrl)
                    throw new Exception("El sitio web debe ser una URL válida (ej: https://empresa.com).");
            }
        }
    }

    public class DashboardBLL
    {
        private readonly DashboardDAL _dal;
        public DashboardBLL()
        {
            _dal = new DashboardDAL();
        }
        public DashboardStats GetStats()
        {
            return _dal.ObtenerEstadisticas();
        }
    }

    public class PapeleraSuplidor
    {
        private readonly NorthwindDbContext _dal;
        public PapeleraSuplidor()
        {
            _dal = new NorthwindDbContext();
        }
        public List<Entidades.Suplidores> PapeleraSuplidores()
        {
            return _dal.PapeleraSuplidores();
        }
        public void RestaurarSuplidor(int id) => _dal.RestaurarSuplidor(id);
    }

    public class PapeleraCategoria
    {
        private readonly NorthwindDbContext _dal;
        public PapeleraCategoria()
        {
            _dal = new NorthwindDbContext();
        }
        public List<Entidades.Categorias> PapeleraCategorias()
        {
            return _dal.PapeleraCategorias();
        }
        public void RestaurarCategoria(int id) => _dal.RestaurarCategoria(id);
    
}

    public class PapeleraProducto
    {
        private readonly NorthwindDbContext _dal;
        public PapeleraProducto()
        {
            _dal = new NorthwindDbContext();
        }
        public List<Entidades.Productos> ProductosPapelera()
        {
            return _dal.ProductosPapelera();
        }
        public void RestaurarProducto(int id) => _dal.RestaurarProducto(id);
    }
}