using System;
using System.Data;
using System.Data.SqlClient;
using Layers.Framework.ADO.Net;
using Layers.Framework.ADO.Net.Data;

public class clsLnEntidades
{
    public void Cargar(ref clsBeEntidades oBeEntidades, DataRow dr)
    {
        try
        {
            oBeEntidades.IdEntidad = Convert.ToInt32(dr["IdEntidad"].ToString());
            oBeEntidades.Descripcion = string.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
            oBeEntidades.Direccion = string.IsNullOrEmpty(dr["Direccion"].ToString()) == true ? "" : dr["Direccion"].ToString();
            oBeEntidades.Localidad = string.IsNullOrEmpty(dr["Localidad"].ToString()) == true ? "" : dr["Localidad"].ToString();
            oBeEntidades.TipoEntidad = string.IsNullOrEmpty(dr["TipoEntidad"].ToString()) == true ? "" : dr["TipoEntidad"].ToString();
            oBeEntidades.TipoDocumento = string.IsNullOrEmpty(dr["TipoDocumento"].ToString()) == true ? "" : dr["TipoDocumento"].ToString();
            oBeEntidades.NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"].ToString());
            oBeEntidades.Telefono = string.IsNullOrEmpty(dr["Telefono"].ToString()) == true ? "" : dr["Telefono"].ToString();
            oBeEntidades.URLPaginaWeb = string.IsNullOrEmpty(dr["URLPaginaWeb"].ToString()) == true ? "" : dr["URLPaginaWeb"].ToString();
            oBeEntidades.URLFacebook = string.IsNullOrEmpty(dr["URLFacebook"].ToString()) == true ? "" : dr["URLFacebook"].ToString();
            oBeEntidades.URLInstagram = string.IsNullOrEmpty(dr["URLInstagram"].ToString()) == true ? "" : dr["URLInstagram"].ToString();
            oBeEntidades.URLTwitter = string.IsNullOrEmpty(dr["URLTwitter"].ToString()) == true ? "" : dr["URLTwitter"].ToString();
            oBeEntidades.URLTiktok = string.IsNullOrEmpty(dr["URLTiktok"].ToString()) == true ? "" : dr["URLTiktok"].ToString();
            oBeEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"].ToString());
            oBeEntidades.IdTipoEntidad = Convert.ToInt32(dr["IdTipoEntidad"].ToString());
            oBeEntidades.LimiteCredito = Convert.ToInt32(dr["LimiteCredito"].ToString());
            oBeEntidades.UserNameEntidad = string.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
            oBeEntidades.PasswordEntidad = string.IsNullOrEmpty(dr["PasswordEntidad"].ToString()) == true ? "" : dr["PasswordEntidad"].ToString();
            oBeEntidades.RolUserEntidad = string.IsNullOrEmpty(dr["RolUserEntidad"].ToString()) == true ? "" : dr["RolUserEntidad"].ToString();
            oBeEntidades.Comentario = string.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
            oBeEntidades.Status = string.IsNullOrEmpty(dr["Status"].ToString()) == true ? "" : dr["Status"].ToString();
            oBeEntidades.NoEliminable = Convert.ToBoolean(dr["IdEntidad"].ToString());
            oBeEntidades.FechaRegistro = Convert.ToDateTime(dr["IdEntidad"].ToString());
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
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            
            sqlConnection.Open();

            sqlCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            sqlCommand.Parameters["@IDENTIDAD"].Direction = ParameterDirection.Output;
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
            oBeEntidades.IdEntidad = Convert.ToInt32(sqlCommand.Parameters["@IDENTIDAD"].Value.ToString());

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
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);

            sqlConnection.Open();

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
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);

            sqlConnection.Open();
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
            string storedProcedure = "SpEntidadesObtener";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            sqlAdapter.Fill(dataTable);

            if ((dataTable.Rows.Count == 1))
            {
                Cargar(ref oBeEntidades, dataTable.Rows[0]);

            }
            else
            {
                throw new Exception("No se pudo obtener el registro");
            }

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
