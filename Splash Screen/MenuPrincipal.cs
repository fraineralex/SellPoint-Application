using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void IrAlCrudEntidades(object sender, EventArgs e)
        {
            FormEntidadesCRUD crud = new FormEntidadesCRUD();
            crud.MdiParent = this;
            crud.Show();
        }

        private void IrAlCrudTiposEntidades(object sender, EventArgs e)
        {
            FormTiposEntidadesCRUD crud = new FormTiposEntidadesCRUD();
            crud.MdiParent = this;
            crud.Show();
        }

        private void IrAlCrudGruposEntidades(object sender, EventArgs e)
        {
            FormGruposEntidadesCRUD crud = new FormGruposEntidadesCRUD();
            crud.MdiParent = this;
            crud.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = FormLogin.entidad.UserNameEntidad.ToString();
            statusBar1.Panels[1].Text = DateTime.Now.ToString();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColaboradores crud = new FormColaboradores();
            crud.MdiParent = this;
            crud.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
