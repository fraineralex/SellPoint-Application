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

using CapaDatos;

namespace CapaPresentacion
{
    public partial class FormProfesores : Form
    {
        public FormProfesores()
        {
            InitializeComponent();
            MostrarProfesores();
            Privilegios.GestionarPrivilegios(buttonNuevoProfesores, buttonEditarProfesores, buttonBorrarProfesores);
        }

        private void MostrarProfesores()
        {
            ProfesoresCD profesores = new ProfesoresCD();
            dataGridViewProfesores.DataSource = profesores.MostrarProfesores();
        }

        private void IrARegistrarProfesor(object sender, EventArgs e)
        {
            new FormProfesoresRegistrar().ShowDialog();
            MostrarProfesores();
        }
    }
}
