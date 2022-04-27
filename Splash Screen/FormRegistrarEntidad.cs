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

        clsBeEntidades entidad = new clsBeEntidades();
        clsLnEntidades logicaEntidad = new clsLnEntidades();

        public FormRegistrarEntidad()
        {
            InitializeComponent();
        }

        private void RegistrarEntidad(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                try
                {
                    entidad.IdTipoEntidad = 1;
                    entidad.IdGrupoEntidad = 1;
                    entidad.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidad.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidad.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidad.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidad.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidad.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidad.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidad.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidad.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidad.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidad.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidad.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidad.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidad.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidad.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidad.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidad.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidad.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text.ToString());
                    entidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());

                    logicaEntidad.Insertar(ref entidad);

                    MessageBox.Show("Entidad guardada correctamente.", "Guardada!");

                    if (FormLogin.registrando)
                    {
                        this.Hide();
                        new FormLogin().Show();
                        return;
                    }

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos correctamente.", "Atención!");
                }
            }

            if (actualizando)
            {
                try
                {
                    entidad.IdTipoEntidad = 1;
                    entidad.IdGrupoEntidad = 1;
                    entidad.IdEntidad = Convert.ToInt32(textBoxIdEntidadRegistrarEntidad.Text.ToString());
                    entidad.Descripcion = textBoxDescripcionRegistrarEntidad.Text.ToString();
                    entidad.Direccion = textBoxDireccionResgistrarEntidad.Text.ToString();
                    entidad.Localidad = textBoxLocalidadRegistrarEntidad.Text.ToString();
                    entidad.TipoEntidad = comboBoxTipoEntidadRegistrarEntidad.Text.ToString();
                    entidad.TipoDocumento = comboBoxTipoDocumentoRegistrarEntidad.Text.ToString();
                    entidad.NumeroDocumento = Convert.ToDouble(textBoxNumeroDocumentoRegistrarEntidad.Text.ToString());
                    entidad.Telefono = textBoxTelefonoRegistrarEntidad.Text.ToString();
                    entidad.URLPaginaWeb = textBoxURLPáginaWebRegistrarEntidad.Text.ToString();
                    entidad.URLFacebook = textBoxURLFacebookRegistrarEntidad.Text.ToString();
                    entidad.URLInstagram = textBoxURLInstagramRegistrarEntidad.Text.ToString();
                    entidad.URLTwitter = textBoxURLTwitterRegistrarEntidad.Text.ToString();
                    entidad.URLTiktok = textBoxURLTikTokRegistrarEntidad.Text.ToString();
                    entidad.LimiteCredito = Convert.ToDouble(textBoxLimiteCreditoRegistrarEntidad.Text.ToString());
                    entidad.UserNameEntidad = textBoxUsernameRegistrarEntidad.Text.ToString();
                    entidad.PasswordEntidad = textBoxPasswordRegistrarEntidad.Text.ToString();
                    entidad.RolUserEntidad = comboBoxRolUserRegistrarEntidad.Text.ToString();
                    entidad.Comentario = textBoxComentarioRegistrarEntidad.Text.ToString();
                    entidad.Status = comboBoxStatusRegistrarEntidad.Text.ToString();
                    entidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarEntidad.Text);
                    entidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarEntidad.Text.ToString());
                    
                    logicaEntidad.Actualizar(ref entidad);

                    MessageBox.Show("Entidad actualizada correctamente.", "Actualizada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos correctamente.", "Atención!");
                }
            }
        }

        private void Home(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}