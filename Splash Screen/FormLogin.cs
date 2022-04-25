using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
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
                new FormMenuPrincipal().Show();

                return;
            }

            MessageBox.Show("Revise sus credenciales.", "Error!");
        }

        private void Registrarse(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }
    }
}
