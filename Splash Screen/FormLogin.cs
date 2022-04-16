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
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "\r\nUser")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "\r\nPassword")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = false;
                
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
            sqlCommand.CommandText = "SELECT userEntidad, passwordEntidad FROM Entidades" +
                "WHERE userNameEntidad = '" + textBoxUser.Text + "' AND passwordEntidad = '"
                + textBoxPassword.Text + "';";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();

            if(sqlDataReader.HasRows == false)
            {
                MessageBox.Show("No se pudo iniciar sesión, revise sus credenciales", "Error");
            }
            else
            {
                FormMenuPrincipal menu = new FormMenuPrincipal();
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
