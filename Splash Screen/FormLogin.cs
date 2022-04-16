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
using System.Configuration;
using Layers.Framework.ADO.Net.Data;

namespace Splash_Screen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            string F = textBoxUser.Text;
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "\r\nUser")
            {
                textBoxUser.Text = ($"{Environment.NewLine}");
                textBoxUser.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "\r\nPassword")
            {
                //textBoxPassword.Text = "\n";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.Text = ($"{Environment.NewLine}");

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

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ClassData.stringConnection.ToString();
            sqlConnection.Open();


        

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"SELECT descripcion FROM Entidades WHERE userNameEntidad = '{textBoxUser.Text.ToString().Trim()}' AND passwordEntidad = '{textBoxPassword.Text.ToString().Trim()}';";

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();

            if(reader.HasRows == false)
            {
                MessageBox.Show("No se pudo iniciar sesión, revise sus credenciales", "Error");
            }
            else
            {
                
                FormMenuPrincipal menu = new FormMenuPrincipal();
                menu.statusBarAdv1.Panels[0].Text = String.Format("{0}", reader[0]);
                menu.Show();
                this.Close();
                this.Dispose();
                
            }

            sqlConnection.Close();
            sqlConnection.Dispose();
            sqlConnection = null;

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
