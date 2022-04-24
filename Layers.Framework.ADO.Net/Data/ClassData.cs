using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Layers.Framework.ADO.Net.Data
{
    public static class ClassData
    {
        public static SqlConnection StringConnectionSQLServer()
        {
            SqlConnection DBConnection = new SqlConnection();
            DBConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString.ToString();
            DBConnection.Open();

            return DBConnection;
        }

        public static SqlCommand ExecuteCommandSQL(string comando, CommandType tipoComando)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = StringConnectionSQLServer();
            sqlCommand.CommandText = comando;
            sqlCommand.CommandType = tipoComando;

            return sqlCommand;
        }

        public static SqlDataReader ReadCommandSQL(SqlCommand sqlCommand)
        {
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();

            return sqlDataReader;
        }
    }
}