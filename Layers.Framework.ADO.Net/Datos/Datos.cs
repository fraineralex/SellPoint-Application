using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Layers.Framework.ADO.Net
{
    public static class Datos
    {
        public static string StringConnectionSQLServer()
        {
            string conexionSQLServer = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            return conexionSQLServer;
        }
    }
}
