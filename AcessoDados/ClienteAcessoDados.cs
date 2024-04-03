using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ClienteAcessoDados
    {
        public void Salvar(string nome, string rg, string cpf, string endereco, string bairro, string cidade,
            DateTime nascimento, string residencial, string celular, string observacoes, DateTime cadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("INSERT INTO Clientes (NOME, RG, CPF, ENDERECO, BAIRRO, CIDADE, NASCIMENTO, RESIDENCIAL, CELULAR, OBSERVACOES, DATA_CADASTRO)");
                    sql.Append("VALUES (@nome, @rg, @cpf, @endereco, @bairro, @cidade, @nascimento, @residencial, @celular, @observacoes, @cadastro)");

                    using (SqlCommand command = new SqlCommand(sql.ToString(), conexao))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@rg", rg);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@endereco", endereco);
                        command.Parameters.AddWithValue("@bairro", bairro);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@nascimento", nascimento);
                        command.Parameters.AddWithValue("@residencial", residencial);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.Parameters.AddWithValue("@observacoes", observacoes);
                        command.Parameters.AddWithValue("@cadastro", cadastro);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void Excluir(int idCliente)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    StringBuilder sql = new StringBuilder();
                    var consulta = sql.Append("DELETE FROM Clientes WHERE ID_CLIENTE = @idCliente");

                    using (SqlCommand command = new SqlCommand(consulta.ToString(), conexao))
                    {
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public DataTable ListarClientes()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT NOME, CPF, CELULAR, CIDADE, DATA_CADASTRO, ENDERECO, NASCIMENTO, BAIRRO, OBSERVACOES, ID_CLIENTE, RG, RESIDENCIAL  FROM Clientes ");
                    sql.Append("ORDER BY ID_CLIENTE DESC");

                    using (SqlCommand comando = new SqlCommand(sql.ToString(), conexao))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(tabela);
                            return tabela;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarClientes. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public void Atualizar(int idCliente, string nome, string rg, string cpf, string endereco, string bairro, string cidade,
            DateTime nascimento, string residencial, string celular, string observacoes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE Clientes ");
                    sql.Append("SET NOME=@nome, CPF=@cpf, RG=@rg, ENDERECO = @endereco, BAIRRO=@bairro, CIDADE=@cidade, NASCIMENTO=@nascimento, " +
                        "RESIDENCIAL=@residencial, CELULAR=@celular, OBSERVACOES=@observacoes ");
                    sql.Append("WHERE ID_CLIENTE=@idCliente");

                    using (SqlCommand command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@rg", rg);
                        command.Parameters.AddWithValue("@endereco", endereco);
                        command.Parameters.AddWithValue("@bairro", bairro);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@nascimento", nascimento);
                        command.Parameters.AddWithValue("@residencial", residencial);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.Parameters.AddWithValue("@observacoes", observacoes);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Atualizar. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public DataTable RetornaClientePorNome(string nome)
        {
            var tabela = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT NOME, CPF, CELULAR, CIDADE, DATA_CADASTRO, ENDERECO, NASCIMENTO, BAIRRO, ");
                    sql.Append("OBSERVACOES, ID_CLIENTE, RG, RESIDENCIAL FROM Clientes ");
                    sql.Append("WHERE NOME LIKE '%' + @nome + '%' ");
                    sql.Append("ORDER BY ID_CLIENTE DESC");

                    using (SqlCommand command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            tabela.Load(reader);
                            return tabela;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornaClientePorNome. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }

        public DataTable RetornaClientePorCpf(string cpf)
        {
            var tabela = new DataTable();

            try
            {
                using (var connection = new SqlConnection(Conexao.stringConexao))
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.Append("SELECT NOME, CPF, CELULAR, CIDADE, DATA_CADASTRO, ENDERECO, NASCIMENTO, BAIRRO, ");
                    sql.Append("OBSERVACOES, ID_CLIENTE, RG, RESIDENCIAL FROM Clientes ");
                    sql.Append("WHERE CPF LIKE '%' +@cpf+ '%'");

                    using (var command = new SqlCommand(sql.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf);

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
                throw new Exception("Ocorreu um erro no método RetornaClientePorCpf. Se o erro persistir, entre em contato com o Administrador do sistema");
            }
        }
    }
}
