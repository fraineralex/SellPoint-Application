using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.CRUDs;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormEstudiantes : Form
    {
        public FormEstudiantes()
        {
            InitializeComponent();
            MostrarEstudiantes();
            Privilegios.GestionarPrivilegios(buttonNuevoEstudiantes, buttonEditarEstudiantes, buttonBorrarEstudiantes);
        }

        private void MostrarEstudiantes()
        {
            EstudiantesCN estudiantes = new EstudiantesCN();
            dataGridViewEstudiantes.DataSource = estudiantes.MostrarEstudiantes();
        }

        private void IrARegistrarEstudiante(object sender, EventArgs e)
        {
            new FormEstudiantesRegistrar().ShowDialog();
            MostrarEstudiantes();
        }
    }
}
