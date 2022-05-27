using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class EstudiantesCN
    {
        public DataTable MostrarEstudiantes()
        {
            EstudiantesCD estudiantes = new EstudiantesCD();
            return estudiantes.MostrarEstudiantes();
        }

        public void InsertarEstudiante(string nombre, string apellido, string cedula, string sexo, string telefono, string carrera, string correo,
            string fechaNacimiento,  string usuario, string contrasena, string confirmarContra, string rol)
        {
            try
            {
                int cedulaLength = 11;
                long cedulaTextBoxLength = Convert.ToInt64(cedula.Trim());

                if (cedulaTextBoxLength.ToString().Length != cedulaLength)
                {
                    MessageBox.Show($"Cédula digitada no tiene la cantidad de caracteres necesarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (contrasena.Equals(confirmarContra))
                {
                    EstudiantesCD estudiante = new EstudiantesCD();
                    int filasAfectadasExpectadas = 1;
                    int filasAfectadas = estudiante.InsertarEstudiante(nombre, apellido, cedula, sexo, telefono, carrera, correo, fechaNacimiento, usuario, contrasena, rol);

                    if (filasAfectadas == filasAfectadasExpectadas)
                    {
                        EstudiantesCD.estudianteIngresado = true;
                    }

                    return;
                }

                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                MessageBox.Show("Cédula digitada no cumple con el formato apropiado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
