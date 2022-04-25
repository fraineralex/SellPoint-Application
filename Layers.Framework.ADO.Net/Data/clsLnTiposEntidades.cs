using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnTiposEntidades {

	private ConnectionManager oConexion = null;

	 public clsLnTiposEntidades(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeTiposEntidades, ref DataRow dr) {
		try {
				oBeTiposEntidades.IdTipoEntidad = ( IsDBNull(dr.Item['IdTipoEntidad']) ? 0 : dr.Item['IdTipoEntidad'] )
				oBeTiposEntidades.Descripcion = ( IsDBNull(dr.Item['Descripcion']) ? '' : dr.Item['Descripcion'] )
				oBeTiposEntidades.IdGrupoEntidad = ( IsDBNull(dr.Item['IdGrupoEntidad']) ? 0 : dr.Item['IdGrupoEntidad'] )
				oBeTiposEntidades.Comentario = ( IsDBNull(dr.Item['Comentario']) ? '' : dr.Item['Comentario'] )
				oBeTiposEntidades.Status = ( IsDBNull(dr.Item['Status']) ? '' : dr.Item['Status'] )
				oBeTiposEntidades.NoEliminable = ( IsDBNull(dr.Item['NoEliminable']) ? False : dr.Item['NoEliminable'] )
				oBeTiposEntidades.FechaRegistro = ( IsDBNull(dr.Item['FechaRegistro']) ? Date.Now() : dr.Item['FechaRegistro'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeTiposEntidades oBeTiposEntidades) {
		try {
			string sp = 'SpTiposEntidadesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			cmd.Parameters("@IDTIPOENTIDAD").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeTiposEntidades.Status));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeTiposEntidades.IdTipoEntidad = int.Parse(cmd.Parameters['@IDTIPOENTIDAD'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeTiposEntidades oBeTiposEntidades) {
		try {
			string sp = 'SpTiposEntidadesActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUS", oBeTiposEntidades.Status));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeTiposEntidades oBeTiposEntidades) {
		try {
			string sp = 'SpTiposEntidadesEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpTiposEntidadesListar';
			
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

	public bool Obtener(ref clsBeTiposEntidades oBeTiposEntidades) {
		try {
			string sp = 'SpTiposEntidadesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeTiposEntidades, dt.Rows(0))
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

	public bool Primero(ref clsBeTiposEntidades oBeTiposEntidades) {
		Try
			string sp = 'SpTiposEntidadesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeTiposEntidades, dt.Rows[0]);
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

	public bool Primero(ref clsBeTiposEntidades oBeTiposEntidades) {
		try {
			string sp = 'SpTiposEntidadesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeTiposEntidades, dt.Rows[0]);
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

	public bool Anterior(ref clsBeTiposEntidades oBeTiposEntidades) {
		Try
			string sp = 'SpTiposEntidadesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeTiposEntidades, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeTiposEntidades oBeTiposEntidades) {
		Try
			string sp = 'SpTiposEntidadesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeTiposEntidades, dt.Rows[0]);
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
