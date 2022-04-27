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
    public partial class FormTiposEntidadesCRUD : Form
    {
        public FormTiposEntidadesCRUD()
        {
            InitializeComponent();
            MostrarTipoEntidades();
        }

        private void MostrarTipoEntidades()
        {
            var datos = new clsLnTiposEntidades();
            tablaTiposEntidadesCRUD.ReadOnly = true;
            tablaTiposEntidadesCRUD.ClearSelection();
            tablaTiposEntidadesCRUD.DataSource = datos.Listar();
        }

        private void CrearTipoEntidad(object sender, EventArgs e)
        {
            var formCrearTipoEntidad = new FormRegistarTipoEntidad();
            formCrearTipoEntidad.actualizando = false;
            formCrearTipoEntidad.ShowDialog();

            MostrarTipoEntidades();
        }
    }
}
