using System;
using System.Windows.Forms;
using Layers.Framework.ADO.Net;

namespace Splash_Screen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            clsLnEntidades entidad = new clsLnEntidades();
            clsBeEntidades entidadesModel = new clsBeEntidades();

            entidadesModel.UserNameEntidad = textBoxUserLogin.Text.ToString().Trim();
            entidadesModel.PasswordEntidad = textBoxPasswordLogin.Text.ToString().Trim();

            if (entidad.Obtener(ref entidadesModel))
            {
                this.Hide();
                new MenuPrincipal().Show();

                return;
            }

            MessageBox.Show("Revise sus credenciales e inténtelo nuevamente.", "Error!");
        }

        private void Registrarse(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }
    }
}
