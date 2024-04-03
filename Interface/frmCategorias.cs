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
    public partial class frmCategorias : Form
    {
        MessageBoxes message = new MessageBoxes();
        frmProdutos FrmProdutos;

        public frmCategorias(frmProdutos frmProdutos)
        {
            InitializeComponent();
            FrmProdutos = frmProdutos;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        private void AtualizarFormulario()
        {
            ListarCategorias();
            LimparCadastro();
            FrmProdutos.ListarCategorias();
            FrmProdutos.ListarProdutos();
            FrmProdutos.ListarProdutosEstoqueBaixo();
        }

        private void Estilo()
        {
            var linhas = dtgCategorias.Rows.Count;

            for (int i = 0; i < linhas; i+=2)
            {
                dtgCategorias.Rows[i].Cells["dtgCategoriasNome"].Style.BackColor = Color.LightSteelBlue;
                dtgCategorias.Rows[i].Cells["dtgCategoriasDescricao"].Style.BackColor = Color.LightSteelBlue;
                dtgCategorias.Rows[i].Cells["dtgCategoriasIdCategoria"].Style.BackColor = Color.LightSteelBlue;
            }
        }

        private void LimparCadastro()
        {
            tbCodigo.BackColor = Color.White;

            lbCodigo.Enabled = false;
            lbDescricao.Enabled = false;
            lbNome.Enabled = false;

            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbDescricao.Enabled = false;

            tbCodigo.Clear();
            tbNome.Clear();
            tbDescricao.Clear();
        }

        private void HabilitarCadastro()
        {
            tbCodigo.BackColor = Color.White;

            lbCodigo.Enabled = true;
            lbDescricao.Enabled = true;
            lbNome.Enabled = true;

            tbCodigo.Enabled = true;
            tbNome.Enabled = true;
            tbDescricao.Enabled = true;
        }

        private void ListarCategorias()
        {
            try
            {
                var categoriaLogica = new CategoriasLogica();
                dtgCategorias.DataSource = categoriaLogica.ListarCategorias();
                Estilo();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tabela = dtgCategorias;
            var idCodigo = tbCodigo.Text;
            var nome = tbNome.Text;
            var descricao = tbDescricao.Text;

            try
            {
                if (idCodigo == "")
                {
                    message.VerificaLinhas(tabela);
                }

                if (idCodigo == "")
                {
                    tbCodigo.BackColor = Color.Salmon;
                    message.MboxErro("Clique em adicionar ou no botão de editar para salvar as informações de uma categoria", "Erro no cadastro");
                }
                else if (idCodigo != "0")
                {
                    var categoriaLogica = new CategoriasLogica();
                    categoriaLogica.Atualizar(idCodigo, nome, descricao);
                    AtualizarFormulario();
                }
                else if (idCodigo == "0")
                {
                    var categoriaLogica = new CategoriasLogica();
                    categoriaLogica.Salvar(nome, descricao);
                    AtualizarFormulario();
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var tabela = dtgCategorias;
            var idCodigo = tbCodigo.Text;
            var nome = tbNome.Text;

            try
            {
                message.VerificaLinhas(tabela);

                if (tbCodigo.Text == "" || tbCodigo.Text == "0")
                {
                    tbCodigo.BackColor = Color.Salmon;
                    message.MboxErro("Selecione uma categoria para excluir", "Erro no cadastro");
                }
                else
                {
                    tbCodigo.BackColor = Color.White;

                    var categoriaLogica = new CategoriasLogica();
                    int numeroProdutos = categoriaLogica.RetornaNumeroProdutosCategoria(idCodigo); 
                    var confirmacao = message.MboxConfirmacao($"Deseja excluir a categoria: {nome}, de id {idCodigo}?\r\nFazendo isso, você estará " +
                        $"excluindo todos os produtos dessa categoria ({numeroProdutos} Produtos)");

                    if (confirmacao == DialogResult.Yes)
                    {
                        categoriaLogica.ExcluirProdutosPorCategorias(idCodigo);
                        categoriaLogica.Excluir(idCodigo);
                        AtualizarFormulario();
                    }
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var tabela = dtgCategorias;

            try
            {
                message.VerificaLinhas(tabela);

                var idCodigo = dtgCategorias.Rows[e.RowIndex].Cells["dtgCategoriasIdCategoria"].Value.ToString();
                var nome = dtgCategorias.Rows[e.RowIndex].Cells["dtgCategoriasNome"].Value.ToString();
                var descricao = dtgCategorias.Rows[e.RowIndex].Cells["dtgCategoriasDescricao"].Value.ToString();

                if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnCategoriasEditar")
                {
                    HabilitarCadastro();

                    tbCodigo.Text = idCodigo;
                    tbNome.Text = nome;
                    tbDescricao.Text = descricao;
                }
                else if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnCategoriasExcluir")
                {
                    var categoriaLogica = new CategoriasLogica();
                    int numeroProdutos = categoriaLogica.RetornaNumeroProdutosCategoria(idCodigo);
                    var confirmacao = message.MboxConfirmacao($"Deseja excluir a categoria: {nome}, de id {idCodigo}?\r\nFazendo isso, você estará " +
                        $"excluindo todos os produtos dessa categoria ({numeroProdutos} Produtos)");

                    if (confirmacao == DialogResult.Yes)
                    {
                        categoriaLogica.ExcluirProdutosPorCategorias(idCodigo);
                        categoriaLogica.Excluir(idCodigo);
                        AtualizarFormulario();
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
    }
}