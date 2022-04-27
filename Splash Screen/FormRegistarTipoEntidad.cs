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
    public partial class FormRegistarTipoEntidad : Form
    {
        public bool actualizando = false;

        clsBeTiposEntidades tipoEntidad = new clsBeTiposEntidades();
        clsLnTiposEntidades logicaTipoEntidad = new clsLnTiposEntidades();


        public FormRegistarTipoEntidad()
        {
            InitializeComponent();
        }

        private void RegistrarTipoEntidad(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                try
                {
                    tipoEntidad.IdGrupoEntidad = 1;
                    tipoEntidad.Descripcion = textBoxDescripcionRegistrarTipoEntidad.Text.ToString();
                    tipoEntidad.Comentario = textBoxComentarioRegistrarTipoEntidad.Text.ToString();
                    tipoEntidad.Status = comboBoxStatusRegistrarTipoEntidad.Text.ToString();
                    tipoEntidad.NoEliminable = Convert.ToBoolean(comboBoxNoEliminableRegistrarTipoEntidad.Text.ToString());
                    tipoEntidad.FechaRegistro = Convert.ToDateTime(dateTimePickerRegistrarTipoEntidad.Text.ToString());

                    logicaTipoEntidad.Insertar(ref tipoEntidad);

                    MessageBox.Show("Tipo de entidad guardada exitosamente.", "Guardada!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                    
                    /*MessageBox.Show("Asegúrese de llenar todos los campos correctamente.", "Atención");*/
                }
            }



        }
    }
}
