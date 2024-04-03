using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class CategoriasAcessoDados
    {
        public DataTable ListarCategorias()
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT ID_CATEGORIA, NOME, DESCRICAO FROM Categorias");
                    sql.Append(" ORDER BY ID_CATEGORIA DESC");

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
                throw new Exception("Ocorreu um erro no método ListarNomeCategorias. Se o erro persitir, entre em contato com o Administrador do sistema");
            }
        }

        public void Salvar(string nome, string descricao)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("INSERT INTO Categorias(NOME, DESCRICAO)");
                    sql.Append(" VALUES(@nome, @descricao)");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@descricao", descricao);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void Excluir(int idCategoria)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();
                    var sql = new StringBuilder();

                    sql.Append("DELETE FROM Categorias WHERE ID_CATEGORIA = @idCategoria");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idCategoria", idCategoria);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void Atualizar(int idCategoria, string nome, string descricao)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();
                    var sql = new StringBuilder();

                    sql.Append("UPDATE Categorias SET NOME = @nome, DESCRICAO = @descricao WHERE ID_CATEGORIA = @idCategoria");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idCategoria", idCategoria);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@descricao", descricao);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Atualizar. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void ExcluirProdutosPorCategoria(int idCategoria)
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();
                    var sql = new StringBuilder();

                    sql.Append("DELETE FROM Produtos WHERE ID_CATEGORIA = @idCategoria");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idCategoria", idCategoria);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirProdutosPorCategoria. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public int RetornaNumeroProdutosCategoria(int idCategoria)
        {
            int numeroProdutos;
            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();
                    var sql = new StringBuilder();

                    sql.Append("SELECT COUNT(*) FROM Produtos WHERE ID_CATEGORIA = @idCategoria");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idCategoria", idCategoria);

                        numeroProdutos = (int)command.ExecuteScalar();
                        return numeroProdutos;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornaNumeroProdutosCategoria. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }
    }
}
