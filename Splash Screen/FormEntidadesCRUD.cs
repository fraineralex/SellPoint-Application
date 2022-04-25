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

namespace Splash_Screen
{
    public partial class FormEntidadesCRUD : Form
    {
        clsBeEntidades entidad = new clsBeEntidades();
        clsLnEntidades datosEntidad = new clsLnEntidades();

        public FormEntidadesCRUD()
        {
            InitializeComponent();
            MostrarEntidades();
        }

        private void MostrarEntidades()
        {
            var datos = new clsLnEntidades();
            tablaEntidadesEntidadesCrud.DataSource = datos.Listar();
        }

        private void CrearEntidad(object sender, EventArgs e)
        {
            new FormRegistrarEntidad().Show();
        }
    }
}
