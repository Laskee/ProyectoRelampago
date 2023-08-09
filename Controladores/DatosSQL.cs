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

        public List<Modelos.Grupos> TraerGrupos(int idCurso)
        {
            List<Modelos.Grupos> lstgrupos = new List<Modelos.Grupos>();
            Modelos.Grupos grupo = new Modelos.Grupos();
            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("spVerGrupos", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCurso", idCurso);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grupo.idGrup = Convert.ToInt32(reader["idGrupo"].ToString());
                        grupo.nombre = reader["Nombre"].ToString();
                        lstgrupos.Add(grupo);
                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }

            return lstgrupos;
        }

        public string ValidarUsuario(string correo, string contrasenia)
        {
            string respuesta = "";

            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("ValidarUsuario", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Contrasenia", contrasenia);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        respuesta = reader["respuesta"].ToString();

                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }


            return respuesta;
        }

        public Modelos.Usuario TraerUsuario(string correo)
        {
            Modelos.Usuario Usuario = null;

            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("TraerUsuario", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@correo", correo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario = new Modelos.Usuario();
                        string nose = reader["Profesor"].ToString();
                        if (nose.Equals("False"))
                        {
                            Usuario.BitProfesor = 0;
                        }
                        else
                        {
                            Usuario.BitProfesor = 1;
                        }
                        Usuario.IdUsuario = Convert.ToInt32(reader["idUsuario"].ToString());
                        Usuario.CorreoE = reader["CorreoE"].ToString();
                        Usuario.Contrasenia1 = reader["Contrasenia"].ToString();
                        Usuario.Nombre = reader["Nombre"].ToString();

                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }

            return Usuario;
        }

        #endregion

        
    }
}
