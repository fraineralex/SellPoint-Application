using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layers.Framework.ADO.Net;

namespace Splash_Screen
{
    public partial class FormTiposEntidadesCRUD : Form
    {
        private clsBeTiposEntidades tipoEntidad = new clsBeTiposEntidades();
        private readonly clsLnTiposEntidades logicaTipoEntidad = new clsLnTiposEntidades();

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

        private void EliminarTipoEntidad(object sender, EventArgs e)
        {
            if (tablaTiposEntidadesCRUD.SelectedColumns.Count < 0)
            {
                MessageBox.Show("Seleccione el usuario que desea eliminar.", "Atención!");
                return;
            }

            if (MessageBox.Show("¿Está seguro que quiere eliminar este usuario?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tipoEntidad.IdTipoEntidad = Convert.ToInt32(tablaTiposEntidadesCRUD.CurrentRow.Cells[0].Value.ToString());
                logicaTipoEntidad.Eliminar(ref tipoEntidad);
                
                MessageBox.Show("Usuario eliminado correctamente.", "Eliminado!");
                
                MostrarTipoEntidades();
            }
        }
    }
}
