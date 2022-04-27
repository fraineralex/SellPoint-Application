using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Layers.Framework.ADO.Net;
using Layers.Framework.ADO.Net.Data;

public class clsLnEntidades
{
    public void Cargar(ref clsBeEntidades oBeEntidades, DataRow dr)
    {
        try
        {
            oBeEntidades.UserNameEntidad = string.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
            oBeEntidades.PasswordEntidad = string.IsNullOrEmpty(dr["PasswordEntidad"].ToString()) == true ? "" : dr["PasswordEntidad"].ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Insertar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpEntidadesInsertar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            sqlCommand.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            sqlCommand.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", oBeEntidades.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            sqlCommand.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            sqlCommand.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            sqlCommand.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            sqlCommand.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTiktok));
            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            sqlCommand.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@PASSWORDENTIDAD", oBeEntidades.PasswordEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Actualizar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpEntidadesActualizar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            sqlCommand.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            sqlCommand.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            sqlCommand.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            sqlCommand.Parameters.Add(new SqlParameter("@TELEFONO", oBeEntidades.Telefono));
            sqlCommand.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            sqlCommand.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            sqlCommand.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            sqlCommand.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            sqlCommand.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTiktok));
            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            sqlCommand.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@PASSWORDENTIDAD", oBeEntidades.PasswordEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Eliminar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpEntidadesEliminar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            
            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable Listar()
    {
        try
        {
            string storedProcedure = "SpEntidadesListar";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            return dataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool Obtener(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string storedProcedure = "SPLoginEntidades";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@UserNameEntidad", oBeEntidades.UserNameEntidad));
            sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@PasswordEntidad", oBeEntidades.PasswordEntidad));
            sqlAdapter.Fill(dataTable);

            if ((dataTable.Rows.Count == 1))
            {
                Cargar(ref oBeEntidades, dataTable.Rows[0]);
                return true;
            }

            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public DataTable BuscarEntidad(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string storedProcedure = "SpEntidadesObtener";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            sqlAdapter.Fill(dataTable);

            return dataTable;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
