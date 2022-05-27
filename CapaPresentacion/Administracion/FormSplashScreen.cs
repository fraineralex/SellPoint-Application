using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormSplashScreen : Form
    {
        private int valorLabelContador = 5;
        private readonly int labelContadorIncremento = 5;
        private readonly int metabarraCarga = 550;
        private readonly int barraCargaIncremento = 25;

        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void CargarAplicacion(object sender, EventArgs e)
        {
            labelContador.Text = $"{valorLabelContador}%";
            valorLabelContador += labelContadorIncremento;

            panelBarraCarga.Width += barraCargaIncremento;

            if (panelBarraCarga.Width == metabarraCarga)
            {
                temporizador.Stop();

                this.Hide();
                new FormLogin().Show();
            }
        }
    }
}
