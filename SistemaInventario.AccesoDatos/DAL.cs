using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using SistemaInventario.Entidades;
using System;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaInventario.AccesoDatos
{
    public class DAL
    {
        public static class Logger
        {

            private static readonly string RutaArchivo = "errores.log";


            public static void LogError(Exception ex)
            {
                try
                {
                    // Formateamos un bloque de texto claro y ordenado
                    string mensaje = $"==================================================\n" +
                                     $"FECHA Y HORA: {DateTime.Now}\n" +
                                     $"TIPO DE ERROR: {ex.GetType().FullName}\n" +
                                     $"MENSAJE: {ex.Message}\n" +
                                     $"MÉTODO AFECTADO: {ex.TargetSite}\n" +
                                     $"==================================================\n\n";


                    File.AppendAllText(RutaArchivo, mensaje);
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "notepad.exe",
                        Arguments = RutaArchivo,
                        UseShellExecute = true
                    });
                }
                catch
                {

                }

            }
            public static void AbrirLogEnNotepad()
            {
                try
                {
                    if (File.Exists(RutaArchivo))
                    {
                        Process.Start("notepad.exe", RutaArchivo);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }


        public class DashboardDAL
        {
            public DashboardStats ObtenerEstadisticas()
            {
                DashboardStats stats = new DashboardStats();
                try
                {
                    using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                    {

                        var comando = new SqlCommand("sp_DashboardStats", conexion);
                        comando.CommandType = CommandType.StoredProcedure;
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stats.TotalProductos = reader.GetInt32(0);
                                stats.TotalCategorias = reader.GetInt32(1);
                                stats.TotalSuplidores = reader.GetInt32(2);
                                stats.TotalEliminados = reader.GetInt32(3);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Logger.LogError(ex);
                    throw new Exception("No se pudieron obtener las estadísticas del dashboard debido a un problema de la base de datos. Por favor, intente más tarde.");
                }
                return stats;
            }
        }
        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> categorias = new List<Categorias>();

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {

                    var comando = new SqlCommand("SELECT IdCategorias, Nombre, Descripcion, Activo, FechaCreacion, FechaModificacion FROM Categorias where activo=1", conexion);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoria = new Categorias
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.GetString(2),
                                Activo = reader.GetBoolean(3),
                                FechaCreacion = reader.GetDateTime(4),
                                FechaModificacion = reader.GetDateTime(5)
                            };
                            categorias.Add(categoria);
                        }
                        return categorias;
                    }
                }

            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);

                throw new Exception("No se pudo recuperar la lista de productos desde la base de datos. Por favor, intente más tarde.");
            }

        }

        public List<Productos> ObtenerProductos()
        {
            List<Productos> productos = new List<Productos>();

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {

                    var comando = new SqlCommand(@"
            SELECT 
            p.IdProducto, 
            p.Nombre, 
            p.PrecioUnitario, 
            s.Empresa AS Suplidor, 
            c.Nombre AS Categoria, 
            p.Activo, 
            p.FechaCreacion, 
            p.FechaModificacion 
        FROM Productos p
        INNER JOIN Suplidores s ON p.SuplidorId = s.IdSuplidor
        INNER JOIN Categorias c ON p.CategoriaId = c.IdCategorias
        WHERE p.Activo = 1", conexion);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var producto = new Productos
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Precio = reader.GetDecimal(2),
                                Suplidor = reader.GetString(3),
                                Categoria = reader.GetString(4),
                                Activo = reader.GetBoolean(5),
                                FechaCreacion = reader.GetDateTime(6),
                                FechaModificacion = reader.GetDateTime(7)
                            };
                            productos.Add(producto);
                        }
                        return productos;
                    }
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception("No se pudo recuperar la lista de productos desde la base de datos. Por favor, intente más tarde.");
            }

        }
        public List<Suplidores> ObtenerSuplidores()
        {
            List<Suplidores> suplidores = new List<Suplidores>();


            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {

                    var comando = new SqlCommand("SELECT IdSuplidor, Empresa, Contacto, Telefono, Correo, Sitioweb, Activo, FechaCreacion, FechaModificacion FROM Suplidores where activo=1", conexion);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var suplidor = new Suplidores
                            {
                                Id = reader.GetInt32(0),
                                Empresa = reader.GetString(1),
                                Contacto = reader.GetString(2),
                                Telefono = reader.GetString(3),
                                Email = reader.GetString(4),
                                website = reader.GetString(5),
                                Activo = reader.GetBoolean(6),
                                FechaCreacion = reader.GetDateTime(7),
                                FechaModificacion = reader.GetDateTime(8)
                            };
                            suplidores.Add(suplidor);
                        }
                        return suplidores;
                    }
                }

            }

            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception("No se pudo recuperar la lista de suplidores desde la base de datos. Por favor, intente más tarde.");
            }

        }

        public void AgregarCategoria(Categorias categoria)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_Insertar_categoria",
                conexion);

                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", categoria.Descripcion);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(
                    "No se pudo agregar la categoría debido a un problema de la base de datos."
                );
            }
        }
        public void AgregarProducto(Productos producto)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_agregarProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@suplidorId", producto.SuplidorId);
                    comando.Parameters.AddWithValue("@categoriaId", producto.CategoriaId);
                    comando.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }


        }

        public void AgregarSuplidor(Suplidores suplidor)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_insertarSuplidor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@empresa", suplidor.Empresa);
                    comando.Parameters.AddWithValue("@contacto", suplidor.Contacto);
                    comando.Parameters.AddWithValue("@telefono", suplidor.Telefono);
                    comando.Parameters.AddWithValue("@correo", suplidor.Email);
                    comando.Parameters.AddWithValue("@web", suplidor.website);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception("No se pudo agregar el suplidor debido a un problema de la base de datos.Se registro el error");
            }

        }

        public void EliminarCategoria(int id)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_eliminarCategoria", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Id", id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception("No se pudo eliminar la categoría debido a un problema interno en el servidor de base de datos.El error ya ha sido registrado.");
            }

        }
        public void EliminarProducto(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_eliminarProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }

        }
        public void EliminarSuplidor(int id)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_eliminarSuplidor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Id", id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception("No se puede eliminar el suplidor debido a un problema interno de la base de datos");
            }

        }
        public void ActualizarCategoria(Categorias categoria)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_Modificar_Categoria", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdCategorias", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@Activo", categoria.Activo);
                    comando.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw;
            }


        }

        public void ActualizarProducto(Productos producto)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_actualizarProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", producto.Id);
                    comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@precio", producto.Precio);
                    comando.Parameters.AddWithValue("@categoriaId", producto.CategoriaId);
                    comando.Parameters.AddWithValue("@suplidorId", producto.SuplidorId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }
        }

        public void ActualizarSuplidor(Suplidores suplidor)
        {

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_modificarSuplidor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdSuplidores", suplidor.Id);
                    comando.Parameters.AddWithValue("@Empresa", suplidor.Empresa);
                    comando.Parameters.AddWithValue("@Contacto", suplidor.Contacto);
                    comando.Parameters.AddWithValue("@Telefono", suplidor.Telefono);
                    comando.Parameters.AddWithValue("@Email", suplidor.Email);
                    comando.Parameters.AddWithValue("@website", suplidor.website);
                    comando.Parameters.AddWithValue("@Activo", suplidor.Activo);
                    comando.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);

                throw new Exception(ex.Message);
            }


        }
        public List<Suplidores> PapeleraSuplidores()
        {
            List<Suplidores> suplidoresPapelera = new List<Suplidores>();


            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("select * from Suplidores where activo=0", conexion);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var suplidorEliminado = new Suplidores
                            {
                                Id = reader.GetInt32(0),
                                Empresa = reader.GetString(1),
                                Contacto = reader.GetString(2),
                                Telefono = reader.GetString(3),
                                Email = reader.GetString(4),
                                website = reader.GetString(5),
                                Activo = reader.GetBoolean(8),
                                FechaCreacion = reader.GetDateTime(6),
                                FechaModificacion = reader.GetDateTime(7)
                            };
                            suplidoresPapelera.Add(suplidorEliminado);
                        }
                    }
                    return suplidoresPapelera;
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);

                throw new Exception(ex.Message);
            }
        }

        public List<Categorias> PapeleraCategorias()
        {
            List<Categorias> CategoriaPapelera = new List<Categorias>();


            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("Select * from Categorias where activo=0", conexion);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoriaEliminada = new Categorias
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.GetString(2),
                                Activo = reader.GetBoolean(3),
                                FechaCreacion = reader.GetDateTime(4),
                                FechaModificacion = reader.GetDateTime(5)
                            };
                            CategoriaPapelera.Add(categoriaEliminada);
                        }
                        return CategoriaPapelera;

                    }
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);

                throw new Exception(ex.Message);
            }
        }

        public List<Productos> ProductosPapelera()
        {

            List<Productos> ProductosEliminados = new List<Productos>();

            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("Select* from Productos where activo=0", conexion);

                    var reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var productoEliminado = new Productos
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2),
                            SuplidorId = reader.GetInt32(3),
                            CategoriaId = reader.GetInt32(4),
                            Activo = reader.GetBoolean(5),
                            FechaCreacion = reader.GetDateTime(6),
                            FechaModificacion = reader.GetDateTime(7)
                        };

                        ProductosEliminados.Add(productoEliminado);
                    }

                    return ProductosEliminados;

                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);

                throw new Exception(ex.Message);
            }
        }

        public List<Categorias> ListarCategorias()
        {
            List<Categorias> listaCategorias = new List<Categorias>();

            using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
            {
                string query = @"SELECT IdCategorias, Nombre
                         FROM Categorias
                         WHERE Activo = 1
                         ORDER BY Nombre";

                SqlCommand cmd = new SqlCommand(query, conexion);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listaCategorias.Add(new Categorias
                        {
                            Id = Convert.ToInt32(dr["IdCategorias"]),
                            Nombre = dr["Nombre"].ToString()
                        });
                    }
                }
            }

            return listaCategorias;
        }
        public List<Suplidores> ListarSuplidores()
        {
            List<Suplidores> listaSuplidores = new List<Suplidores>();

            using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
            {
                string query = @"SELECT IdSuplidor, Empresa
                         FROM Suplidores
                         WHERE Activo = 1
                         ORDER BY Empresa";

                SqlCommand cmd = new SqlCommand(query, conexion);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listaSuplidores.Add(new Suplidores
                        {
                            Id = Convert.ToInt32(dr["IdSuplidor"]),
                            Empresa = dr["Empresa"].ToString()
                        });
                    }
                }
            }

            return listaSuplidores;
        }

        public void RestaurarProducto(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_restaurarProducto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }
        }

        public void RestaurarCategoria(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_restaurarCategoria", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }
        }

        public void RestaurarSuplidor(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("sp_restaurarSuplidor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.LogError(ex);
                throw new Exception(ex.Message);
            }
        }
    }
}       