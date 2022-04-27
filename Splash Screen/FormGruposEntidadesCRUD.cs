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
    public partial class FormGruposEntidadesCRUD : Form
    {
        public FormGruposEntidadesCRUD()
        {
            InitializeComponent();
            MostrarGrupoEntidades();
        }

        private void MostrarGrupoEntidades()
        {
            var datos = new clsLnGruposEntidades();
            tablaGruposEntidadesCRUD.ReadOnly = true;
            tablaGruposEntidadesCRUD.ClearSelection();
            tablaGruposEntidadesCRUD.DataSource = datos.Listar();
        }

        private void CrearGrupoEntidad(object sender, EventArgs e)
        {
            var formCrearGrupoEntidad = new FormRegistrarGrupoEntidad();
            formCrearGrupoEntidad.actualizando = false;
            formCrearGrupoEntidad.ShowDialog();

            MostrarGrupoEntidades();
        }

        private void EditarGrupoEntidad(object sender, EventArgs e)
        {
            var formEditarGrupoEntidad = new FormRegistrarGrupoEntidad();

            if (tablaGruposEntidadesCRUD.SelectedColumns.Count > -1)
            {
                formEditarGrupoEntidad.actualizando = true;
                formEditarGrupoEntidad.labelTituloRegistrarGrupoEntidad.Text = "Editar Tipo de Entidad";
                formEditarGrupoEntidad.textBoxIdGrupoEntidadRegistrarGrupoEntidad.Text = tablaGruposEntidadesCRUD.CurrentRow.Cells[0].Value.ToString();
                formEditarGrupoEntidad.textBoxDescripcionRegistrarGrupoEntidad.Text = tablaGruposEntidadesCRUD.CurrentRow.Cells[1].Value.ToString();
                formEditarGrupoEntidad.textBoxComentarioRegistrarGrupoEntidad.Text = tablaGruposEntidadesCRUD.CurrentRow.Cells[2].Value.ToString();
                formEditarGrupoEntidad.comboBoxStatusRegistrarGrupoEntidad.Text = tablaGruposEntidadesCRUD.CurrentRow.Cells[3].Value.ToString();
                formEditarGrupoEntidad.comboBoxNoEliminableRegistrarGrupoEntidad.Text = tablaGruposEntidadesCRUD.CurrentRow.Cells[4].Value.ToString();
                formEditarGrupoEntidad.ShowDialog();

                MostrarGrupoEntidades();

                return;
            }

            MessageBox.Show("Seleccione el usuario que desea editar.", "Atención!");
        }
    }
}
