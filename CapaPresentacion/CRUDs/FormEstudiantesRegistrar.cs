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
    public partial class FormEstudiantesRegistrar : Form
    {
        public FormEstudiantesRegistrar()
        {
            InitializeComponent();
            GestionarDateTimePicker();
        }

        private void InsertarEstudiante(object sender, EventArgs e)
        {
            string nombre = textBoxNombreEstudiante.Text;
            string apellido = textBoxApellidoEstudiante.Text;
            string cedula = textBoxCedulaEstudiante.Text;
            string sexo = comboBoxSexoEstudiante.Text;
            string telefono = textBoxTelefonoEstudiante.Text;
            string carrera = comboBoxCarreraEstudiante.Text;
            string correo = textBoxCorreoEstudiante.Text;
            string fechaNacimiento = dateTimePickerFechaNacimientoEstudiante.Text;
            string usuario = textBoxUsuarioEstudiante.Text;
            string contrasena = textBoxContrasenaEstudiante.Text;
            string confirmarContra = textBoxConfirmarContraEstudiante.Text;
            string rol = comboBoxRolEstudiante.Text;

            EstudiantesCN estudiante = new EstudiantesCN();
            estudiante.InsertarEstudiante(nombre, apellido, cedula, sexo, telefono, carrera, correo, fechaNacimiento, usuario,
                contrasena, confirmarContra, rol);

            if (EstudiantesCD.estudianteIngresado)
            {
                MessageBox.Show("Estudiante guardado en la base de datos correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void GestionarDateTimePicker()
        {
            dateTimePickerFechaNacimientoEstudiante.MinDate = Convert.ToDateTime("01-01-1920");
            dateTimePickerFechaNacimientoEstudiante.MaxDate = DateTime.Today;
        }
    }
}
