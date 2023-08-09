using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cursos
    {
        private int idCurso;
        private string nombre;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
