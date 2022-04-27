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
    public partial class FormEntidadesCRUD : Form
    {
        private clsBeEntidades entidad = new clsBeEntidades();
        private readonly clsLnEntidades logicaEntidad = new clsLnEntidades();

        public FormEntidadesCRUD()
        {
            InitializeComponent();
            MostrarEntidades();
        }

        private void MostrarEntidades()
        {
            var datos = new clsLnEntidades();
            tablaEntidadesCrud.ReadOnly = true;
            tablaEntidadesCrud.ClearSelection();
            tablaEntidadesCrud.DataSource = datos.Listar();
        }

        private void CrearEntidad(object sender, EventArgs e)
        {
            var formCreaEntidad = new FormRegistrarEntidad();
            formCreaEntidad.actualizando = false;
            formCreaEntidad.buttonHomeRegistrarEntidad.Visible = false;
            formCreaEntidad.ShowDialog();
            
            MostrarEntidades();
        }

        private void EditarEntidad(object sender, EventArgs e)
        {
            var formEditarEntidad = new FormRegistrarEntidad();

            if (tablaEntidadesCrud.SelectedColumns.Count > -1)
            {
                formEditarEntidad.actualizando = true;
                formEditarEntidad.buttonHomeRegistrarEntidad.Visible = false;
                formEditarEntidad.labelTituloRegistrarEntidad.Text = "Editar Entidad";
                formEditarEntidad.textBoxIdEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[0].Value.ToString();
                formEditarEntidad.textBoxDescripcionRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[1].Value.ToString();
                formEditarEntidad.textBoxDireccionResgistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[2].Value.ToString();
                formEditarEntidad.textBoxLocalidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[3].Value.ToString();
                formEditarEntidad.comboBoxTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[4].Value.ToString();
                formEditarEntidad.comboBoxTipoDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[5].Value.ToString();
                formEditarEntidad.textBoxNumeroDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[6].Value.ToString();
                formEditarEntidad.textBoxTelefonoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[7].Value.ToString();
                formEditarEntidad.textBoxURLPáginaWebRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[8].Value.ToString();
                formEditarEntidad.textBoxURLFacebookRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[9].Value.ToString();
                formEditarEntidad.textBoxURLInstagramRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[10].Value.ToString();
                formEditarEntidad.textBoxURLTwitterRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[11].Value.ToString();
                formEditarEntidad.textBoxURLTikTokRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[12].Value.ToString();
                formEditarEntidad.textBoxIdGrupoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[13].Value.ToString();
                formEditarEntidad.textBoxIdTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[14].Value.ToString();
                formEditarEntidad.textBoxLimiteCreditoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[15].Value.ToString();
                formEditarEntidad.textBoxUsernameRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[16].Value.ToString();
                formEditarEntidad.textBoxPasswordRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[17].Value.ToString();
                formEditarEntidad.comboBoxRolUserRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[18].Value.ToString();
                formEditarEntidad.textBoxComentarioRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[19].Value.ToString();
                formEditarEntidad.comboBoxStatusRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[19].Value.ToString();
                formEditarEntidad.comboBoxNoEliminableRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[21].Value.ToString();
                formEditarEntidad.ShowDialog();

                MostrarEntidades();

                return;
            }

            MessageBox.Show("Seleccione el usuario que desea editar.", "Atención!");
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (tablaEntidadesCrud.SelectedColumns.Count < 0)
            {
                MessageBox.Show("Seleccione el usuario que desea eliminar.", "Atención!");
                return;
            }

            if (MessageBox.Show("Está seguro que quiere eliminar este usuario??", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                entidad.IdEntidad = Convert.ToInt32(tablaEntidadesCrud.CurrentRow.Cells[0].Value.ToString());
                logicaEntidad.Eliminar(ref entidad);
                MessageBox.Show("Usuario eliminado exitosamente.", "Eliminado!");
                MostrarEntidades();
            }
        }

        private void ObtenerEntidad(string idEntidad)
        {
            entidad.IdEntidad = Convert.ToInt32(idEntidad);
            tablaEntidadesCrud.DataSource = logicaEntidad.BuscarEntidad(ref entidad);
        }

        private void Buscar(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxBuscarEntidadesCrud.Text) || string.IsNullOrWhiteSpace(textBoxBuscarEntidadesCrud.Text)))
            {
                MostrarEntidades();
                return;
            }
            
            ObtenerEntidad(textBoxBuscarEntidadesCrud.Text);
        }
    }
}
