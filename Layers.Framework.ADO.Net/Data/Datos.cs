using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Layers.Framework.ADO.Net.Data
{
    public static class Datos
    {
        public static string DBConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString.ToString();

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