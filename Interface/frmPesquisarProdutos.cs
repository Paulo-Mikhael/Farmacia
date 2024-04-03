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
	public partial class frmPesquisarProdutos : Form
	{
		MessageBoxes message = new MessageBoxes();
		int IdUsuario;
		string LoginUsuario;
		public frmPesquisarProdutos(int idUsuario, string loginUsuario)
		{
			InitializeComponent();
			IdUsuario = idUsuario;
			LoginUsuario = loginUsuario;
		}

		private void frmPesquisarProdutos_Load(object sender, EventArgs e)
		{
			ListarProdutos();
		}

		private void ListarProdutos()
		{
			try
			{
				var produtoAcesso = new ProdutosLogica();
				dtgProdutos.DataSource = produtoAcesso.ListarProdutos();
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
				var produtoAcesso = new ProdutosLogica();
				dtgProdutos.DataSource = produtoAcesso.RetornaProdutosPorCodigoBarras(tbProduto.Text);
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			try
			{
				message.VerificaLinhas(dtgProdutos);

				if (dtgProdutos.CurrentCell != null)
				{
					var frmVendas = new frmVendas(IdUsuario, LoginUsuario);

					var codBarras = dtgProdutos.Rows[dtgProdutos.CurrentCell.RowIndex].Cells["dtgProdutosCodigoBarras"].Value.ToString();
					var estoque = Convert.ToInt32(dtgProdutos.Rows[dtgProdutos.CurrentCell.RowIndex].Cells["dtgProdutosEstoqueAtual"].Value.ToString());
					var nome = dtgProdutos.Rows[dtgProdutos.CurrentCell.RowIndex].Cells["dtgProdutosNome"].Value.ToString();

					int quantidadeVenda = Convert.ToInt32(tbQuantidade.Text);
					int quantidade = estoque - quantidadeVenda;

					if (quantidade >= 0)
					{
						frmVendas.quantidadeProduto = quantidadeVenda;
						frmVendas.codBarrasProduto = codBarras;
						this.Close();
					}
					else
					{
						message.MboxAviso($"Produto {nome} excedeu o estoque", "Fora de estoque");
					}
				}
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
				throw;
			}
		}

		private void tbQuantidade_Leave(object sender, EventArgs e)
		{
			if (tbQuantidade.Text == "")
			{
				tbQuantidade.Text = "1";
			}
		}
	}
}
