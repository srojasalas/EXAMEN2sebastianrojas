using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EXAMEN2sebastianrojas.CapaLogica
{
    public class DBconn
    {
        public static SqlConnection obtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}