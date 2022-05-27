using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class EstudiantesCD : Conexion
    {
        private SqlConnection conexion;
        public static bool estudianteIngresado = false;

        public DataTable MostrarEstudiantes()
        {
            string procedimientoMostrarEstudiantes = "MostrarEstudiantes";

            conexion = AbrirBD();

            SqlCommand comando = new SqlCommand(procedimientoMostrarEstudiantes, conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader lector = comando.ExecuteReader();

            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios.Load(lector);

            conexion.Close();

            return tablaUsuarios;
        }

        public int InsertarEstudiante(string nombre, string apellido, string cedula, string sexo, string telefono, string carrera, string correo,
            string fechaNacimiento,  string usuario, string contrasena, string rol)
        {
            try
            {
                string procedimientoInsertarEstudiante = "InsertarEstudiante";

                conexion = AbrirBD();

                SqlCommand comando = new SqlCommand(procedimientoInsertarEstudiante, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@carrera", carrera);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@fechaNacimiento", Convert.ToDateTime(fechaNacimiento));
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.Parameters.AddWithValue("@rol", rol);

                return comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                int excepcionUniqueConstraint = 2627;

                if (ex.Number == excepcionUniqueConstraint)
                {
                    MessageBox.Show("Usuario, cédula, teléfono y/o correo electrónico ya registrado(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                MessageBox.Show("Error al tratar de ingresar el estudiante a la base de datos.\nInténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
