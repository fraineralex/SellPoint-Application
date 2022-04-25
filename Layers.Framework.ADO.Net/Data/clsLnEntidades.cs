using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnEntidades {

	private ConnectionManager oConexion = null;

	 public clsLnEntidades(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeEntidades, ref DataRow dr) {
		try {
				oBeEntidades.IdEntidad = ( IsDBNull(dr.Item['IdEntidad']) ? 0 : dr.Item['IdEntidad'] )
				oBeEntidades.Descripcion = ( IsDBNull(dr.Item['Descripcion']) ? '' : dr.Item['Descripcion'] )
				oBeEntidades.Direccion = ( IsDBNull(dr.Item['Direccion']) ? '' : dr.Item['Direccion'] )
				oBeEntidades.Localidad = ( IsDBNull(dr.Item['Localidad']) ? '' : dr.Item['Localidad'] )
				oBeEntidades.TipoEntidad = ( IsDBNull(dr.Item['TipoEntidad']) ? '' : dr.Item['TipoEntidad'] )
				oBeEntidades.TipoDocumento = ( IsDBNull(dr.Item['TipoDocumento']) ? '' : dr.Item['TipoDocumento'] )
				oBeEntidades.NumeroDocumento = ( IsDBNull(dr.Item['NumeroDocumento']) ? 0.0 : dr.Item['NumeroDocumento'] )
				oBeEntidades.Telefono = ( IsDBNull(dr.Item['Telefono']) ? '' : dr.Item['Telefono'] )
				oBeEntidades.URLPaginaWeb = ( IsDBNull(dr.Item['URLPaginaWeb']) ? '' : dr.Item['URLPaginaWeb'] )
				oBeEntidades.URLFacebook = ( IsDBNull(dr.Item['URLFacebook']) ? '' : dr.Item['URLFacebook'] )
				oBeEntidades.URLInstagram = ( IsDBNull(dr.Item['URLInstagram']) ? '' : dr.Item['URLInstagram'] )
				oBeEntidades.URLTwitter = ( IsDBNull(dr.Item['URLTwitter']) ? '' : dr.Item['URLTwitter'] )
				oBeEntidades.URLTiktok = ( IsDBNull(dr.Item['URLTiktok']) ? '' : dr.Item['URLTiktok'] )
				oBeEntidades.IdGrupoEntidad = ( IsDBNull(dr.Item['IdGrupoEntidad']) ? 0 : dr.Item['IdGrupoEntidad'] )
				oBeEntidades.IdTipoEntidad = ( IsDBNull(dr.Item['IdTipoEntidad']) ? 0 : dr.Item['IdTipoEntidad'] )
				oBeEntidades.LimiteCredito = ( IsDBNull(dr.Item['LimiteCredito']) ? 0.0 : dr.Item['LimiteCredito'] )
				oBeEntidades.UserNameEntidad = ( IsDBNull(dr.Item['UserNameEntidad']) ? '' : dr.Item['UserNameEntidad'] )
				oBeEntidades.PasswordEntidad = ( IsDBNull(dr.Item['PasswordEntidad']) ? '' : dr.Item['PasswordEntidad'] )
				oBeEntidades.RolUserEntidad = ( IsDBNull(dr.Item['RolUserEntidad']) ? '' : dr.Item['RolUserEntidad'] )
				oBeEntidades.Comentario = ( IsDBNull(dr.Item['Comentario']) ? '' : dr.Item['Comentario'] )
				oBeEntidades.Status = ( IsDBNull(dr.Item['Status']) ? '' : dr.Item['Status'] )
				oBeEntidades.NoEliminable = ( IsDBNull(dr.Item['NoEliminable']) ? False : dr.Item['NoEliminable'] )
				oBeEntidades.FechaRegistro = ( IsDBNull(dr.Item['FechaRegistro']) ? Date.Now() : dr.Item['FechaRegistro'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			cmd.Parameters("@IDENTIDAD").Direction = ParameterDirection.Output;
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
			oBeEntidades.IdEntidad = int.Parse(cmd.Parameters['@IDENTIDAD'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesActualizar';
			
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
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpEntidadesListar';
			
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

	public bool Obtener(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows(0))
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

	public bool Primero(ref clsBeEntidades oBeEntidades) {
		Try
			string sp = 'SpEntidadesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
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

	public bool Primero(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
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

	public bool Anterior(ref clsBeEntidades oBeEntidades) {
		Try
			string sp = 'SpEntidadesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeEntidades oBeEntidades) {
		Try
			string sp = 'SpEntidadesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
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
