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

        private void EditarTipoEntidad(object sender, EventArgs e)
        {
            var formEditarTipoEntidad = new FormRegistarTipoEntidad();

            if (tablaTiposEntidadesCRUD.SelectedColumns.Count > -1)
            {
                formEditarTipoEntidad.actualizando = true;
                formEditarTipoEntidad.labelTituloRegistrarTipoEntidad.Text = "Editar Tipo de Entidad";
                formEditarTipoEntidad.textBoxIdTipoEntidadRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[0].Value.ToString();
                formEditarTipoEntidad.textBoxDescripcionRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[1].Value.ToString();
                formEditarTipoEntidad.textBoxIdGrupoEntidadRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[2].Value.ToString();
                formEditarTipoEntidad.textBoxComentarioRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[3].Value.ToString();
                formEditarTipoEntidad.comboBoxStatusRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[4].Value.ToString();
                formEditarTipoEntidad.comboBoxNoEliminableRegistrarTipoEntidad.Text = tablaTiposEntidadesCRUD.CurrentRow.Cells[5].Value.ToString();
                formEditarTipoEntidad.ShowDialog();

                MostrarTipoEntidades();

                return;
            }

            MessageBox.Show("Seleccione el usuario que desea editar.", "Atención!");
        }
    }
}
