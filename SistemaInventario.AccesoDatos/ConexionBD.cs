using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos
{
    public class ConexionBD
    {
        private static ConexionBD _instancia = null;
        private readonly string _cadenaConexion;

        private ConexionBD()
        {

            _cadenaConexion = "Server=DESKTOP-DH1O5F3;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;";
        }


        public static ConexionBD Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConexionBD();
                }
                return _instancia;
            }
        }


        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}

