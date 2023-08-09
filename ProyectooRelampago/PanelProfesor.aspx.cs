using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class PanelProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Modelos.Usuario usuario = (Modelos.Usuario)Session["Usuario"];
            lblNombreUsuario.Text= $"Bienvenido al sistema {usuario.Nombre}.";

        }
    }
}