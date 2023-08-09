using Controladores;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class AsignarEstudiante : System.Web.UI.Page
    {
        int idGrupo=0;
        DatosSQL sQL = new DatosSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                
                if (Session["idGrupo"] != null) {
                    idGrupo = (int)Session["idGrupo"];
                }
                List<Modelos.Estudiante> lstestudiante1 = sQL.TraerEstudiantessingrupo(idGrupo);
                dropEstudiantes.Items.Add("Seleccione un estudiante");
                foreach (Estudiante est in lstestudiante1) {
                    dropEstudiantes.Items.Add($"{est.IdUsuario}-{est.Nombre}");
                }

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Nombre del estudiante",typeof(string));
                List<Modelos.Estudiante> lstestudiante2 = sQL.TraerEstudiantesdelgrupo(idGrupo);
                foreach (Estudiante est in lstestudiante2)
                {
                    tabla.Rows.Add(est.Nombre);
                }
                gdvTabla.DataSource = tabla;
                gdvTabla.DataBind();


            }

        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            if (!dropEstudiantes.SelectedValue.Equals("Seleccione un estudiante")) {
                string seleccionado = dropEstudiantes.SelectedValue;
                string[] data = seleccionado.Split('-');
                int idestudiante = Convert.ToInt32(data[0]);
                idGrupo = (int)Session["idGrupo"];
                sQL.InsertarEstudianteGrupo(idGrupo,idestudiante);

            }
            Response.Redirect("PanelProfesor.aspx");
        }
    }
}