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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "\r\nUser")
            {
                textBoxUser.Text = "\n";
                textBoxUser.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "\r\nPassword")
            {
                textBoxPassword.Text = "\n";
                textBoxPassword.ForeColor = Color.Black;
            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "\nadmin" | textBoxPassword.Text == "\nadmin")
            {
                FormMenuPrincipal menu = new FormMenuPrincipal();
                menu.Show();
                this.Dispose();
                this.Close();
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            previousForm = "Login";
            FormRegister Register = new FormRegister();
            Register.Show();
            this.Dispose();
            this.Close();

            

        }


        public static string previousForm;


    }
}
