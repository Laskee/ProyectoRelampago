using Controladores;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class AgregarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        protected void CargarCursos()
        {
            Controladores.DatosSQL sql = new Controladores.DatosSQL();
            List<Cursos> cursos = sql.TraerCursos();
            DropDownList1.Items.Clear();

            foreach (Cursos curs in cursos)
            {
                DropDownList1.Items.Add((new ListItem(curs.Nombre, curs.IdCurso.ToString())));
            }
            DropDownList1.Items.Insert(0, new ListItem("Seleccione un curso", "-1"));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCursoId = DropDownList1.SelectedValue;

            if (selectedCursoId != "-1")
            {
                DatosSQL sql = new DatosSQL();
                List<Grupos> grupos = sql.TraerGrupos(Convert.ToInt32(selectedCursoId));

                foreach (Grupos gr in grupos)
                {
                    DropDownList2.Items.Add((new ListItem(gr.nombre, gr.idGrup.ToString())));
                }
                DropDownList2.Items.Insert(0, new ListItem("Seleccione un curso", "-1"));
            }
        }
    }
}