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
    public class ProfesoresCD : Conexion
    {
        private SqlConnection conexion;
        public static bool profesorIngresado = false;

        public DataTable MostrarProfesores()
        {
            string procedimientoMostrarProfesores = "MostrarProfesores";

            conexion = AbrirBD();

            SqlCommand comando = new SqlCommand(procedimientoMostrarProfesores, conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader lector = comando.ExecuteReader();

            DataTable tablaProfesores = new DataTable();
            tablaProfesores.Load(lector);

            conexion.Close();

            return tablaProfesores;
        }

        public int InsertarProfesor(string nombre, string apellido, string titulo, string usuario, string contrasena, string sexo, string rol)
        {
            try
            {
                string procedimientoInsertarProfesor = "InsertarProfesor";

                conexion = AbrirBD();

                SqlCommand comando = new SqlCommand(procedimientoInsertarProfesor, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@rol", rol);
                
                return comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                int excepcionUniqueConstraint = 2627;

                if (ex.Number == excepcionUniqueConstraint)
                {
                    MessageBox.Show("Nombre de usuario ya registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
                
                MessageBox.Show("Error al tratar de ingresar el profesor a la base de datos. \nInténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
