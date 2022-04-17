using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            if (FormLogin.previousForm != "Login")
            {
                this.ButtonAtras.Visible = true;
            }
            else
            {
                this.ButtonAtras.Visible = false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();
            this.Dispose();
            this.Close();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            if(FormLogin.previousForm == "Login")
            {
           
                FormLogin Login = new FormLogin();
                Login.Show();
                this.Dispose();
                this.Close();

            }
            else
            {
                FormMenuPrincipal Menu = new FormMenuPrincipal();
                Menu.Show();
                this.Dispose();
                this.Close();
            }

        }

        
    }
}
