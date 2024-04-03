using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ProdutosAcessoDados
    {
        public DataTable ListarProdutos()
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS, Produtos.NOME, Produtos.DETALHES, Categorias.NOME AS NOME_CATEGORIA,");
                    sql.Append("Produtos.ESTOQUE_ATUAL, Produtos.ESTOQUE_MINIMO, Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.DATA_CADASTRO,");
                    sql.Append("Produtos.ID_CATEGORIA");
                    sql.Append(" FROM Produtos");
                    sql.Append(" INNER JOIN Categorias ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" ORDER BY Produtos.ID_PRODUTO DESC");


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
                throw new Exception("Ocorreu um erro no método ListarProdutos. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void Salvar(string codigoBarras, string nome, string detalhes, string categoria, string estoqueAtual, string estoqueMinimo, 
            decimal valorCompra, decimal valorVenda, DateTime dataCadastro)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("INSERT INTO Produtos (CODIGO_BARRAS, NOME, DETALHES, ID_CATEGORIA, ESTOQUE_ATUAL, ESTOQUE_MINIMO, VALOR_COMPRA, VALOR_VENDA, DATA_CADASTRO)");
                    sql.Append(" VALUES(@codigoBarras, @nome, @detalhes, @idCategoria, @estoqueAtual, @estoqueMinimo, @valorCompra, @valorVenda, @dataCadastro)");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@codigoBarras", Convert.ToInt32(codigoBarras));
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@detalhes", detalhes);
                        command.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(categoria));
                        command.Parameters.AddWithValue("@estoqueAtual", Convert.ToInt32(estoqueAtual));
                        command.Parameters.AddWithValue("@estoqueMinimo", Convert.ToInt32(estoqueMinimo));
                        command.Parameters.AddWithValue("@valorCompra", Convert.ToDecimal(valorCompra));
                        command.Parameters.AddWithValue("@valorVenda", Convert.ToDecimal(valorVenda));
                        command.Parameters.AddWithValue("@dataCadastro", dataCadastro);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idProduto)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("DELETE FROM Produtos WHERE ID_PRODUTO = @idProduto");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idProduto", idProduto);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Se o erro persistir, entre em contato com o Admnistrador do sistema");
            }
        }

        public void Atualizar(int idProduto, string codigoBarras, string nome, string detalhes, string categoria, string estoqueAtual, string estoqueMinimo,
            decimal valorCompra, decimal valorVenda, DateTime dataCadastro)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("UPDATE Produtos SET CODIGO_BARRAS = @codigoBarras, NOME = @nome, DETALHES = @detalhes,");
                    sql.Append(" ID_CATEGORIA = @idCategoria, ESTOQUE_ATUAL = @estoqueAtual, ESTOQUE_MINIMO = @estoqueMinimo,");
                    sql.Append(" VALOR_COMPRA = @valorCompra, VALOR_VENDA = @valorVenda, DATA_CADASTRO = @dataCadastro");
                    sql.Append(" WHERE ID_PRODUTO = @idProduto");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idProduto", idProduto);
                        command.Parameters.AddWithValue("@codigoBarras", Convert.ToInt32(codigoBarras));
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@detalhes", detalhes);
                        command.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(categoria));
                        command.Parameters.AddWithValue("@estoqueAtual", Convert.ToInt32(estoqueAtual));
                        command.Parameters.AddWithValue("@estoqueMinimo", Convert.ToInt32(estoqueMinimo));
                        command.Parameters.AddWithValue("@valorCompra", valorCompra);
                        command.Parameters.AddWithValue("@valorVenda", valorVenda);
                        command.Parameters.AddWithValue("@dataCadastro", dataCadastro);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Atualizar. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public DataTable ListarProdutosEstoqueBaixo()
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT ID_PRODUTO, CODIGO_BARRAS, NOME, DETALHES, ID_CATEGORIA, ESTOQUE_ATUAL, ESTOQUE_MINIMO, VALOR_COMPRA, VALOR_VENDA,");
                    sql.Append(" DATA_CADASTRO FROM Produtos WHERE ESTOQUE_MINIMO >= ESTOQUE_ATUAL");


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
                throw new Exception("Ocorreu um erro no método ListarProdutosEstoqueBaixo. Se o erro persistir entre em contato com o Administrador do sistema");
            }
        }

        public DataTable RetornaProdutosPorNome(string nome)
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS, Produtos.NOME, Produtos.DETALHES, Categorias.NOME AS NOME_CATEGORIA,");
                    sql.Append("Produtos.ESTOQUE_ATUAL, Produtos.ESTOQUE_MINIMO, Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.DATA_CADASTRO,");
                    sql.Append(" Produtos.ID_CATEGORIA FROM Produtos");
                    sql.Append(" INNER JOIN Categorias ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE Produtos.NOME LIKE '%'+ @nome +'%'");
                    sql.Append(" ORDER BY Produtos.ID_PRODUTO DESC");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);

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
                throw new Exception("Ocorreu um erro no método RetornaProdutosPorNome. Se o erro persitir, entre em contato com o Administtrador do sistema");
            }
        }

        public DataTable RetornaProdutosPorCategoria(string categoria)
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS, Produtos.NOME, Produtos.DETALHES, Categorias.NOME AS NOME_CATEGORIA,");
                    sql.Append("Produtos.ESTOQUE_ATUAL, Produtos.ESTOQUE_MINIMO, Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.DATA_CADASTRO,");
                    sql.Append(" Produtos.ID_CATEGORIA FROM Produtos");
                    sql.Append(" INNER JOIN Categorias ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE Categorias.NOME LIKE '%'+ @categoria +'%'");
                    sql.Append(" ORDER BY Produtos.ID_PRODUTO DESC");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@categoria", categoria);

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
                throw new Exception("Ocorreu um erro no método RetornaProdutosPorCategoria. Se o erro persitir, entre em contato com o Administtrador do sistema");
            }
        }

        public DataTable RetornaProdutosPorCodigoBarras(string codigoBarras, string apenasCod = "")
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS, Produtos.NOME, Produtos.DETALHES, Categorias.NOME AS NOME_CATEGORIA,");
                    sql.Append("Produtos.ESTOQUE_ATUAL, Produtos.ESTOQUE_MINIMO, Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.DATA_CADASTRO,");
                    sql.Append(" Produtos.ID_CATEGORIA FROM Produtos");
                    sql.Append(" INNER JOIN Categorias ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    
                    if (apenasCod == "")
                    {
						sql.Append(" WHERE Produtos.CODIGO_BARRAS LIKE '%'+ @codigoBarras +'%'");
					}
                    else
                    {
                        sql.Append(" WHERE Produtos.CODIGO_BARRAS = @codigoBarras");
                    }

                    sql.Append(" ORDER BY Produtos.ID_PRODUTO DESC");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@codigoBarras", codigoBarras);

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
                throw new Exception("Ocorreu um erro no método RetornaProdutosPorCodigoBarras. Se o erro persitir, entre em contato com o Administrador do sistema");
            }
        }

        public void AtualizaEstoque(int idProduto, int estoqueAtual)
        {
            try
            {
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					var sql = new StringBuilder();
					sql.Append("UPDATE Produtos");
                    sql.Append(" SET ESTOQUE_ATUAL = @estoqueAtual");
                    sql.Append(" WHERE ID_PRODUTO = @idProduto");

                    using (var command = new SqlCommand(sql.ToString(), conexao))
                    {
                        command.Parameters.AddWithValue("@estoqueAtual", estoqueAtual);
                        command.Parameters.AddWithValue("idProduto", idProduto);

                        command.ExecuteNonQuery();
                    }
				}
			}
            catch (Exception)
            {
				throw new Exception("Ocorreu um erro no método AtualizaEstoque. Se o erro persitir, entre em contato com o Administtrador do sistema");
            }
        }
    }
}
