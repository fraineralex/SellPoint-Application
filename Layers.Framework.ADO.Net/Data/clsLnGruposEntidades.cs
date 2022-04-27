using System;
using System.Data;
using System.Data.SqlClient;
using Layers.Framework.ADO.Net;
using Layers.Framework.ADO.Net.Data;

public class clsLnGruposEntidades
{

    public void Cargar(ref clsBeGruposEntidades oBeGruposEntidades, DataRow dr)
    {
        try
        {
            oBeGruposEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"].ToString());
            oBeGruposEntidades.Descripcion = string.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
            oBeGruposEntidades.Comentario = string.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
            oBeGruposEntidades.Status = string.IsNullOrEmpty(dr["Status"].ToString()) == true ? "" : dr["Status"].ToString();
            oBeGruposEntidades.NoEliminable = Convert.ToBoolean(dr["IdEntidad"].ToString());
            oBeGruposEntidades.FechaRegistro = Convert.ToDateTime(dr["IdEntidad"].ToString());
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Insertar(ref clsBeGruposEntidades oBeGruposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpGruposEntidadesInsertar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeGruposEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Actualizar(ref clsBeGruposEntidades oBeGruposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpGruposEntidadesActualizar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
            sqlCommand.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
            sqlCommand.Parameters.Add(new SqlParameter("@STATUS", oBeGruposEntidades.Status));
            sqlCommand.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
            sqlCommand.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));

            rowsAffected = sqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Eliminar(ref clsBeGruposEntidades oBeGruposEntidades)
    {
        try
        {
            int rowsAffected = 0;
            string storedProcedure = "SpGruposEntidadesEliminar";

            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
            
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
            string storedProcedure = "SpGruposEntidadesListar";

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

    public bool Obtener(ref clsBeGruposEntidades oBeGruposEntidades)
    {
        try
        {
            string storedProcedure = "SpGruposEntidadesObtener";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);
            
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
            sqlDataAdapter.Fill(dataTable);

            if ((dataTable.Rows.Count == 1))
            {
                Cargar(ref oBeGruposEntidades, dataTable.Rows[0]);

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

    public DataTable BuscarGrupoEntidad(ref clsBeGruposEntidades oBeGrupoEntidades)
    {
        try
        {
            string storedProcedure = "SpGruposEntidadesObtener";

            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Datos.DBConnection);

            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGrupoEntidades.IdGrupoEntidad));
            sqlAdapter.Fill(dataTable);

            return dataTable;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
