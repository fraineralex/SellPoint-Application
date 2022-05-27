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
using CapaSoporte.Cache;


namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void CargarStatusStrip(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = CacheUsuario.Rol;
            toolStripStatusLabel3.Text = CacheUsuario.Usuario;
        }

        private void IrEstudiantesForm(object sender, EventArgs e)
        {
            FormEstudiantes estudiantesForm = new FormEstudiantes();
            estudiantesForm.MdiParent = this;
            estudiantesForm.Show();
        }

        private void IrProfesoreForm(object sender, EventArgs e)
        {
            FormProfesores profesoresForm = new FormProfesores();
            profesoresForm.MdiParent = this;
            profesoresForm.Show();
        }

        private void IrCursosForm(object sender, EventArgs e)
        {
            FormCursos cursosForm = new FormCursos();
            cursosForm.MdiParent = this;
            cursosForm.Show();
        }

        private void IrAcercaDe(object sender, EventArgs e)
        {
            FormAcercaDe acercaDe = new FormAcercaDe();
            acercaDe.MdiParent = this;
            acercaDe.Show();
        }

        private void IrAlLogin(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void CerrarAplicacion(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
