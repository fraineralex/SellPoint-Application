using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        private readonly string defaultTextTextBoxUsuario = "Usuario";
        private readonly string defaultTextTextBoxContrasena = "Contraseña";
        private readonly Font fontInputOn = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        private readonly Font fontDefault = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Acceder(object sender, EventArgs e)
        {
            if (InputInvalido()) return;
            LogearUsuario();
        }

        private void LogearUsuario()
        {
            LoginCN usuario = new LoginCN();
            bool validarLogin = usuario.LoginUsuario(textBoxUsuarioLogin.Text, textBoxContrasenaLogin.Text);

            if (validarLogin)
            {
                this.Hide();
                new FormMenuPrincipal().Show();
                return;
            }

            MessageBox.Show("Usuario no encontrado, revise sus credenciales.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool InputInvalido()
        {
            if (textBoxUsuarioLogin.Text.Equals(defaultTextTextBoxUsuario))
            {
                MessageBox.Show("Asegúrese de ingresar su usuario antes de iniciar sesión.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (textBoxContrasenaLogin.Text.Equals(defaultTextTextBoxContrasena))
            {
                MessageBox.Show("Asegúrese de ingresar su contraseña antes de iniciar sesión.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        private void TextBoxUsuarioLoginMouseIn(object sender, EventArgs e)
        {
            if (textBoxUsuarioLogin.Text.Equals(defaultTextTextBoxUsuario))
            {
                textBoxUsuarioLogin.Font = fontInputOn;
                textBoxUsuarioLogin.Text = string.Empty;
            }
        }

        private void TextBoxUsuarioLoginMouseOut(object sender, EventArgs e)
        {
            if (textBoxUsuarioLogin.Text.Equals(string.Empty))
            {
                textBoxUsuarioLogin.Font = fontDefault;
                textBoxUsuarioLogin.Text = defaultTextTextBoxUsuario;
            }
        }

        private void TextBoxContrasenaLoginMouseIn(object sender, EventArgs e)
        {
            if (textBoxContrasenaLogin.Text.Equals(defaultTextTextBoxContrasena))
            {
                textBoxContrasenaLogin.Text = string.Empty;
                textBoxContrasenaLogin.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxContrasenaLoginMouseOut(object sender, EventArgs e)
        {
            if (textBoxContrasenaLogin.Text.Equals(string.Empty))
            {
                textBoxContrasenaLogin.Font = fontDefault;
                textBoxContrasenaLogin.Text = defaultTextTextBoxContrasena;
                textBoxContrasenaLogin.UseSystemPasswordChar = false;
            }
        }

        private void MinimizarVentana(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarAplicacion(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
