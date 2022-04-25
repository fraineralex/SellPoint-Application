using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnGruposEntidades {

	private ConnectionManager oConexion = null;

	 public clsLnGruposEntidades(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeGruposEntidades, ref DataRow dr) {
		try {
				oBeGruposEntidades.IdGrupoEntidad = ( IsDBNull(dr.Item['IdGrupoEntidad']) ? 0 : dr.Item['IdGrupoEntidad'] )
				oBeGruposEntidades.Descripcion = ( IsDBNull(dr.Item['Descripcion']) ? '' : dr.Item['Descripcion'] )
				oBeGruposEntidades.Comentario = ( IsDBNull(dr.Item['Comentario']) ? '' : dr.Item['Comentario'] )
				oBeGruposEntidades.Status = ( IsDBNull(dr.Item['Status']) ? '' : dr.Item['Status'] )
				oBeGruposEntidades.NoEliminable = ( IsDBNull(dr.Item['NoEliminable']) ? False : dr.Item['NoEliminable'] )
				oBeGruposEntidades.FechaRegistro = ( IsDBNull(dr.Item['FechaRegistro']) ? Date.Now() : dr.Item['FechaRegistro'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeGruposEntidades oBeGruposEntidades) {
		try {
			string sp = 'SpGruposEntidadesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			cmd.Parameters("@IDGRUPOENTIDAD").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeGruposEntidades.Status));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeGruposEntidades.IdGrupoEntidad = int.Parse(cmd.Parameters['@IDGRUPOENTIDAD'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeGruposEntidades oBeGruposEntidades) {
		try {
			string sp = 'SpGruposEntidadesActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeGruposEntidades.Status));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeGruposEntidades oBeGruposEntidades) {
		try {
			string sp = 'SpGruposEntidadesEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpGruposEntidadesListar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			return dt;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Obtener(ref clsBeGruposEntidades oBeGruposEntidades) {
		try {
			string sp = 'SpGruposEntidadesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeGruposEntidades, dt.Rows(0))
			}
			else {
				throw new Exception('No se pudo obtener el registro');
			}
			
			return true;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeGruposEntidades oBeGruposEntidades) {
		Try
			string sp = 'SpGruposEntidadesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeGruposEntidades, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeGruposEntidades oBeGruposEntidades) {
		try {
			string sp = 'SpGruposEntidadesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeGruposEntidades, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Anterior(ref clsBeGruposEntidades oBeGruposEntidades) {
		Try
			string sp = 'SpGruposEntidadesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeGruposEntidades, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el anterior registro');
			End If
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Siguiente(ref clsBeGruposEntidades oBeGruposEntidades) {
		Try
			string sp = 'SpGruposEntidadesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeGruposEntidades, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el siguiente registro');
			End If
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

}
