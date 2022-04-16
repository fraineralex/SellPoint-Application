using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace Layers.Framework.ADO.Net.Data
{
    public static class ClassData
    {

        public static string stringConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        /*public static SqlConnection StringConnectionSQLServer()
        {
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString.ToString();
            DBConnection.Open();

            return DBConnection;
        }*/

    }
}