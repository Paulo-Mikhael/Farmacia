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
    public partial class frmProdutos : Form
    {
        MessageBoxes message = new MessageBoxes();
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
			var categoriaLogica = new CategoriasLogica();
			var tabela = categoriaLogica.ListarCategorias();

			if (tabela.Rows.Count <= 0)
			{
				var categorias = new frmCategorias(this);
                message.MboxInfo("Não existem categorias, adicione uma para cadastrar um produto", "Erro de dados");
				categorias.ShowDialog();
			}
			else
			{
				ListarCategorias();
			}

			cbCategoria.SelectedIndex = -1;
			ListarProdutos();
			ListarProdutosEstoqueBaixo();
		}

        public void AtualizarDtp()
        {
            dtpCadastro.Value = DateTime.Today;
        }

        private void HabilitarCadastro()
        {
            tbValorVenda.BackColor = Color.White;
            tbValorCompra.BackColor = Color.White;
            tbCodigo.BackColor = Color.White;

            lbCodigo.Enabled = true;
            lbNome.Enabled = true;
            lbCodigoBarras.Enabled = true;
            lbCadastro.Enabled = true;
            lbCategoria.Enabled = true;
            lbDetalhes.Enabled = true;

            tbNome.Enabled = true;
            tbCodigoBarras.Enabled = true;
            tbDetalhes.Enabled = true;
            gbEstoque.Enabled = true;
            gbValores.Enabled = true;
            cbCategoria.Enabled = true;
            AtualizarDtp();
        }

        private void LimparCadastro()
        {
            tbValorCompra.BackColor = Color.White;
            tbValorVenda.BackColor = Color.White;
            tbCodigo.BackColor = Color.White;

            lbCodigo.Enabled = false;
            lbNome.Enabled = false;
            lbCodigoBarras.Enabled = false;
            lbCadastro.Enabled = false;
            lbCategoria.Enabled = false;
            lbDetalhes.Enabled = false;

            tbCodigo.Clear();
            tbNome.Clear();
            tbCodigoBarras.Clear();
            tbDetalhes.Clear();
            tbValorCompra.Clear();
            tbValorVenda.Clear();
            tbEstoqueAtual.Clear();
            tbEstoqueMinimo.Clear();

            tbNome.Enabled = false;
            tbCodigoBarras.Enabled = false;
            tbDetalhes.Enabled = false;
            gbEstoque.Enabled = false;
            gbValores.Enabled = false;
            cbCategoria.Enabled = false;
            AtualizarDtp();
        }

        private void Estilo()
        {
            int linhas = dtgProdutos.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                if (i % 2 == 0)
                {
                    dtgProdutos.Rows[i].Cells["dtgProdutosNome"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosDetalhes"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosCodigoBarras"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosEstoqueAtual"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosVenda"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosCadastro"].Style.BackColor = Color.LightSteelBlue;
                    dtgProdutos.Rows[i].Cells["dtgProdutosNomeCategoria"].Style.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void EstiloEstoque()
        {
            var linhas = dtgProdutosEstoque.Rows.Count;
            for (int i = 0; i < linhas; i+=2)
            {
                dtgProdutosEstoque.Rows[i].Cells["dtgProdutosEstoqueNome"].Style.BackColor = Color.LightSteelBlue;
                dtgProdutosEstoque.Rows[i].Cells["dtgProdutosEstoqueDetalhes"].Style.BackColor = Color.LightSteelBlue;
            }
        }

        public void ListarProdutos()
        {
            try
            {
                var tabela = dtgProdutos;
                var produtosLogica = new ProdutosLogica();
                tabela.DataSource = produtosLogica.ListarProdutos();
                Estilo();
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        public void ListarProdutosEstoqueBaixo()
        {
            try
            {
                var tabela = dtgProdutosEstoque;
                var produtoLogica = new ProdutosLogica();

                tabela.DataSource = produtoLogica.ListarProdutosEstoqueBaixo();
                EstiloEstoque();
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        public void ListarCategorias()
        {
            try
            {
                var categoriaLogica = new CategoriasLogica();
                cbCategoria.DisplayMember = "NOME";
                cbCategoria.ValueMember = "ID_CATEGORIA";
                cbCategoria.DataSource = categoriaLogica.ListarCategorias();
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void RetornaProdutosPorNome(string nome)
        {
            try
            {
                var produtoLogica = new ProdutosLogica();
                dtgProdutos.DataSource = produtoLogica.RetornaProdutosPorNome(nome);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void RetornaProdutosPorCategoria(string categoria)
        {
            try
            {
                var produtoLogica = new ProdutosLogica();
                dtgProdutos.DataSource = produtoLogica.RetornaProdutosPorCategoria(categoria);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void RetornaProdutosPorCodigoBarras(string codigoBarras)
        {
            try
            {
                var produtoLogica = new ProdutosLogica();
                dtgProdutos.DataSource = produtoLogica.RetornaProdutosPorCodigoBarras(codigoBarras);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tabela = dtgProdutos;
            var idProduto = tbCodigo.Text;
            var codigoBarras = tbCodigoBarras.Text;
            var nome = tbNome.Text;
            var detalhes = tbDetalhes.Text;
            var valorCompra = tbValorCompra.Text;
            var valorVenda = tbValorVenda.Text;
            var estoqueAtual = tbEstoqueAtual.Text;
            var estoqueMinimo = tbEstoqueMinimo.Text;
            var dataCadastro = dtpCadastro.Value;
            var idCategoria = Convert.ToString(cbCategoria.SelectedValue);

            try
            {
                var categorias = new CategoriasLogica();
                var tabelaCategorias = categorias.ListarCategorias();

                if (tabelaCategorias.Rows.Count <= 0)
                {
                    throw new Exception("Sem categorias de produtos registradas");
                }

                if (tbCodigo.Text == "")
                {
                    message.VerificaLinhas(tabela);
                }

                if (tbCodigo.Text == "")
                {
                    message.MboxErro("Clique em adicionar ou no botão de editar para salvar as informações de um cliente");
                }
                else if (tbCodigo.Text != "0")
                {
                    var produtosLogica = new ProdutosLogica();
                    produtosLogica.Atualizar(Convert.ToInt32(idProduto), codigoBarras, nome, detalhes, idCategoria, estoqueAtual, estoqueMinimo,
                    valorCompra, valorVenda, dataCadastro);
                    message.MboxInfo("Produto alterado com sucesso");
                    ListarProdutos();
                    ListarProdutosEstoqueBaixo();
                    LimparCadastro();
                }
                else
                {
                    var produtosLogica = new ProdutosLogica();
                    produtosLogica.Salvar(codigoBarras, nome, detalhes, idCategoria, estoqueAtual, estoqueMinimo,
                    valorCompra, valorVenda, dataCadastro);
                    message.MboxInfo("Produto salvo com sucesso");
                    ListarProdutos();
                    ListarProdutosEstoqueBaixo();
                    LimparCadastro();
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
            HabilitarCadastro();
            tbNome.Focus();
            tbCodigo.Text = "0";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                var tabela = dtgProdutos;
                if (tbCodigo.Text == "")
                {
                    message.VerificaLinhas(tabela);
                }

                if (tbCodigo.Text == "" || tbCodigo.Text == "0")
                {
                    tbCodigo.BackColor = Color.Salmon;
                    message.MboxErro("Selecione um produto para excluir", "Erro no cadastro");
                }
                else
                {
                    var confirmacao = message.MboxConfirmacao($"Deseja excluir o produto: {tbNome.Text}, de id {tbCodigo.Text}?");

                    if (confirmacao == DialogResult.Yes)
                    {
                        var produtoLogica = new ProdutosLogica();
                        produtoLogica.Excluir(Convert.ToInt32(tbCodigo.Text));
                        LimparCadastro();
                        ListarProdutos();
                    }
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var tabela = dtgProdutos;
                message.VerificaLinhas(tabela);

                var idProduto = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosIdProduto"].Value.ToString();
                var codigoBarras = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosCodigoBarras"].Value.ToString();
                var nome = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosNome"].Value.ToString();
                var detalhes = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosDetalhes"].Value.ToString();
                var valorCompra = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosCompra"].Value.ToString();
                var valorVenda = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosVenda"].Value.ToString();
                var estoqueAtual = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosEstoqueAtual"].Value.ToString();
                var estoqueMinimo = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosEstoqueMinimo"].Value.ToString();
                var dataCadastro = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosCadastro"].Value.ToString();
                var idCategoria = dtgProdutos.Rows[e.RowIndex].Cells["dtgProdutosIdCategoria"].Value.ToString();

                if (dtgProdutos.Columns[e.ColumnIndex].Name == "btnProdutosEditar")
                {
                    HabilitarCadastro();

                    tbCodigo.Text = idProduto;
                    tbNome.Text = nome;
                    tbCodigoBarras.Text = codigoBarras;
                    tbDetalhes.Text = detalhes;
                    tbValorCompra.Text = $"R$ {valorCompra}";
                    tbValorVenda.Text = $"R$ {valorVenda}";
                    tbEstoqueAtual.Text = estoqueAtual;
                    tbEstoqueMinimo.Text = estoqueMinimo;
                    dtpCadastro.Value = Convert.ToDateTime(dataCadastro);
                    cbCategoria.SelectedValue = idCategoria;
                }
                else if (dtgProdutos.Columns[e.ColumnIndex].Name == "btnProdutosExcluir")
                {
                    var produtoLogica = new ProdutosLogica();

                    var confirmacao = message.MboxConfirmacao($"Deseja excluir o produto: {nome}, de id {idProduto}?");

                    if (confirmacao == DialogResult.Yes)
                    {
                        produtoLogica.Excluir(Convert.ToInt32(idProduto));
                        LimparCadastro();
                        ListarProdutos();
                    }
                }
                else
                {
                    LimparCadastro();
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void dtgProdutosEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var tabela = dtgProdutosEstoque;
                message.VerificaLinhas(tabela);

                var idProduto = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueIdProduto"].Value.ToString();
                var codigoBarras = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueCodigoBarras"].Value.ToString();
                var nome = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueNome"].Value.ToString();
                var detalhes = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueDetalhes"].Value.ToString();
                var valorCompra = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueCompra"].Value.ToString();
                var valorVenda = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueVenda"].Value.ToString();
                var estoqueAtual = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueEstoqueAtual"].Value.ToString();
                var estoqueMinimo = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueEstoqueMinimo"].Value.ToString();
                var dataCadastro = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueCadastro"].Value.ToString();
                var idCategoria = dtgProdutosEstoque.Rows[e.RowIndex].Cells["dtgProdutosEstoqueIdCategoria"].Value.ToString();

                HabilitarCadastro();

                tbCodigo.Text = idProduto;
                tbNome.Text = nome;
                tbCodigoBarras.Text = codigoBarras;
                tbDetalhes.Text = detalhes;
                tbValorCompra.Text = $"R$ {valorCompra}";
                tbValorVenda.Text = $"R$ {valorVenda}";
                tbEstoqueAtual.Text = estoqueAtual;
                tbEstoqueMinimo.Text = estoqueMinimo;
                cbCategoria.SelectedValue = idCategoria;
                dtpCadastro.Value = Convert.ToDateTime(dataCadastro);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

			var categorias = new frmCategorias(this);
			categorias.ShowDialog();
        }

        private void tbValorCompra_Leave(object sender, EventArgs e)
        {
            string textNormalizado = tbValorCompra.Text.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
            if (textNormalizado != "" && decimal.TryParse(textNormalizado, out decimal precoDecimal))
            {
                tbValorCompra.Text = $"R$ {Convert.ToString(precoDecimal)}";
                tbValorCompra.BackColor = Color.White;
            }
            else
            {
                tbValorCompra.BackColor = Color.Salmon;
            }
        }

        private void tbValorVenda_Leave(object sender, EventArgs e)
        {
            string textNormalizado = tbValorVenda.Text.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
            if (textNormalizado != "" && decimal.TryParse(textNormalizado, out decimal precoDecimal))
            {
                tbValorVenda.Text = $"R$ {Convert.ToString(precoDecimal)}";
                tbValorVenda.BackColor = Color.White;
            }
            else
            {
                tbValorVenda.BackColor = Color.Salmon;
            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            var pesquisa = tbPesquisa.Text;

            LimparCadastro();

            if (rbNome.Checked)
            {
                if (pesquisa == "")
                {
                    ListarProdutos();
                }
                else
                {
                    RetornaProdutosPorNome(pesquisa);
                }
            }
            else if (rbCategoria.Checked)
            {
                if (pesquisa == "")
                {
                    ListarProdutos();
                }
                else
                {
                    RetornaProdutosPorCategoria(pesquisa);
                }
            }
            else if (rbCodigoBarras.Checked)
            {
                if (pesquisa == "")
                {
                    ListarProdutos();
                }
                else
                {
                    RetornaProdutosPorCodigoBarras(pesquisa);
                }
            }
            else
            {
                ListarProdutos();
            }

            Estilo();
        }
    }
}
