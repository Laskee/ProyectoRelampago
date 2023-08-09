using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Estudiante
    {

        private int idUsuario;
        private string nombre;
        private string correoE;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoE { get => correoE; set => correoE = value; }
    }
}
