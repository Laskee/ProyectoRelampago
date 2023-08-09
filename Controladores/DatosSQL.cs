using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Modelos;

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
        public List<Modelos.Estudiante> TraerEstudiantessingrupo(int idGrupo)
        {
            List<Modelos.Estudiante> estudiantes=new List<Modelos.Estudiante>();

            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("spVerEstudiantes", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idGrupo", idGrupo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Modelos.Estudiante estudiante = new Modelos.Estudiante();  
                        estudiante.IdUsuario = Convert.ToInt32(reader["idUsuario"].ToString());
                        estudiante.Nombre = reader["Nombre"].ToString();
                        estudiante.CorreoE = reader["CorreoE"].ToString();
                        estudiantes.Add(estudiante);
                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }


            return estudiantes;
        }
        public List<Modelos.Estudiante> TraerEstudiantesdelgrupo(int idGrupo)
        {
            List<Modelos.Estudiante> estudiantes = new List<Modelos.Estudiante>();

            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("spVerEstudiantesGrupo", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idGrupo", idGrupo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Modelos.Estudiante estudiante = new Modelos.Estudiante();
                        estudiante.IdUsuario = Convert.ToInt32(reader["idEstudianteGrupo"].ToString());
                        estudiante.Nombre = reader["Nombre"].ToString();
                        estudiantes.Add(estudiante);
                    }
                }
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }


            return estudiantes;
        }
        public void InsertarEstudianteGrupo(int idGrupo, int idestudiante) {
            try
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand("spInsertarEstudiantesGrupo", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idGrupo", idGrupo);
                command.Parameters.AddWithValue("@idUsuario", idestudiante);
                command.ExecuteNonQuery();
                sqlConn.Close();

            }
            catch (Exception e)
            {

            }
        }


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
        #region Registrar
        public void InsertarUsuarioEnBD(string correo, string contrasena, string nombre, bool esProfesor)
        {
            try
            {
                using (SqlConnection sqlConn2 = new SqlConnection(sqlConn.ConnectionString))
                {
                    sqlConn2.Open();
                    SqlCommand command = new SqlCommand("spInsertarUsuario", sqlConn2);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CorreoE", correo);
                    command.Parameters.AddWithValue("@Contrasenia", contrasena);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Profesor", esProfesor);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                // Manejar el error si es necesario
            }

            #endregion

        }
        public List<Modelos.Nota1> VerDetalleNotas(int estudiante)
        {
            List<Modelos.Nota1> lstDetalleNotas = new List<Modelos.Nota1>();

            try
            {
                using (SqlConnection sqlConn2 = new SqlConnection(sqlConn.ConnectionString))
                {
                    sqlConn2.Open();
                    SqlCommand command = new SqlCommand("spVerDetalleNotas", sqlConn2);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idEstudianteGrupo", estudiante);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Modelos.Nota1 detalleNota = new Modelos.Nota1();
                            detalleNota.Nombre = (string)reader["Nombre"];
                            detalleNota.Porcentaje = (int)reader["Porcentaje"];
                            detalleNota.Nota = (int)reader["Nota"];
                            // Agrega más campos si es necesario

                            lstDetalleNotas.Add(detalleNota);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Manejar el error si es necesario
            }

            return lstDetalleNotas;
        }




        public List<Modelos.Nota2> VerDetalleNotas2(int estudiante)
        {
            List<Modelos.Nota2> lstDetalleNotas = new List<Modelos.Nota2>();

            try
            {
                using (SqlConnection sqlConn2 = new SqlConnection(sqlConn.ConnectionString))
                {
                    sqlConn2.Open();
                    SqlCommand command = new SqlCommand("spVerNotaFinal", sqlConn2);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idUsuario", estudiante);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Modelos.Nota2 detalleNota = new Modelos.Nota2();
                            detalleNota.Nombre = (string)reader["Nombre"];
                            detalleNota.NombreCurso = (string)reader["NombreCurso"];
                            detalleNota.NotaFinal = ((int)reader["NotaFinal"]);
                            // Agrega más campos si es necesario

                            lstDetalleNotas.Add(detalleNota);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Manejar el error si es necesario
            }

            return lstDetalleNotas;
        }

        public void InsertarNota(int idEst, int Rubrica, int Nota)
        {
            try
            {
                using (SqlConnection sqlConn2 = new SqlConnection(sqlConn.ConnectionString))
                {
                    sqlConn2.Open();
                    SqlCommand command = new SqlCommand("spInsertarNotas", sqlConn2);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idEstudianteGrupo", idEst);
                    command.Parameters.AddWithValue("@idRubrica", Rubrica);
                    command.Parameters.AddWithValue("@Nota", Nota);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                // Manejar el error si es necesario
            }
        }











    }
}

