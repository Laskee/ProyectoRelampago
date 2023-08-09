using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string correoE;
        private string Contrasenia;
        private int bitProfesor;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoE { get => correoE; set => correoE = value; }
        public string Contrasenia1 { get => Contrasenia; set => Contrasenia = value; }
        public int BitProfesor { get => bitProfesor; set => bitProfesor = value; }
    }
}
