using System;
using System.Data;
using System.Data.SqlClient;
using Layers.Framework.ADO.Net;
using Layers.Framework.ADO.Net.Data;

public class clsLnTiposEntidades
{

    public void Cargar(ref clsBeTiposEntidades oBeTiposEntidades, DataRow dr)
    {
        try
        {
            oBeTiposEntidades.IdTipoEntidad = Convert.ToInt32(dr["IdTipoEntidad"].ToString());
            oBeTiposEntidades.Descripcion = string.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
            oBeTiposEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"].ToString());
            oBeTiposEntidades.Comentario = string.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
            oBeTiposEntidades.Status = string.IsNullOrEmpty(dr["Status"].ToString()) == true ? "" : dr["Status"].ToString();
            oBeTiposEntidades.NoEliminable = Convert.ToBoolean(dr["IdEntidad"].ToString());
            oBeTiposEntidades.FechaRegistro = Convert.ToDateTime(dr["IdEntidad"].ToString());
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Insertar(ref clsBeTiposEntidades oBeTiposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpTiposEntidadesInsertar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeTiposEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();
            
            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Actualizar(ref clsBeTiposEntidades oBeTiposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpTiposEntidadesActualizar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeTiposEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Eliminar(ref clsBeTiposEntidades oBeTiposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpTiposEntidadesEliminar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
            
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
            string storedProcedure = "SpTiposEntidadesListar";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool Obtener(ref clsBeTiposEntidades oBeTiposEntidades)
    {
        try
        {
            string storedProcedure = "SpTiposEntidadesObtener";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
            sqlDataAdapter.Fill(dataTable);

            if ((dataTable.Rows.Count == 1))
            {
                Cargar(ref oBeTiposEntidades, dataTable.Rows[0]);
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
