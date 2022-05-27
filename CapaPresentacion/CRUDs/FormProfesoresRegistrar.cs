using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion.CRUDs
{
    public partial class FormProfesoresRegistrar : Form
    {
        public FormProfesoresRegistrar()
        {
            InitializeComponent();
        }

        private void InsertarProfesor(object sender, EventArgs e)
        {
            string nombre = textBoxNombreProfesor.Text;
            string apellido = textBoxApellidoProfesor.Text;
            string titulo = textBoxTituloProfesor.Text;
            string usuario = textBoxUsuarioProfesor.Text;
            string contrasena = textBoxContrasenaProfesor.Text;
            string confirmarContra = textBoxConfirmarContraProfesor.Text;
            string sexo = comboBoxSexoProfesor.Text;
            string rol = comboBoxRolProfesor.Text;

            ProfesoresCN profesor = new ProfesoresCN();
            profesor.InsertarProfesor(nombre, apellido, titulo, usuario, contrasena, confirmarContra, sexo, rol);

            if (ProfesoresCD.profesorIngresado)
            {
                MessageBox.Show("Profesor guardado en la base de datos correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
