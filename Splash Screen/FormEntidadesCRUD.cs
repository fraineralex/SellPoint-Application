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
            tablaEntidadesCrud.DataSource = datos.Listar();
            tablaEntidadesCrud.ClearSelection();
        }

        private void CrearEntidad(object sender, EventArgs e)
        {
            var formCrear = new FormRegistrarEntidad();
            formCrear.textBoxIdEntidadRegistrarEntidad.Text = "Automatizado";
            formCrear.actualizando = false;
            formCrear.ShowDialog();
            MostrarEntidades();
        }

        private void EditarEntidad(object sender, EventArgs e)
        {
            var formEditar = new FormRegistrarEntidad();

            if (tablaEntidadesCrud.SelectedColumns.Count > -1)
            {
                formEditar.actualizando = true;
                formEditar.textBoxIdTipoEntidadRegistrarEntidad.ReadOnly = true;
                formEditar.textBoxIdGrupoEntidadRegistrarEntidad.ReadOnly = true;
                formEditar.labelTituloRegistrarEntidad.Text = "Editar Entidad";
                formEditar.textBoxIdEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[0].Value.ToString();
                formEditar.textBoxDescripcionRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[1].Value.ToString();
                formEditar.textBoxDireccionResgistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[2].Value.ToString();
                formEditar.textBoxLocalidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[3].Value.ToString();
                formEditar.comboBoxTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[4].Value.ToString();
                formEditar.comboBoxTipoDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[5].Value.ToString();
                formEditar.textBoxNumeroDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[6].Value.ToString();
                formEditar.textBoxTelefonoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[7].Value.ToString();
                formEditar.textBoxURLPáginaWebRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[8].Value.ToString();
                formEditar.textBoxURLFacebookRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[9].Value.ToString();
                formEditar.textBoxURLInstagramRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[10].Value.ToString();
                formEditar.textBoxURLTwitterRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[11].Value.ToString();
                formEditar.textBoxURLTikTokRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[12].Value.ToString();
                formEditar.textBoxIdGrupoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[13].Value.ToString();
                formEditar.textBoxIdTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[14].Value.ToString();
                formEditar.textBoxLimiteCreditoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[15].Value.ToString();
                formEditar.textBoxUsernameRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[16].Value.ToString();
                formEditar.textBoxPasswordRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[17].Value.ToString();
                formEditar.comboBoxRolUserRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[18].Value.ToString();
                formEditar.textBoxComentarioRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[19].Value.ToString();
                formEditar.comboBoxStatusRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[19].Value.ToString();
                formEditar.comboBoxNoEliminableRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[21].Value.ToString();
                formEditar.ShowDialog();

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
