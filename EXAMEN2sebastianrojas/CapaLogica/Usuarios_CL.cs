using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EXAMEN2sebastianrojas.CapaLogica
{
    public class Usuarios_CL
    {
        public static int Agregar(string nombre, string correo, string telefono)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Borrar(int id)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BorrarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Modificar(int id, string nombre, string correo, string telefono)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ModificarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}