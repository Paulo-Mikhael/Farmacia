using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
	public partial class frmUsuarios : Form
	{
		MessageBoxes message = new MessageBoxes();

		public frmUsuarios()
		{
			InitializeComponent();
		}

		private void frmUsuarios_Load(object sender, EventArgs e)
		{
			ListarUsuarios();
			ListarNiveis();
		}

		private void ListarNiveis()
		{
			var usuarioLogica = new UsuariosLogica();
			cbNivel.DisplayMember = "NOME";
			cbNivel.ValueMember = "ID_NIVEL";
			cbNivel.DataSource = usuarioLogica.ListarNiveis();
			cbNivel.SelectedIndex = -1;
		}

		private void Estilo()
		{
			var linhas = dtgUsuarios.Rows.Count;

			for (int i = 0; i < linhas; i+=2)
			{
				dtgUsuarios.Rows[i].Cells["dtgUsuariosLogin"].Style.BackColor = Color.LightSteelBlue;
				dtgUsuarios.Rows[i].Cells["dtgUsuariosNomeNivel"].Style.BackColor = Color.LightSteelBlue;
				dtgUsuarios.Rows[i].Cells["dtgUsuariosStatus"].Style.BackColor = Color.LightSteelBlue;
			}
		}

		private void ListarUsuarios()
		{
			try
			{
				var usuarioLogica = new UsuariosLogica();
				dtgUsuarios.DataSource = usuarioLogica.ListarUsuarios();
				Estilo();
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void AtualizarFormulario()
		{
			ListarUsuarios();
			LimparCamposCadastro();
			cbNivel.SelectedIndex = -1;
		}

		private void AtualizarDtp()
		{
			dtpCadastro.Value = DateTime.Today;
		}

		private void LimparCamposCadastro()
		{
			AtualizarDtp();

			tbCodigo.Clear();
			tbNome.Clear();
			tbLogin.Clear();
			tbSenha.Clear();
			tbReSenha.Clear();

			tbCodigo.Enabled = false;
			tbNome.Enabled = false;
			tbLogin.Enabled = false;
			tbSenha.Enabled = false;
			tbReSenha.Enabled = false;
			cbNivel.Enabled = false;
			cbStatus.Enabled = false;
			dtpCadastro.Enabled = false;

			lbCadastro.Enabled = false;
			lbCodigo.Enabled = false;
			lbNome.Enabled = false;
			lbLogin.Enabled = false;
			lbSenha.Enabled = false;
			lbReSenha.Enabled = false;
			lbNivel.Enabled = false;
			lbStatus.Enabled = false;

			cbStatus.SelectedIndex = -1;
		}

		private void HabilitarCamposCadastro()
		{
			AtualizarDtp();

			tbNome.Enabled = true;
			tbLogin.Enabled = true;
			tbSenha.Enabled = true;
			tbReSenha.Enabled = true;
			cbNivel.Enabled = true;
			cbStatus.Enabled = true;

			lbCadastro.Enabled = true;
			lbCodigo.Enabled = true;
			lbNome.Enabled = true;
			lbLogin.Enabled = true;
			lbSenha.Enabled = true;
			lbReSenha.Enabled = true;
			lbNivel.Enabled = true;
			lbStatus.Enabled = true;

			cbStatus.SelectedIndex = -1;
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			AtualizarFormulario();
			HabilitarCamposCadastro();

			tbCodigo.Text = "0";
			tbNome.Focus();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			var tabela = dtgUsuarios;
			var codigo = tbCodigo.Text;
			var nome = tbNome.Text;
			var senha = tbSenha.Text;
			var reSenha = tbReSenha.Text;
			var login = tbLogin.Text.Replace(" ", "");
			var nivel = Convert.ToString(cbNivel.SelectedValue);
			var status = cbStatus.Text;
			var cadastro = dtpCadastro.Value;

			try
			{
				if (codigo == "")
				{
					message.VerificaLinhas(tabela);
				}

				if (codigo == "")
				{
					message.MboxErro("Clique em adicionar ou no botão de editar para salvar as alterações de um usuário");
				}
				else if (codigo != "0")
				{
					if (senha != reSenha)
					{
						message.MboxErro("As senhas não combinam");
					}
					else
					{
						var usuarioLogica = new UsuariosLogica();

						usuarioLogica.Atualizar(codigo, nome, login, senha, nivel, status, cadastro);
						message.MboxInfo("Dados alterados");

						AtualizarFormulario();
					}
				}
				else
				{
					if (senha != reSenha)
					{
						message.MboxErro("As senhas não combinam");
					}
					else
					{
						var usuarioLogica = new UsuariosLogica();
						usuarioLogica.Salvar(nome, login, senha, nivel, status, cadastro);
						message.MboxInfo("Usuário salvo");

						AtualizarFormulario();
					}
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void tbLogin_Leave(object sender, EventArgs e)
		{
			var loginSemEspaco = tbLogin.Text.Replace(" ", "");
			tbLogin.Text = loginSemEspaco;
		}

		private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var tabela = dtgUsuarios;
				message.VerificaLinhas(tabela);

				var codigo = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosIdUsuario"].Value.ToString();
				var nome = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosNome"].Value.ToString();
				var senha = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosSenha"].Value.ToString();
				var login = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosLogin"].Value.ToString();
				var nivel = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosNivel"].Value.ToString();
				var status = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosStatus"].Value.ToString();
				var cadastro = dtgUsuarios.Rows[e.RowIndex].Cells["dtgUsuariosCadastro"].Value.ToString();

				var usuarioLogica = new UsuariosLogica();
				var tabelaUsuario = new DataTable();

				if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnUsuariosEditar")
				{
					HabilitarCamposCadastro();

					tbCodigo.Text = codigo;
					tbNome.Text = nome;
					tbLogin.Text = login;
					cbNivel.SelectedValue = nivel;
					cbStatus.Text = status;
					dtpCadastro.Value = Convert.ToDateTime(cadastro);

					tbSenha.Text = senha.Substring(0, 8);
					tbReSenha.Text = senha.Substring(0, 8);
				}
				else if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnUsuariosExcluir")
				{
					if (codigo != "" && codigo != "0")
					{
						var confirmacao = message.MboxConfirmacao($"Deseja excluir o usuário: {login}, de id {codigo}?");

						if (confirmacao == DialogResult.Yes)
						{
							usuarioLogica.Deletar(codigo);
							AtualizarFormulario();
						}
						else
						{
							message.MboxInfo("Operação de excluir cancelada", "Operação cancelada pelo usuário");
						}
					}
					else
					{
						message.MboxErro("Selecione um usuário para excluir");
					}
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			var tabela = dtgUsuarios;
			var login = tbLogin.Text;
			var codigo = tbCodigo.Text;

			try
			{
				if (codigo == "")
				{
					message.VerificaLinhas(tabela);
				}

				if (codigo != "" && codigo != "0")
				{
					var confirmacao = message.MboxConfirmacao($"Deseja excluir o usuário: {login}, de id {codigo}?");

					if (confirmacao == DialogResult.Yes)
					{
						var usuarioLogica = new UsuariosLogica();
						usuarioLogica.Deletar(codigo);
						AtualizarFormulario();
					}
					else
					{
						message.MboxInfo("Operação de excluir cancelada", "Operação cancelada pelo usuário");
					}
				}
				else
				{
					message.MboxErro("Selecione um usuário para excluir");
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}
	}
}
