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
    public partial class FormMenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTablaSeleccionada.Text = "Información correspondiente a Grupos Entidades";
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTablaSeleccionada.Text = "Información correspondiente a Tipos Entidades";
        }

        private void entitadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTablaSeleccionada.Text = "Información correspondiente a Entidades";
        }

        private void ButtonAñadir_Click(object sender, EventArgs e)
        {
            FormLogin.previousForm = "MenuPrincipal";
            FormRegister Register = new FormRegister();
            Register.Show();
            this.Dispose();
            this.Close();
        }
    }
}
