using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class RegistrodeNotas : System.Web.UI.Page
    {
        Controladores.DatosSQL con = new Controladores.DatosSQL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int IdES = Convert.ToInt32(idestudiante.Value);
            int IdRubrica = Convert.ToInt32(idrubrica.Value);
            int Nota = Convert.ToInt32(nota.Value);
            con.InsertarNota(IdES, IdRubrica, Nota);

            Response.Redirect("RegistrodeNotas.aspx");
        }
    }
}