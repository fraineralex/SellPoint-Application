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
        clsBeEntidades entidad = new clsBeEntidades();
        clsLnEntidades datosEntidad = new clsLnEntidades();

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
        }

        private void CrearEntidad(object sender, EventArgs e)
        {
            new FormRegistrarEntidad().ShowDialog();
            MostrarEntidades();
        }

        private void EditarEntidad(object sender, EventArgs e)
        {
            var formEditar = new FormRegistrarEntidad();

            if (tablaEntidadesCrud.SelectedRows.Count > 0)
            {
                formEditar.labelTituloRegistrarEntidad.Text = "Editar Entidad";
                formEditar.textBoxDescripcionRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[1].Value.ToString().Trim();
                formEditar.textBoxDireccionResgistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[2].Value.ToString().Trim();
                formEditar.textBoxLocalidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[3].Value.ToString().Trim();
                formEditar.comboBoxTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[4].Value.ToString().Trim();
                formEditar.comboBoxTipoDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[5].Value.ToString().Trim();
                formEditar.textBoxNumeroDocumentoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[6].Value.ToString().Trim();
                formEditar.textBoxTelefonoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[7].Value.ToString().Trim();
                formEditar.textBoxURLPáginaWebRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[8].Value.ToString().Trim();
                formEditar.textBoxURLFacebookRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[9].Value.ToString().Trim();
                formEditar.textBoxURLInstagramRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[10].Value.ToString().Trim();
                formEditar.textBoxURLTwitterRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[11].Value.ToString().Trim();
                formEditar.textBoxURLTikTokRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[12].Value.ToString().Trim();
                formEditar.textBoxIdGrupoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[13].Value.ToString().Trim();
                formEditar.textBoxIdTipoEntidadRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[14].Value.ToString().Trim();
                formEditar.textBoxLimiteCreditoRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[15].Value.ToString().Trim();
                formEditar.textBoxUsernameRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[16].Value.ToString().Trim();
                formEditar.textBoxPasswordRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[17].Value.ToString().Trim();
                formEditar.comboBoxRolUserRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[18].Value.ToString().Trim();
                formEditar.textBoxComentarioRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[19].Value.ToString().Trim();
                formEditar.comboBoxStatusRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[20].Value.ToString().Trim();
                formEditar.comboBoxNoEliminableRegistrarEntidad.Text = tablaEntidadesCrud.CurrentRow.Cells[21].Value.ToString().Trim();

                formEditar.ShowDialog();
                MostrarEntidades();
                return;
            }

            MessageBox.Show("Seleccione el usuario que desea editar.", "Atención!");
        }
    }
}
