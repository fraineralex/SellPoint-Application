using CapaDatos;

namespace CapaNegocio
{
    public class LoginCN
    {
        public bool LoginUsuario(string usuario, string contrasena)
        {
            LoginCD usuarioDAO = new LoginCD();
            return usuarioDAO.LoginUsuario(usuario, contrasena);
        }
    }
}
