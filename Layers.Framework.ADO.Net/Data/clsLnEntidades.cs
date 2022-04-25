using System;
using System.Data;
using System.Data.SqlClient;
using Layers.Framework.ADO.Net;
using Layers.Framework.ADO.Net.Data;

public class clsLnEntidades
{
    public void Cargar(ref clsBeEntidades oBeEntidades, ref DataRow dr)
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
            string sp = "SpEntidadesInsertar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            SqlCommand sqlCommand = new SqlCommand(sp, sqlConnection);
            
            sqlConnection.Open();

            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            sqlCommand.Parameters("@IDENTIDAD").Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@TELEFONO", oBeEntidades.Telefono));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@URLTIKTOK", oBeEntidades.URLTiktok));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@PASSWORDENTIDAD", oBeEntidades.PasswordEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeEntidades.Status));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();
            oBeEntidades.IdEntidad = Convert.ToInt32(sqlCommand.Parameters["@IDENTIDAD"].Value);

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
            string sp = "SpEntidadesActualizar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);

            int rowsAffected = 0;
            cmd.Open();

            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TELEFONO", oBeEntidades.Telefono));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTIKTOK", oBeEntidades.URLTiktok));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@PASSWORDENTIDAD", oBeEntidades.PasswordEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeEntidades.Status));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = cmd.ExecuteNonQuery();

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
            string sp = "SpEntidadesEliminar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);

            int rowsAffected = 0;
            cmd.Open();

            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

            rowsAffected = cmd.ExecuteNonQuery();

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
            string sp = "SpEntidadesListar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dad.Fill(dt);

            return dt;

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
            string sp = "SpEntidadesObtener";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

            DataTable dt = new DataTable();
            dad.Fill(dt);

            if ((dt.Rows.Count == 1))
            {
                Cargar(oBeEntidades, dt.Rows(0))

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

    public bool Primero(ref clsBeEntidades oBeEntidades)
    {
        try

            string sp = "SpEntidadesPrimero";

        SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
        SqlCommand cmd = new SqlCommand(sp, cnn);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter dad = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        dad.Fill(dt);

        if ((dt.Rows.Count == 1))
        {
            Cargar(oBeEntidades, dt.Rows[0]);
        }
        else
        {
            throw new Exception("No se pudo obtener el primer registro");
        }

        return true;
    }
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeEntidades oBeEntidades)
{
    try
    {
        string sp = "SpEntidadesUltimo";

        SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
        SqlCommand cmd = new SqlCommand(sp, cnn);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter dad = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        dad.Fill(dt);

        if ((dt.Rows.Count == 1))
        {
            Cargar(oBeEntidades, dt.Rows[0]);
        }
        else
        {
            throw new Exception("No se pudo obtener el primer registro");
        }

        return true;
    }
    catch (Exception ex)
    {
        throw ex;
    }
}

public bool Anterior(ref clsBeEntidades oBeEntidades)
{
    try

            string sp = "SpEntidadesAnterior";

    SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
    SqlCommand cmd = new SqlCommand(sp, cnn);
    cmd.CommandType = CommandType.StoredProcedure;

    SqlDataAdapter dad = new SqlDataAdapter(cmd);
    dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

    DataTable dt = new DataTable();
    dad.Fill(dt);

    if ((dt.Rows.Count == 1))
    {
        Cargar(oBeEntidades, dt.Rows[0]);
    }
    else
    {
        throw new Exception("No se pudo obtener el anterior registro");
        End If

            }

    return true;
}

        catch (Exception ex)
{
    throw ex;
}
	}

	public bool Siguiente(ref clsBeEntidades oBeEntidades)
{
    try

            string sp = "SpEntidadesSiguiente";

    SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
    SqlCommand cmd = new SqlCommand(sp, cnn);
    cmd.CommandType = CommandType.StoredProcedure;

    SqlDataAdapter dad = new SqlDataAdapter(cmd);
    dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

    DataTable dt = new DataTable();
    dad.Fill(dt);

    if ((dt.Rows.Count == 1))
    {
        Cargar(oBeEntidades, dt.Rows[0]);
    }
    else
    {
        throw new Exception("No se pudo obtener el siguiente registro");
        End If

            }

    return true;
}

        catch (Exception ex)
{
    throw ex;
}
	}

}
