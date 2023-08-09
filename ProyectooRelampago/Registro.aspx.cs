using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class Registro : System.Web.UI.Page
    {
        Controladores.DatosSQL con = new Controladores.DatosSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
         {
            try
            { 
            string Nombre = nombre.Value;
            string Correo = correo.Value;
            string Contraseña = contrasena.Value;
            bool prof = es_profesor.Checked;
            con.InsertarUsuarioEnBD(Correo, Contraseña, Nombre, prof);
            }
            catch (Exception e)
            {
                // Manejar el error si es necesario
            }
        }
    }
}