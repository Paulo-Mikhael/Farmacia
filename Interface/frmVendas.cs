using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
	public partial class frmVendas : Form
	{
		int IdUsuario;
		string LoginUsuario;

		public static string nomeCliente = "";
		public static string codBarrasProduto = "";
		public static int quantidadeProduto;

		MessageBoxes message = new MessageBoxes();
		public frmVendas(int idUsuario, string loginUsuario)
		{
			InitializeComponent();
			IdUsuario = idUsuario;
			LoginUsuario = loginUsuario;
		}
		private void frmVendas_Load(object sender, EventArgs e)
		{
			var usuariosLogica = new UsuariosLogica();

			var nomeUsuario = usuariosLogica.RetornaUsuario(LoginUsuario);
			lbUsuario.Text = nomeUsuario.Rows[0]["LOGIN_USUARIO"].ToString();
			ListarDetalhesDaVenda();

			if (codBarrasProduto != "")
			{
				AdicionarProduto(codBarrasProduto, quantidadeProduto);
				codBarrasProduto = "";
			}

			if (nomeCliente != "")
			{
				lbNomeCliente.Text = nomeCliente;

				var logica = new Logica();
				nomeCliente = "";
				btnRemoverCliente.Visible = true;
			}
			else
			{
				lbNomeCliente.Text = "Não informado para esta venda";
				btnRemoverCliente.Visible = false;
			}
		}

		private void AdicionarProduto(string codBarras, int quantidade)
		{
			for (int i = 0; i < quantidade; i++)
			{
				tbProduto.Text = codBarras;
			}
		}

		private void Estilo()
		{
			var linhas = dtgDetalhesVenda.Rows.Count;
			for (int i = 0; i < linhas; i += 2)
			{
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaNomeProduto"].Style.BackColor = Color.LightSteelBlue;
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaDetalhesProduto"].Style.BackColor = Color.LightSteelBlue;
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaCodBarras"].Style.BackColor = Color.LightSteelBlue;
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaValorUnitario"].Style.BackColor = Color.LightSteelBlue;
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaQuantidade"].Style.BackColor = Color.LightSteelBlue;
				dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaSubtotal"].Style.BackColor = Color.LightSteelBlue;
			}
		}

		private void EsconderLabels()
		{
			lbNomeProduto.Visible = false;
			lbDescricaoProduto.Visible = false;
			lbQuantidadeProduto.Visible = false;
			lbPrecoProduto.Visible = false;
			lbTotalProduto.Visible = false;
		}

		private void MostrarLabels()
		{
			lbNomeProduto.Visible = true;
			lbDescricaoProduto.Visible = true;
			lbQuantidadeProduto.Visible = true;
			lbPrecoProduto.Visible = true;
			lbTotalProduto.Visible = true;
		}

		public bool VerificaEstoque(string codBarras, int quantidade)
		{
			var produtosLogica = new ProdutosLogica();

			var tabelaProdutos = produtosLogica.RetornaProdutosPorCodigoBarras(codBarras, "...");

			var produtoEstoque = tabelaProdutos.Rows[0]["ESTOQUE_ATUAL"].ToString();

			int novoEstoque = Convert.ToInt32(produtoEstoque) - quantidade;

			if (novoEstoque <= 0)
			{
				return false;
			}

			return true;
		}

		private void AtualizaSubtotal()
		{
			decimal valorTotal = 0;

			var linhas = dtgDetalhesVenda.Rows.Count;
			for (int i = 0; i < linhas; i++)
			{
				var valorUnitario = Convert.ToDecimal(dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaValorUnitario"].Value.ToString());
			    var quantidade = Convert.ToDecimal(dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaQuantidade"].Value.ToString());

				var subtotal = dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaSubtotal"];

				subtotal.Value = Convert.ToString(valorUnitario * quantidade);

				valorTotal += Convert.ToDecimal(subtotal.Value);
			}
			
			lbSubtotal.Text = "R$ " + Convert.ToString(valorTotal);
		}

		private bool VerificaNomeProduto(string nomeProduto)
		{
			var linhas = dtgDetalhesVenda.Rows.Count;

			for (int i = 0; i < linhas; i++)
			{
				if (dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaNomeProduto"].Value.ToString() == nomeProduto)
				{
					return true;
				}
			}

			return false;
		}

		private void AtualizaEstoque()
		{
			try
			{
				var produtosLogica = new ProdutosLogica();

				var linhas = dtgDetalhesVenda.Rows.Count;

				for (int i = 0; i < linhas; i++)
				{
					var codBarras = dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaCodBarras"].Value.ToString();
					var quantidade = dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaQuantidade"].Value.ToString();

					var tabelaProdutos = produtosLogica.RetornaProdutosPorCodigoBarras(codBarras, "...");

					var produtoEstoque = tabelaProdutos.Rows[0]["ESTOQUE_ATUAL"].ToString();
					var produtoId = tabelaProdutos.Rows[0]["ID_PRODUTO"].ToString();

					string novoEstoque = Convert.ToString(Convert.ToInt32(produtoEstoque) - Convert.ToInt32(quantidade));

					produtosLogica.AtualizaEstoque(produtoId, novoEstoque);
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private int RetornaQuantidadeProduto(string nomeProduto)
		{
			var linhas = dtgDetalhesVenda.Rows.Count;

			for (int i = 0; i < linhas; i++)
			{
				var quantidade = dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaQuantidade"].Value.ToString();

				if (dtgDetalhesVenda.Rows[i].Cells["dtgDetalhesVendaNomeProduto"].Value.ToString() == nomeProduto)
				{
					return Convert.ToInt32(quantidade);
				}
			}

			return 1;
		}

		public void ListarDetalhesDaVenda()
		{
			try
			{
				var vendasLogica = new VendasLogica();
				dtgDetalhesVenda.DataSource = vendasLogica.ListarDetalhesDaVenda();
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void tbProduto_TextChanged(object sender, EventArgs e)
		{
			try
			{
				var produtosLogica = new ProdutosLogica();
				var tabela = produtosLogica.RetornaProdutosPorCodigoBarras(tbProduto.Text, "...");

				if (tabela.Rows.Count > 0)
				{
					var idProduto = tabela.Rows[0]["ID_PRODUTO"].ToString();
					var nomeProduto = tabela.Rows[0]["NOME"].ToString();
					var detalhesProduto = tabela.Rows[0]["DETALHES"].ToString();
					var valorVenda = tabela.Rows[0]["VALOR_VENDA"].ToString();
					var estoque = tabela.Rows[0]["ESTOQUE_ATUAL"].ToString();
					var estoqueMinimo = tabela.Rows[0]["ESTOQUE_MINIMO"].ToString();
					var codBarras = tabela.Rows[0]["CODIGO_BARRAS"].ToString();

					if (VerificaEstoque(codBarras, RetornaQuantidadeProduto(nomeProduto)) == true)
					{
						MostrarLabels();

						lbNomeProduto.Text = nomeProduto;
						lbDescricaoProduto.Text = detalhesProduto;
						lbPrecoProduto.Text = valorVenda;

						var vendasLogica = new VendasLogica();

						if (VerificaNomeProduto(nomeProduto) == false)
						{
							lbQuantidadeProduto.Text = "1";
							vendasLogica.AdicionarDetalhesVenda(idProduto, lbQuantidadeProduto.Text);
						}
						else
						{
							lbQuantidadeProduto.Text = Convert.ToString(RetornaQuantidadeProduto(nomeProduto) + 1);
							vendasLogica.AtualizaDetalhesDaVendaQuantidade(idProduto, lbQuantidadeProduto.Text);
						}

						lbTotalProduto.Text = Convert.ToString(Convert.ToDecimal(valorVenda) * Convert.ToDecimal(lbQuantidadeProduto.Text));

						tbProduto.Clear();

						ListarDetalhesDaVenda();
						AtualizaSubtotal();
						Estilo();
					}
					else
					{
						message.MboxAviso($"Produto '{nomeProduto}' de ID {idProduto} fora de estoque. Estoque atual: {estoque}.", "Fora de estoque");
					}
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dtgDetalhesVenda.Rows.Count > 0)
				{
					var confirmacao = message.MboxConfirmacao("Deseja cancelar essa operação de venda ?");

					if (confirmacao == DialogResult.Yes)
					{
						var logica = new Logica();
						int idCliente;

						if (nomeCliente != "")
						{
							var tabela = logica.RetornaClientePorNome(nomeCliente);
							var idClienteTabela = tabela.Rows[0]["ID_CLIENTE"].ToString();

							idCliente = Convert.ToInt32(idClienteTabela);
						}
						else
						{
							idCliente = 0;
						}

						var vendasLogica = new VendasLogica();
						vendasLogica.AdicionarVenda(IdUsuario, idCliente, DateTime.Now, "Cancelada", lbSubtotal.Text.Substring(3));

						var tabelaVendas = vendasLogica.ListarVendas();

						vendasLogica.AtualizaDetalhesDaVendaIdVenda(tabelaVendas.Rows[0]["ID_VENDA"].ToString());

						this.Close();
					}
				}
				else
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void btnFinalizar_Click(object sender, EventArgs e)
		{

			try
			{
				if (dtgDetalhesVenda.Rows.Count > 0)
				{
					var confirmacao = message.MboxConfirmacao("Deseja finalizar essa operação de venda ?");

					if (confirmacao == DialogResult.Yes)
					{
						var logica = new Logica();
						int idCliente;

						if (nomeCliente != "")
						{
							var tabela = logica.RetornaClientePorNome(nomeCliente);
							var idClienteTabela = tabela.Rows[0]["ID_CLIENTE"].ToString();

							idCliente = Convert.ToInt32(idClienteTabela);
						}
						else
						{
							idCliente = 0;
						}

						var vendasLogica = new VendasLogica();
						vendasLogica.AdicionarVenda(IdUsuario, idCliente, DateTime.Now, "Finalizada", lbSubtotal.Text.Substring(3));

						var tabelaVendas = vendasLogica.ListarVendas();

						vendasLogica.AtualizaDetalhesDaVendaIdVenda(tabelaVendas.Rows[0]["ID_VENDA"].ToString());
						AtualizaEstoque();

						message.MboxInfo($"Venda finalizada com sucesso! Total: {lbSubtotal.Text}");
						this.Close();
					}
				}
				else
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void dtgDetalhesVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var tabela = dtgDetalhesVenda;
				message.VerificaLinhas(tabela);

				var produtosLogica = new ProdutosLogica();
				var vendasLogica = new VendasLogica();

				var codBarras = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaCodBarras"].Value.ToString();
				var idProduto = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaIdProduto"].Value.ToString();
				var quantidadeProduto = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaQuantidade"].Value.ToString();

				var nomeProduto = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaNomeProduto"].Value.ToString();
				var detalhesProduto = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaDetalhesProduto"].Value.ToString();
				var valorUnitario = dtgDetalhesVenda.Rows[e.RowIndex].Cells["dtgDetalhesVendaValorUnitario"].Value.ToString();

				var novaQuantidade = Convert.ToString(Convert.ToInt32(quantidadeProduto) - 1);

				if (dtgDetalhesVenda.Columns[e.ColumnIndex].Name == "btnDetalhesVendasMenosUm")
				{
					if (Convert.ToInt32(quantidadeProduto) > 1)
					{
						vendasLogica.AtualizaDetalhesDaVendaQuantidade(idProduto, novaQuantidade);

						MostrarLabels();

						lbNomeProduto.Text = nomeProduto;
						lbDescricaoProduto.Text = detalhesProduto;
						lbPrecoProduto.Text = valorUnitario;
						lbQuantidadeProduto.Text = novaQuantidade;

						lbTotalProduto.Text = Convert.ToString(Convert.ToDecimal(valorUnitario) * Convert.ToDecimal(lbQuantidadeProduto.Text));
					}
					else
					{
						vendasLogica.RemoverDetalheDaVenda(idProduto);
						EsconderLabels();
					}
				}
				else if (dtgDetalhesVenda.Columns[e.ColumnIndex].Name == "btnDetalhesVendasRemover")
				{
					vendasLogica.RemoverDetalheDaVenda(idProduto);
					EsconderLabels();
				}

				ListarDetalhesDaVenda();
				AtualizaSubtotal();
				Estilo();
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void Relogio_Tick(object sender, EventArgs e)
		{
			lbData.Text = DateTime.Now.ToShortDateString();
		}

		private void btnDigitarCod_Click(object sender, EventArgs e)
		{
			var pesquisa = new frmPesquisarProdutos(IdUsuario, LoginUsuario);
			var produtos = new ProdutosLogica();

			pesquisa.ShowDialog();
			this.OnLoad(e);
		}

		private void lbNomeCliente_Click(object sender, EventArgs e)
		{

		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			var frmCliente = new frmPesquisaClientes(IdUsuario, LoginUsuario);
			frmCliente.ShowDialog();
			this.OnLoad(e);
		}

		private void btnRemoverCliente_Click(object sender, EventArgs e)
		{
			nomeCliente = "";
			lbNomeCliente.Text = "Não informado para esta venda";
			btnRemoverCliente.Visible = false;
		}
	}
}
