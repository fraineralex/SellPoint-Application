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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void IrAlCrudEntidades(object sender, EventArgs e)
        {
            FormEntidadesCRUD crud = new FormEntidadesCRUD();
            crud.MdiParent = this;
            crud.Show();
        }
    }
}
