using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectooRelampago
{

    public partial class ConsultarNota : System.Web.UI.Page
    {
        Controladores.DatosSQL con = new Controladores.DatosSQL();

        protected void Page_Load(object sender, EventArgs e)

        {
            var detalleNotas = con.VerDetalleNotas2(4);
            if (Session["Usuairo"] != null) {
                Modelos.Usuario user = (Modelos.Usuario)Session["Usuario"];
                detalleNotas = con.VerDetalleNotas2(user.IdUsuario);
            }
            


            StringBuilder cardsHtml = new StringBuilder();

            foreach (var detalleNota in detalleNotas)
            {
                string color = "#5FF852"; // Color por defecto (mayor a 70)

                if (detalleNota.NotaFinal < 70)
                {
                    color = "#FF4040";
                }
                else if (detalleNota.NotaFinal == 70)
                {
                    color = "#D5EC47";
                }

                string cardHtml = $@"
            <div class='card' style='border: 1px solid #ccc; padding: 10px; margin: 10px; background-color: {color};'>
                <h3>{detalleNota.Nombre}</h3>
                <p>Nombre del Curso: {detalleNota.NombreCurso}</p>
                <p>Nota Final: {detalleNota.NotaFinal}</p>
               <input   class=""btn btn-light""  type=""submit"" name=""Button1"" value=""Detalles"" id=""Button1"">
                <!-- Agrega más campos y estilos aquí si es necesario -->
            </div>
        ";

                cardsHtml.AppendLine(cardHtml);
            }
            ConsultarNota1.InnerHtml = cardsHtml.ToString();

        }
        protected void btnAction_Click(object sender, EventArgs e)
        {
            var detalleNotas = con.VerDetalleNotas(1);
            if (Session["Usuairo"] != null)
            {
                Modelos.Usuario user = (Modelos.Usuario)Session["Usuario"];
                detalleNotas = con.VerDetalleNotas(user.IdUsuario);
            }


            StringBuilder modelsHtml = new StringBuilder();
            modelsHtml.Append(  $@"
                <div class='modal fade' id='myModal' tabindex='-1' aria-labelledby='exampleModalLabel' aria-hidden='true'>
                <div class='modal-dialog'>
                    <div class='modal-content'>
                        <div class='modal-header'>
                            <h5 class='modal-title' id='exampleModalLabel'>Detalle de Notas</h5>
                            <button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Close'></button>
                        </div>
                    <div class='modal-body'>

            ");
            foreach (var detalleNota in detalleNotas)
            {
                 modelsHtml.Append ( $@"
            
                        
                            <h3>Nombre: {detalleNota.Nombre}</h3>
                            <p>Porcentaje: {detalleNota.Porcentaje}</p>
                            <p>Nota : {detalleNota.Nota}</p>
                            <!-- Agrega más campos aquí si es necesario -->
                      
                    
        ");

            }
            modelsHtml.Append($@"
            
                         </div>
                    </div>
                </div>
            </div>
        ");

            string concatenatedModelsHtml = modelsHtml.ToString();

            // Agrega el contenido del modal a una variable JavaScript
            string script = $@"
        var modalContent = `{concatenatedModelsHtml}`;
        document.getElementById('modalContainer').innerHTML = modalContent;
        var myModal = new bootstrap.Modal(document.getElementById('myModal'));
        myModal.show();
    ";

            ClientScript.RegisterStartupScript(GetType(), "ShowModalScript", script, true);
        }



    }



}
