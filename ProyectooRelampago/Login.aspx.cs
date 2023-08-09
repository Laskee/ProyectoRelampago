using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Conectar_Click(object sender, EventArgs e)
        {

            
            // capturar informacion
            string correo = txtCorreo.Text;
            string contrasenia = txtContrasenia.Text;
            //Validaciones del inicio de sesion
            Controladores.DatosSQL sql = new Controladores.DatosSQL();
            if (sql.ValidarUsuario(correo, contrasenia).Equals("Existe"))
            {
                //traer al usuario para guardarlo en memoria
                Modelos.Usuario user = sql.TraerUsuario(correo);
                if (user != null)
                {
                    Session["Usuario"] = user;
                    if (user.BitProfesor == 1)
                    {
                        Response.Redirect("PanelProfesor.aspx");
                    }
                    else
                    {
                        Response.Redirect("NotasEstudiante.aspx");
                    }

                }

            }


        }
    }
}