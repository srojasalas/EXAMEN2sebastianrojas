using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EXAMEN2sebastianrojas.CapaLogica
{
    public class Tecnicos_CL
    {
        public static int Agregar(string nombre, string especialidad)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_AgregarTecnico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Borrar(int id)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BorrarTecnico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Modificar(int id, string nombre, string especialidad)
        {
            int retorno = 0;
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ModificarTecnico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}