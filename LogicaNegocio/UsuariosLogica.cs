using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaNegocio
{
	public class UsuariosLogica
	{
		public void Validar(string nome, string login, string senha, string nivel, string status)
		{
			char[] caracteresEspeciais = { '!', '@', '#', '$', '%', '&', '*', '+', '-', '/', '=', '?', '^', '{', '}', '|', '~'};

			Regex regex = new Regex(@"[\u0300-\u036F\u00C0-\u00FC]");

			if (nome.Trim() == "")
			{
				throw new Exception("O campo Nome não pode ser vazio");
			}

			if (login.Trim() == "")
			{
				throw new Exception("O campo login não pode ser vazio");
			}

			if (regex.IsMatch(login))
			{
				throw new Exception("O login não pode conter caracteres acentuados.");
			}

			if (senha.Trim() == "")
			{
				throw new Exception("O campo senha não pode ser vazio");
			}

			if (senha.Trim().Length > 8)
			{
				throw new Exception("A senha não pode ter mais que 8 caracteres");
			}

			if (regex.IsMatch(senha))
			{
				throw new Exception("O senha não pode conter caracteres acentuados.");
			}

			foreach (char caractere in caracteresEspeciais)
			{
				if (login.Contains(caractere))
				{
					throw new Exception($"O login não pode ter o caractere especial '{caractere}'.");
				}

				if (senha.Contains(caractere))
				{
					throw new Exception($"A senha não pode ter o caractere especial '{caractere}'.");
				}
			}

			if (status != "Ativo" && status != "Inativo")
			{
				throw new Exception("Selecione um status de usuário");
			}

			if (Convert.ToInt32(nivel) <= 0)
			{
				throw new Exception("Selecione um nível de usuário");
			}
		}

		public string Criptografar(string senha)
		{
			MD5 hashMd5 = MD5.Create();

			byte[] valorCriptografado = hashMd5.ComputeHash(Encoding.Default.GetBytes(senha));

			StringBuilder strBuilder = new StringBuilder();

			for (int i = 0; i < valorCriptografado.Length; i++)
			{
				strBuilder.Append(valorCriptografado[i].ToString("x2"));
			}

			return strBuilder.ToString();
		}

		public DataTable ListarUsuarios(int idUsuario = 0)
		{
			try
			{
				var tabela = new DataTable();
				var usuarioAcesso = new UsuarioAcessoDados();

				tabela = usuarioAcesso.ListarUsuarios(idUsuario);
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable RetornaUsuario(string login, string idUsuario = "0")
		{
			try
			{
				var tabela = new DataTable();
				var usuarioAcesso = new UsuarioAcessoDados();

				tabela = usuarioAcesso.RetornaUsuario(login, Convert.ToInt32(idUsuario));
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Salvar(string nome, string login, string senha, string nivel, string status, DateTime cadastro)
		{
			try
			{
				Validar(nome, login, senha, nivel, status);

				var usuarioRetornado = RetornaUsuario(login);

				if (usuarioRetornado.Rows.Count > 0)
				{
					throw new Exception("Esse nome de usuário já existe");
				}

				string senhaCripto = Criptografar(senha);

				var usuarioAcesso = new UsuarioAcessoDados();
				usuarioAcesso.Salvar(nome.Trim(), login.Trim(), senhaCripto.Trim(), Convert.ToInt32(nivel), status, Convert.ToDateTime(cadastro));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Atualizar(string idUsuario, string nome, string login, string senha, string nivel, string status, DateTime cadastro)
		{
			try
			{
				Validar(nome, login, senha, nivel, status);

				var usuarioRetornado = RetornaUsuario(login, idUsuario);

				if (usuarioRetornado.Rows.Count > 0)
				{
					throw new Exception("Esse nome de usuário já existe");
				}

				string senhaCripto = Criptografar(senha);

				var usuarioAcesso = new UsuarioAcessoDados();
				usuarioAcesso.Atualizar(Convert.ToInt32(idUsuario), nome.Trim(), login.Trim(), senhaCripto.Trim(), Convert.ToInt32(nivel), status);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Deletar(string idUsuario)
		{
			try
			{
				var usuarioAcesso = new UsuarioAcessoDados();
				usuarioAcesso.Deletar(Convert.ToInt32(idUsuario));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable ListarNiveis()
		{
			try
			{
				var tabela = new DataTable();
				var usuarioAcesso = new UsuarioAcessoDados();

				tabela = usuarioAcesso.ListarNiveis();
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
