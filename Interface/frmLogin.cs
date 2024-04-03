using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmLogin : Form
    {
        MessageBoxes message = new MessageBoxes();
        public int IdUsuario = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
			var usuarioLogica = new UsuariosLogica();
            var login = tbUsuario.Text;
			var senhaCadastro = usuarioLogica.Criptografar(tbSenha.Text);

			try
            {
				var tabela = usuarioLogica.RetornaUsuario(login);

				if (login.Trim() == "" || senhaCadastro.Trim() == "")
				{
					throw new Exception("Preencha todos os campos de cadastro");
				}
				else if (tabela.Rows.Count > 0)
				{
					string status = tabela.Rows[0]["STATUS_USUARIO"].ToString();

					if (status == "Inativo")
					{
						message.MboxErro($"Status de usuário é {status}", "Erro de login");
					}
					else
					{
						var usuario = tabela.Rows[0]["LOGIN_USUARIO"].ToString();
						var senha = tabela.Rows[0]["SENHA_USUARIO"].ToString();

						if (login.Replace(" ", "") == usuario && senha.Replace(" ", "") == senhaCadastro)
						{
							IdUsuario = Convert.ToInt32(tabela.Rows[0]["ID_USUARIO"].ToString());

							if (IdUsuario == 0)
							{
								message.MboxErro("Ocorreu um erro ao pegar o id de usuário. Se o erro persistir entre em contato com o Administrador so sistema",
									"Não foi possível realizar o login");
							}
							else
							{
								this.DialogResult = DialogResult.OK;
							}
						}
						else
						{
							message.MboxErro("Usuário ou senha inválidos", "Erro de login");
						} 
					}
				}
				else
				{
					message.MboxErro("Nome de usuário não registrado", "Erro de cadastro");
				}
			}
            catch (Exception ex)
            {
				message.MboxErro(ex.Message);
            }
		}

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void tbUsuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				btnEntrar_Click(sender, e);
			}
		}

		private void btnMostraSenha_Click(object sender, EventArgs e)
		{
			tbSenha.PasswordChar = '*';
			btnMostraSenha.Visible = false;
			btnEscondeSenha.Visible = true;
		}

		private void btnEscondeSenha_Click(object sender, EventArgs e)
		{
			tbSenha.PasswordChar = '\0';
			btnMostraSenha.Visible = true;
			btnEscondeSenha.Visible = false;
		}
	}
}
