using System.Data;
using System.Data.SqlClient;
using CapaSoporte.Cache;

namespace CapaDatos
{
    public class LoginCD : Conexion
    {
        public bool LoginUsuario(string usuario, string contrasena)
        {
            string consultaLogin = "SELECT * FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

            SqlConnection conexion = AbrirBD();

            SqlCommand comando = new SqlCommand(consultaLogin, conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CacheUsuario.Usuario = lector.GetString(0);
                    CacheUsuario.Rol = lector.GetString(2);
                }

                conexion.Close();
                return true;
            }

            conexion.Close();
            return false;
        }
    }
}
