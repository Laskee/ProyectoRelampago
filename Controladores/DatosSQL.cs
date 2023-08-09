using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Controladores
{
    public class DatosSQL
    {
        public SqlConnection sqlConn;

        public DatosSQL()
        {
            sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);
        }

        #region Sebas
        public List<Modelos.Cursos> TraerCursos()
        {
            List<Modelos.Cursos> lstcursos = new List<Modelos.Cursos>();
            Modelos.Cursos curso = new Modelos.Cursos();
            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("spVerCursos", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        curso = new Modelos.Cursos();
                        curso.IdCurso = Convert.ToInt32(reader["idCurso"].ToString());
                        curso.Nombre = reader["Nombre"].ToString();
                        lstcursos.Add(curso);
                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }

            return lstcursos;
        }



        #endregion





    }
}
