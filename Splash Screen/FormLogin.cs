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
using Layers.Framework.ADO.Net.Data;

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
            if (!InputValido()) return;
            if (!ComprobarCredenciales()) return;
        }

        private bool InputValido()
        {
            bool inputValido = true;

            List<TextBox> textBoxes = new List<TextBox>()
            {
                textBoxUserLogin,
                textBoxPasswordLogin
            };

            foreach (TextBox textBox in textBoxes)
            {
                string input = textBox.Text.ToString().Trim();

                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                {
                    textBox.BackColor = Color.Red;
                    MessageBox.Show("Asegúrese de proveer la información necesaria para poder ingresar al sistema" +
                        "", "Atención!");
                    textBox.BackColor = Color.White;
                    break;
                }
            }

            return inputValido;
        }

        private bool ComprobarCredenciales()
        {
            bool credencialesValidas = true;
            return credencialesValidas;

        }

        private void Registrarse(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }
    }
}
