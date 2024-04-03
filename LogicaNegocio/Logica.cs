using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Logica
    {
        public void VerificaDados(string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, 
            string celular, string cpf)
        {
            if (nome == "")
            {
                throw new Exception("O campo Nome não pode ser vazio");
            }

            if (endereco == "")
            {
                throw new Exception("O campo Endereco não pode ser vazio");
            }

            if (bairro == "")
            {
                throw new Exception("O campo Bairro não pode ser vazio");
            }

            if (cidade == "")
            {
                throw new Exception("O campo Cidade não pode ser vazio");
            }

            if (nascimento.Date == DateTime.Today)
            {
                throw new Exception("O campo Nascimento não pode ter a data de hoje");
            }

            if (VerificaDocumentos(rg) == false)
            {
                throw new Exception("Insira um RG válido para continuar");
            }

            if (ValidaCpf(cpf) == false)
            {
                throw new Exception("Digite um CPF válido para continuar");
            }

            VerificaTelefone(celular);
        }

        public bool VerificaDocumentos(string rg)
        {
            var rgNumeros = rg.Replace(".", "").Replace("-", "");

            if (rgNumeros != "" && rgNumeros.Length == 10)
            {
                return true;
            }

            return false;
        }

        public void VerificaTelefone(string celular)
        {
            var celularNumeros = celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (celularNumeros == "" || celularNumeros.Length != 11)
            {
                throw new Exception("É preciso preencher pelo menos o campo Celular na parte de contato");
            }
        }

        public bool ValidaCpf(string cpf) //método que deve retornar verdadeiro ou falso
        {
            try
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //Cada número armazenado nessa variável irá ser multiplicado
                                                                                  //pelos dígitos do cpf posteriormente

                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //Mesma coisa que a variável anterior mas será adicionado o primeiro
                                                                                       //dígito de verificação no cpf

                string tempCpf; //receberá os primeiros 9 dígitos do cpf
                string digito; //receberá os dígitos verificadores

                int soma; //receberá a soma dos resultados da multiplicação pelos dígitos do cpf
                int resto; //receberá o resto da soma dividida por 11

                cpf = cpf.Trim(); //remove espaços em branco
                cpf = cpf.Replace(".", "").Replace("-", ""); //pega só os números do cpf
                
                if (cpf.Length != 11)
                {
                    return false;
                }

                tempCpf = cpf.Substring(0, 9); //atribuindo o valor dos 9 primeiros dígitos do cpf
                soma = 0; //"limpando" a variável para uma nova operação

                for (int i = 0; i < 9; i++) //irá repetir o código 9 vezes para pegar cada dígito do cpf e multiplicar por cada número do array
                                            //multiplicador 1
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i]; //atribuindo o valor soma + cada produto da operação realizada
                }
                resto = soma % 11; //atribuindo o resto da divisão da soma por 11

                if (resto < 2) //caso o resto seja menor que dois, o primeiro dígito verificador deve ser 0
                {
                    resto = 0;
                }
                else //caso contrário, deve ser subtraído o resultado de 'resto' por 11
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString(); //atribuindo o primeiro dígito verificador

                tempCpf = tempCpf + digito; //adicionando o primeiro dígito verificador no cpf
                soma = 0; //"limpando" a variável para uma nova operação


                // Mesma operação anterior só que dessa vez com um número a mais
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }
                resto = soma % 11;
                
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString(); //adicionando o segundo digíto verificador (EX: se o cpf fosse '123.456.789-10', ao passar por toda
                                                    //essa operação, o digíto armazenado nessa variável seria 09)
                return cpf.EndsWith(digito); // Verifica se o cpf tem os dois digítos verificadores
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ValidaCpf. Caso o problema persista, entre em contato como Administrador");
            }
        }

        public void Salvar(string nome, string rg, string cpf, string endereco, string bairro, string cidade,
            DateTime nascimento, string residencial, string celular, string observacoes, DateTime cadastro)
        {
            try
            {
                ClienteAcessoDados clienteAcesso = new ClienteAcessoDados();

                VerificaDados(nome, endereco, bairro, cidade, nascimento, rg, celular, cpf);
                clienteAcesso.Salvar(nome, rg, cpf, endereco, bairro, cidade, nascimento, residencial, celular, observacoes, cadastro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(int idCliente, string nome, string rg, string cpf, string endereco, string bairro, string cidade,
            DateTime nascimento, string residencial, string celular, string observacoes)
        {
            ClienteAcessoDados clienteAcesso = new ClienteAcessoDados();
            VerificaDados(nome, endereco, bairro, cidade, nascimento, rg, celular, cpf);
            clienteAcesso.Atualizar(idCliente, nome, rg, cpf, endereco, bairro, cidade, nascimento, residencial, celular, observacoes);
        }

        public void Excluir(int idCliente)
        {
            try
            {
                ClienteAcessoDados clienteAcesso = new ClienteAcessoDados();
                clienteAcesso.Excluir(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarClientes()
        {
            try
            {
                var tabela = new DataTable();

                var clienteAcesso = new ClienteAcessoDados();

                tabela = clienteAcesso.ListarClientes();

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornaClientePorNome(string nome)
        {
            try
            {
                var tabela = new DataTable();

                var clienteAcesso = new ClienteAcessoDados();

                tabela = clienteAcesso.RetornaClientePorNome(nome);

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornaClientePorCpf(string cpf)
        {
            var tabela = new DataTable();
            var clienteAcesso = new ClienteAcessoDados();

            tabela = clienteAcesso.RetornaClientePorCpf(cpf);
            return tabela;
        }
    }
}