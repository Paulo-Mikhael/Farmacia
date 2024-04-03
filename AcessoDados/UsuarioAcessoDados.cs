using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class UsuarioAcessoDados
	{
		public void Salvar(string nome, string login, string senha, int nivel, string status, DateTime cadastro)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();
					var sql = new StringBuilder();

					sql.Append("INSERT INTO Usuarios(NOME, LOGIN_USUARIO, SENHA_USUARIO, NIVEL_USUARIO, STATUS_USUARIO, DATA_CADASTRO)");
					sql.Append(" VALUES(@nome, @login, @senha, @nivel, @status, @cadastro)");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@nome", nome);
						command.Parameters.AddWithValue("@login", login);
						command.Parameters.AddWithValue("@senha", senha);
						command.Parameters.AddWithValue("@nivel", nivel);
						command.Parameters.AddWithValue("@status", status);
						command.Parameters.AddWithValue("@cadastro", cadastro);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorre um erro no método Salvar. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}

		public void Atualizar(int idUsuario, string nome, string login, string senha, int nivel, string status)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();
					var sql = new StringBuilder();

					sql.Append("UPDATE Usuarios SET NOME = @nome, LOGIN_USUARIO = @login, SENHA_USUARIO = @senha, STATUS_USUARIO = @status,");
					sql.Append(" NIVEL_USUARIO = @nivel WHERE ID_USUARIO = @idUsuario");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@nome", nome);
						command.Parameters.AddWithValue("@login", login);
						command.Parameters.AddWithValue("@senha", senha);
						command.Parameters.AddWithValue("@nivel", nivel);
						command.Parameters.AddWithValue("@status", status);
						command.Parameters.AddWithValue("@idUsuario", idUsuario);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método Atualizar. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}

		public void Deletar(int idUsuario)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();
					var sql = new StringBuilder();

					sql.Append("DELETE FROM Usuarios WHERE ID_USUARIO = @idUsuario");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idUsuario", idUsuario);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método Deletar. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}

		public DataTable ListarUsuarios(int idUsuario = 0)
		{
			var tabela = new DataTable();

			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();
					var sql = new StringBuilder();

					sql.Append("SELECT Usuarios.ID_USUARIO, Usuarios.NOME, Usuarios.LOGIN_USUARIO, Usuarios.SENHA_USUARIO, NiveisUsuarios.NOME AS NivelUsuario,");
					sql.Append(" Usuarios.STATUS_USUARIO, Usuarios.DATA_CADASTRO, Usuarios.NIVEL_USUARIO FROM Usuarios");
					sql.Append(" INNER JOIN NiveisUsuarios ON Usuarios.NIVEL_USUARIO = NiveisUsuarios.ID_NIVEL");

					if (idUsuario != 0)
					{
						sql.Append(" WHERE ID_USUARIO = @idUsuario");
					}

					sql.Append(" ORDER BY ID_USUARIO DESC");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idUsuario", idUsuario);

						using (var reader = command.ExecuteReader())
						{
							tabela.Load(reader);
							return tabela;
						}
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método ListarUsuarios. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}

		public DataTable RetornaUsuario(string login, int idUsuario = 0)
		{
			var tabela = new DataTable();

			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("SELECT ID_USUARIO, NOME, LOGIN_USUARIO, SENHA_USUARIO, NIVEL_USUARIO, STATUS_USUARIO, DATA_CADASTRO FROM Usuarios");
					sql.Append(" WHERE LOGIN_USUARIO = @login");

					if (idUsuario != 0)
					{
						sql.Append(" AND ID_USUARIO != @idUsuario");
					}

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@login", login);
						command.Parameters.AddWithValue("@idUsuario", idUsuario);

						using (var reader = command.ExecuteReader())
						{
							tabela.Load(reader);
							return tabela;
						}
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método RetornaUsuario. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}

		public DataTable ListarNiveis()
		{
			var tabela = new DataTable();

			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("SELECT ID_NIVEL, NOME, DESCRICAO FROM NiveisUsuarios");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						using (var reader = command.ExecuteReader())
						{
							tabela.Load(reader);
							return tabela;
						}
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método ListarNiveis. Se o erro persistir, entre em contato com o Administrador do sistema");
			}
		}
	}
}
