using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Splash_Screen
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RighRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse       
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            barraProgresiva.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            barraProgresiva.Value += 1;
            barraProgresiva.Text = barraProgresiva.Value.ToString() + "%";

            if (barraProgresiva.Value == 100)
            {
                temporizador.Enabled = false;
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();

            }
        }
    }
}
