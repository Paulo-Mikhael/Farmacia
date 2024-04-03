using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmInicial : Form
    {
        int IdUsuario;
		public frmInicial(int idUsuario)
		{
			InitializeComponent();
			IdUsuario = idUsuario;
		}

		private void frmInicial_Load(object sender, EventArgs e)
        {
			var usuarioAcesso = new UsuariosLogica();
			var tabela = usuarioAcesso.ListarUsuarios(IdUsuario);

			var loginUsuario = tabela.Rows[0]["LOGIN_USUARIO"].ToString();
			var nivelUsuario = tabela.Rows[0]["NivelUsuario"].ToString();

			MessageBox.Show($"Olá {loginUsuario}! Bem vindo ao sistema de controle de farmácia", "Bem vindo!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            VerificaNivelUsuario(nivelUsuario);
			CarregaDadosUsuario();
        }

        private void VerificaNivelUsuario(string nivelUsuario)
        {
            try
            {
                switch (nivelUsuario)
                {
                    case "Gerente":
						btnClientes.Enabled = true;
						btnProdutos.Enabled = true;
						btnUsuarios.Enabled = false;
						break;
                    case "Funcionário":
						btnClientes.Enabled = false;
						btnProdutos.Enabled = true;
						btnUsuarios.Enabled = false;
						break;
                    case "Fornecedor":
						btnClientes.Enabled = false;
						btnProdutos.Enabled = true;
						btnUsuarios.Enabled = false;
						break;
					default:
                        btnClientes.Enabled = true;
                        btnProdutos.Enabled = true;
                        btnUsuarios.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaDadosUsuario()
        {
			try
			{
                var usuarioAcesso = new UsuariosLogica();
                var tabela = usuarioAcesso.ListarUsuarios(IdUsuario);

                var nomeUsuario = tabela.Rows[0]["NOME"].ToString();
                var loginUsuario = tabela.Rows[0]["LOGIN_USUARIO"].ToString();
                var nivelUsuario = tabela.Rows[0]["NivelUsuario"].ToString();

                tsNomeUsuario.Text = nomeUsuario;
                tsLoginUsuario.Text = loginUsuario;
                tsNivelUsuario.Text = nivelUsuario;
                tsData.Text = DateTime.Today.ToShortDateString();
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var clientes = new frmPrincipal();
            clientes.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var produtos = new frmProdutos();
            produtos.ShowDialog();
        }

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
            var usuarios = new frmUsuarios();
            usuarios.ShowDialog();
		}

		private void tsNivelUsuario_Click(object sender, EventArgs e)
		{

		}

		private void ssDadosUsuario_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
            var login = new frmLogin();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
				IdUsuario = login.IdUsuario;
				this.OnLoad(e);
			}
		}

		private void relogio_Tick(object sender, EventArgs e)
		{
            tsRelogio.Text = DateTime.Now.ToLongTimeString();
		}

		private void tsRelogio_Click(object sender, EventArgs e)
		{

		}

		private void btnVendas_Click(object sender, EventArgs e)
		{
			var usuarioAcesso = new UsuariosLogica();
			var tabela = usuarioAcesso.ListarUsuarios(IdUsuario);

			var loginUsuario = tabela.Rows[0]["LOGIN_USUARIO"].ToString();
			frmVendas vendas = new frmVendas(IdUsuario, loginUsuario);
            vendas.ShowDialog();
		}
	}
}
