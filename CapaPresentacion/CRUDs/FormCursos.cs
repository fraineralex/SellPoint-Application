using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion.CRUDs
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
            MostrarCursos();
            Privilegios.GestionarPrivilegios(buttonNuevoCursos, buttonEditarCursos, buttonBorrarCursos);
        }

        private void MostrarCursos()
        {
            CursosCD cursos = new CursosCD();
            dataGridViewCursos.DataSource = cursos.MostrarCursos();
        }

        private void IrARegistrarCurso(object sender, EventArgs e)
        {
            new FormCursosRegistrar().ShowDialog();
        }
    }
}
