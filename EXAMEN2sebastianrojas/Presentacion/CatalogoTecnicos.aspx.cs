using EXAMEN2sebastianrojas.CapaLogica;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXAMEN2sebastianrojas.Presentacion
{
    public partial class CatalogoTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tecnicos", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvTecnicos.DataSource = dt;
                        gvTecnicos.DataBind();
                    }
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Tecnicos_CL.Agregar(txtNombre.Text, txtEspecialidad.Text) > 0)
            {
                LlenarGrid();
                Limpiar();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (Tecnicos_CL.Modificar(id, txtNombre.Text, txtEspecialidad.Text) > 0)
                {
                    LlenarGrid();
                    Limpiar();
                }
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (Tecnicos_CL.Borrar(id) > 0)
                {
                    LlenarGrid();
                    Limpiar();
                }
            }
        }

        private void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtEspecialidad.Text = "";
        }
    }
}