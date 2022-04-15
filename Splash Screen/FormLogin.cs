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
using System.Data.SqlClient;

namespace Splash_Screen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void Conectarse()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Datos.StringConnectionSQLServer().ToString();
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                label1.Text = "LA CONEXION FUE EXITOSA";
            }
        }

<<<<<<< HEAD
        private void rjButton2_Click(object sender, EventArgs e)
        {
            Conectarse();
=======
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
>>>>>>> a005cc0b9122baa9deb657b44f40b4c95c84084e
        }
    }
}
