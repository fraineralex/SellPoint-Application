using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly string connectionString = $"Server=LAPTOP-IH8S1QVM\\SQLEXPRESS; Database=EaglesAcademy; Integrated Security=true";

        public static SqlConnection AbrirBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = connectionString;
            conexion.Open();

            return conexion;
        }
    }
}
