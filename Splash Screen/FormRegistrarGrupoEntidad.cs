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
    public partial class FormRegistrarGrupoEntidad : Form
    {
        public bool actualizando = false;

        clsBeGruposEntidades grupoEntidad = new clsBeGruposEntidades();
        clsLnGruposEntidades logicaGrupoEntidad = new clsLnGruposEntidades();

        public FormRegistrarGrupoEntidad()
        {
            InitializeComponent();
        }

        private void RegistrarGrupoEntidad(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                try
                {
                    grupoEntidad.Descripcion = textBoxDescripcionRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.Comentario = textBoxComentarioRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.Status = comboBoxStatusRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarGrupoEntidad.Text.ToString());
                    grupoEntidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarGrupoEntidad.Text.ToString());

                    logicaGrupoEntidad.Insertar(ref grupoEntidad);

                    MessageBox.Show("Grupo de entidad guardada correctamente.", "Guardada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos correctamente.", "Atención!");
                }
            }

            if (actualizando)
            {
                try
                {
                    grupoEntidad.IdGrupoEntidad = Convert.ToInt32(textBoxIdGrupoEntidadRegistrarGrupoEntidad.Text.ToString());
                    grupoEntidad.Descripcion = textBoxDescripcionRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.Comentario = textBoxComentarioRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.Status = comboBoxStatusRegistrarGrupoEntidad.Text.ToString();
                    grupoEntidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarGrupoEntidad.Text.ToString());
                    grupoEntidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarGrupoEntidad.Text.ToString());

                    logicaGrupoEntidad.Actualizar(ref grupoEntidad);

                    MessageBox.Show("Grupo de entidad actualizada correctamente.", "Actualizada!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Asegúrese de llenar todos los campos correctamente.", "Atención!");
                }
            }
        }
    }
}
