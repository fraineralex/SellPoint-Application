using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;

namespace CapaPresentacion.CRUDs
{
    static class Privilegios
    {
        internal static void GestionarPrivilegios(Button nuevo, Button editar, Button borrar)
        {
            if (!CacheUsuario.Rol.Equals(CacheRoles.Administrador))
            {
                List<Button> buttons = new List<Button>();
                buttons.Add(nuevo);
                buttons.Add(editar);
                buttons.Add(borrar);

                foreach (Button button in buttons)
                {
                    button.Visible = false;
                }
            }
        }
    }
}
