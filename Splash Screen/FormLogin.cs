using System;
using System.Windows.Forms;
using Layers.Framework.ADO.Net;

namespace Splash_Screen
{

    public partial class FormLogin : Form
    {
        public static bool registrando = false;
        public static clsBeEntidades entidad = new clsBeEntidades();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            clsLnEntidades logicaEntidad = new clsLnEntidades();

            entidad.UserNameEntidad = textBoxUserLogin.Text.ToString();
            entidad.PasswordEntidad = textBoxPasswordLogin.Text.ToString();

            if (logicaEntidad.Obtener(ref entidad))
            {
                this.Hide();
                new MenuPrincipal().Show();

                return;
            }

            MessageBox.Show("Revise sus credenciales e inténtelo nuevamente.", "Error!");
        }

        private void Registrarse(object sender, EventArgs e)
        {
            new FormRegistrarEntidad().Show();
            registrando = true;
            this.Hide();
        }
    }
}
