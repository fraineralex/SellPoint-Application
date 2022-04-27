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
        public bool actualizando = false;

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
                try
                {
                    entidadesModel.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidadesModel.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidadesModel.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidadesModel.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidadesModel.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidadesModel.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidadesModel.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidadesModel.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidadesModel.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidadesModel.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidadesModel.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidadesModel.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidadesModel.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarEntidad.Text.ToString());
                    entidadesModel.IdTipoEntidad = Convert.ToInt32(textBoxIdTipoEntidadRegistrarEntidad.Text.ToString());
                    entidadesModel.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidadesModel.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidadesModel.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidadesModel.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidadesModel.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidadesModel.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidadesModel.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text.ToString());
                    entidadesModel.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());

                    entidad.Insertar(ref entidadesModel);

                    MessageBox.Show("Entidad guardada exitosamente.", "Guardada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos.", "Atención");
                }

            }

            if (actualizando)
            {
                try
                {
                    entidadesModel.IdEntidad = Convert.ToInt32(textBoxIdEntidadRegistrarEntidad.Text.ToString());
                    entidadesModel.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidadesModel.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidadesModel.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidadesModel.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidadesModel.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidadesModel.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidadesModel.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidadesModel.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidadesModel.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidadesModel.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidadesModel.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidadesModel.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidadesModel.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarEntidad.Text.ToString());
                    entidadesModel.IdTipoEntidad = Convert.ToInt32(textBoxIdTipoEntidadRegistrarEntidad.Text.ToString());
                    entidadesModel.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidadesModel.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidadesModel.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidadesModel.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidadesModel.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidadesModel.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidadesModel.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text);
                    entidadesModel.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());

                    entidad.Actualizar(ref entidadesModel);

                    MessageBox.Show("Entidad actualizada exitosamente.", "Actualizada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos.", "Atención");
                }
            }
        }
    }
}