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
    public partial class FormRegistrarEntidad : Form
    {
        private bool actualizando = false;

        clsLnEntidades entidad = new clsLnEntidades();
        clsBeEntidades entidadesModel = new clsBeEntidades();

        public FormRegistrarEntidad()
        {
            InitializeComponent();
        }

        public void CargarComboBoxesSelectIndex()
        {
            comboBoxTipoEntidadRegistrarEntidad.SelectedIndex = 0;
            comboBoxTipoDocumentoRegistrarEntidad.SelectedIndex = 0;
            comboBoxRolUserRegistrarEntidad.SelectedIndex = 0;
            comboBoxStatusRegistrarEntidad.SelectedIndex = 0;
            comboBoxNoEliminableRegistrarEntidad.SelectedIndex = 1;
        }

        private void RegistrarEntidad(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                entidadesModel.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString().Trim();
                entidadesModel.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString().Trim());
                entidadesModel.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarEntidad.Text.ToString().Trim());
                entidadesModel.IdTipoEntidad = Convert.ToInt32(textBoxIdTipoEntidadRegistrarEntidad.Text.ToString().Trim());
                entidadesModel.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString().Trim());
                entidadesModel.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.Status = comboBoxStatusRegistrarEntidad.Text.ToString().Trim();
                entidadesModel.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text.ToString().Trim());
                entidadesModel.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString().Trim());

                entidad.Insertar(ref entidadesModel);

                MessageBox.Show("Entidad guardada exitosamente.", "Guardada!");
                this.Close();

                return;
            }

        }
    }
}
