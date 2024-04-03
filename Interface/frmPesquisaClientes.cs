using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
	public partial class frmPesquisaClientes : Form
	{
		int IdUsuario;
		string LoginUsuario;
		public frmPesquisaClientes(int idUsuario, string loginUsuario)
		{
			InitializeComponent();
			IdUsuario = idUsuario;
			LoginUsuario = loginUsuario;
		}

		private void frmPesquisaClientes_Load(object sender, EventArgs e)
		{
			var message = new MessageBoxes();
			try
			{
				var clienteLogica = new Logica();
				dtgClientes.DataSource = clienteLogica.ListarClientes();

				message.VerificaLinhas(dtgClientes);

				var nomeCliente = dtgClientes.Rows[dtgClientes.CurrentCell.RowIndex].Cells["dtgNomeCliente"].Value.ToString();

				btnAdicionar.Text = $"Adicionar o cliente: {nomeCliente}";
			}
			catch (Exception ex)
			{
				message.MboxErro(ex.Message);
			}
		}

		private void tbProduto_TextChanged(object sender, EventArgs e)
		{
			var clienteLogica = new Logica();
			
			if (rbNome.Checked == true)
			{
				dtgClientes.DataSource = clienteLogica.RetornaClientePorNome(tbProduto.Text);
			}
			else if (rbCpf.Checked == true)
			{
				dtgClientes.DataSource = clienteLogica.RetornaClientePorCpf(tbProduto.Text);
			}
			else
			{
				MessageBox.Show("Selecione uma opção de pesquisa", "Selecione uma opção", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			if (dtgClientes.Rows.Count > 0)
			{
				btnAdicionar.Enabled = true;

				var nomeCliente = dtgClientes.Rows[dtgClientes.CurrentCell.RowIndex].Cells["dtgNomeCliente"].Value.ToString();

				btnAdicionar.Text = $"Adicionar o cliente: {nomeCliente}";
			}
			else
			{
				btnAdicionar.Enabled = false;
			}

			if (tbProduto.Text == "")
			{
				dtgClientes.DataSource = clienteLogica.ListarClientes();
			}
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			var nomeCliente = dtgClientes.Rows[dtgClientes.CurrentCell.RowIndex].Cells["dtgNomeCliente"].Value.ToString();
			var frmVendas = new frmVendas(IdUsuario, LoginUsuario);

			frmVendas.nomeCliente = nomeCliente;
			this.Close();
		}

		private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtgClientes.Rows.Count > 0)
			{
				btnAdicionar.Enabled = true;

				var nomeCliente = dtgClientes.Rows[dtgClientes.CurrentCell.RowIndex].Cells["dtgNomeCliente"].Value.ToString();

				btnAdicionar.Text = $"Adicionar o cliente: {nomeCliente}";
			}
			else
			{
				btnAdicionar.Enabled = false;
			}
		}
	}
}
