using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaPresentacion.CRUDs;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ProfesoresCN
    {
        public DataTable MostrarProfesores()
        {
            ProfesoresCD profesores = new ProfesoresCD();
            return profesores.MostrarProfesores();
        }

        public void InsertarProfesor(string nombre, string apellido, string titulo, string usuario, string contrasena, string confirmarContra, string sexo, string rol)
        {
            if (contrasena.Equals(confirmarContra))
            {
                ProfesoresCD profesor = new ProfesoresCD();
                int filasAfectadasExpectadas = 1;
                int filasAfectadas = profesor.InsertarProfesor(nombre, apellido, titulo, usuario, contrasena, sexo, rol);

                if (filasAfectadas == filasAfectadasExpectadas)
                {
                    ProfesoresCD.profesorIngresado = true;
                }

                return;
            }
            
            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
