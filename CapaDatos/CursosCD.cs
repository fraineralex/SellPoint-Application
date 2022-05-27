using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CursosCD : Conexion
    {
        public DataTable MostrarCursos()
        {
            string procedimientoMostrarCursos = "MostrarCursos";

            SqlConnection conexion = AbrirBD();

            SqlCommand comando = new SqlCommand(procedimientoMostrarCursos, conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataReader lector = comando.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(lector);

            conexion.Close();

            return tablaCursos;
        }

        public void InsertarCursos()
        {

        }
    }
}
