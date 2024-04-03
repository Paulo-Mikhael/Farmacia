using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
	public class VendasAcessoDados
	{
		public DataTable ListarDetalhesDaVenda()
		{
			try
			{
				var tabela = new DataTable();

				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					StringBuilder sql = new StringBuilder();
					sql.Append("SELECT Detalhes_Vendas.ID_PRODUTO, Produtos.CODIGO_BARRAS, Produtos.NOME, Produtos.DETALHES, Produtos.VALOR_VENDA,");
					sql.Append(" Detalhes_Vendas.QUANTIDADE");
					sql.Append(" FROM Detalhes_Vendas");
					sql.Append(" INNER JOIN Produtos ON Detalhes_Vendas.ID_PRODUTO = Produtos.ID_PRODUTO");
					sql.Append(" WHERE ID_VENDA = -1");

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
				throw new Exception("Ocorreu um erro no método ListarDetalhesDaVendas. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}

		public void AdicionarDetalhesVenda(int idProduto, int quantidade)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("INSERT INTO Detalhes_Vendas(ID_VENDA, ID_PRODUTO, QUANTIDADE)");
					sql.Append(" VALUES(-1, @idProduto, @quantidade)");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idProduto", idProduto);
						command.Parameters.AddWithValue("@quantidade", quantidade);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método AdicionarDetalhesVenda. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}

		public void AtualizaDetalhesDaVendaQuantidade(string idProduto, int quantidade)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("UPDATE Detalhes_Vendas");
					sql.Append(" SET QUANTIDADE = @quantidade");
					sql.Append(" WHERE ID_PRODUTO = @idProduto AND ID_VENDA = -1");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idProduto", idProduto);
						command.Parameters.AddWithValue("@quantidade", quantidade);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método AtualizaDetalhesDaVendaQuantidade. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}

		public void AtualizaDetalhesDaVendaIdVenda(int idVenda)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("UPDATE Detalhes_Vendas");
					sql.Append(" SET ID_VENDA = @idVenda");
					sql.Append(" WHERE ID_VENDA = -1");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idVenda", idVenda);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método AtualizaDetalhesDaVendaQuantidade. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}

		public void RemoverDetalheDaVenda(int idProduto)
		{
			using (var connection = new SqlConnection(Conexao.stringConexao))
			{
				connection.Open();

				var sql = new StringBuilder();
				sql.Append("DELETE FROM Detalhes_Vendas");
				sql.Append(" WHERE ID_PRODUTO = @idProduto AND ID_VENDA = -1");

				using (var command = new SqlCommand(sql.ToString(), connection))
				{
					command.Parameters.AddWithValue("@idProduto", idProduto);

					command.ExecuteNonQuery();
				}
			}
		}

		public DataTable ListarVendas()
		{
			try
			{
				var tabela = new DataTable();

				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					StringBuilder sql = new StringBuilder();
					sql.Append("SELECT Vendas.ID_VENDA, Vendas.ID_USUARIO, Vendas.ID_CLIENTE, Vendas.DATA_VENDA, Vendas.SITUACAO, Vendas.TOTAL");
					sql.Append(" FROM Vendas");
					sql.Append(" ORDER BY ID_VENDA DESC");

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
				throw new Exception("Ocorreu um erro no método ListarVendas. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}

		public void AdicionarVenda(int idUsuario, int idCliente, DateTime dataVenda, string situacao, decimal total)
		{
			try
			{
				using (var connection = new SqlConnection(Conexao.stringConexao))
				{
					connection.Open();

					var sql = new StringBuilder();
					sql.Append("INSERT INTO Vendas(ID_USUARIO, ID_CLIENTE, DATA_VENDA, SITUACAO, TOTAL)");
					sql.Append(" VALUES(@idUsuario, @idCliente, @dataVenda, @situacao, @total)");

					using (var command = new SqlCommand(sql.ToString(), connection))
					{
						command.Parameters.AddWithValue("@idUsuario", idUsuario);
						command.Parameters.AddWithValue("@idCliente", idCliente);
						command.Parameters.AddWithValue("@dataVenda", dataVenda);
						command.Parameters.AddWithValue("@situacao", situacao);
						command.Parameters.AddWithValue("@total", total);

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro no método AdicionarVenda. Se o erro persistir, entre em contato com o Administrador do sistema.");
			}
		}
	}
}
