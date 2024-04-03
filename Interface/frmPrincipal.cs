using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPrincipal : Form
    {
        MessageBoxes message = new MessageBoxes();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Estilo();
            ListarClientes();
            AtualizarDtps();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var idCliente = int.TryParse(tbCodigo.Text, out int id);
            var tabela = dtgClientes;
            var nome = tbNome.Text;
            var rg = mtbRg.Text;
            var cpf = mtbCpf.Text;
            var endereco = tbEndereco.Text;
            var bairro = tbBairro.Text;
            var cidade = tbCidade.Text;
            var nascimento = dtpNascimento.Value;
            var observacoes = tbObservacoes.Text;
            var residencial = mtbResidencial.Text;
            var celular = mtbCelular.Text;
            var cadastro = dtpCadastro.Value;

            Logica logica = new Logica();

            try
            {
                if (tbCodigo.Text == "")
                {
                    message.VerificaLinhas(tabela);
                }

                if (tbNome.Enabled == false)
                {
                    message.MboxAviso("Clique em adicionar ou no botão de editar para salvar as informações de um cliente");
                }
                else if (id != 0)
                {
                    logica.Atualizar(id, nome, rg, cpf, endereco, bairro, cidade, nascimento, residencial, celular, observacoes);
                    message.MboxInfo("Cliente alterado com sucesso");
                    LimparCadastro();
                    ListarClientes();
                }
                else
                {
                    logica.Salvar(nome, rg, cpf, endereco, bairro, cidade, nascimento, residencial, celular, observacoes, cadastro);
                    message.MboxInfo("Cliente salvo com sucesso");
                    LimparCadastro();
                    ListarClientes();
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message, "Erro no cadastro");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
            HabilitarCadastro();
            tbNome.Focus();
            tbCodigo.BackColor = Color.White;
            tbCodigo.Text = "0";
        }

        private void Estilo()
        {
            int linhas = dtgClientes.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                if (i%2 == 0)
                {
                    dtgClientes.Rows[i].Cells["dtgNomeCliente"].Style.BackColor = Color.LightSteelBlue;
                    dtgClientes.Rows[i].Cells["dtgCpfCliente"].Style.BackColor = Color.LightSteelBlue;
                    dtgClientes.Rows[i].Cells["dtgCelularCliente"].Style.BackColor = Color.LightSteelBlue;
                    dtgClientes.Rows[i].Cells["dtgCidadeCliente"].Style.BackColor = Color.LightSteelBlue;
                    dtgClientes.Rows[i].Cells["dtgCadastroCliente"].Style.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void LimparCadastro()
        {
            tbCodigo.BackColor = Color.White;

            AtualizarDtps();

            tbCodigo.Clear();
            tbNome.Clear();
            tbEndereco.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbObservacoes.Clear();
            mtbCelular.Clear();
            mtbCpf.Clear();
            mtbResidencial.Clear();
            mtbRg.Clear();

            lbCodigo.Enabled = false;
            lbNome.Enabled = false;
            lbEndereco.Enabled = false;
            lbBairro.Enabled = false;
            lbCidade.Enabled = false;
            lbObservacoes.Enabled = false;
            lbNascimento.Enabled = false;
            lbCadastro.Enabled = false;

            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbEndereco.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            tbObservacoes.Enabled = false;
            gbDocumentos.Enabled = false;
            gbContato.Enabled = false;
            dtpCadastro.Enabled = false;
            dtpNascimento.Enabled = false;
        }

        private void HabilitarCadastro()
        {
            lbCodigo.Enabled = true;
            lbNome.Enabled = true;
            lbEndereco.Enabled = true;
            lbBairro.Enabled = true;
            lbCidade.Enabled = true;
            lbObservacoes.Enabled = true;
            lbNascimento.Enabled = true;
            lbCadastro.Enabled = true;

            tbNome.Enabled = true;
            tbEndereco.Enabled = true;
            tbBairro.Enabled = true;
            tbCidade.Enabled = true;
            tbObservacoes.Enabled = true;
            gbContato.Enabled = true;
            gbDocumentos.Enabled = true;
            dtpNascimento.Enabled = true;
            dtpCadastro.Enabled = true;
        }

        private void AtualizarDtps()
        {
            dtpNascimento.Value = DateTime.Now;
            dtpCadastro.Value = DateTime.Now;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int numeroTeste = dtgClientes.Rows.Count;
            if (tbCodigo.Text == "0")
            {
                tbNome.Text = $"NOME TESTE {numeroTeste}";
                tbEndereco.Text = $"ENDERECO TESTE {numeroTeste}";
                tbBairro.Text = $"BAIRRO TESTE {numeroTeste}";
                tbCidade.Text = $"CIDADE TESTE {numeroTeste}";
                tbObservacoes.Text = $"OBSERVAÇÃO TESTE {numeroTeste}";
                mtbCelular.Text = "(12) 34567-8910";
                mtbCpf.Text = "123.456.789-09";
                mtbResidencial.Text = "(12) 34567-8910";
                mtbRg.Text = "12.345.678-90";
                dtpNascimento.Value = Convert.ToDateTime("01/01/2000");
            }
        }

        private void ListarClientes()
        {
            try
            {
                Logica logica = new Logica();
                dtgClientes.DataSource = logica.ListarClientes();
                Estilo();
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var idCliente = int.TryParse(tbCodigo.Text, out int id);
            var tabela = dtgClientes;
            Logica logica = new Logica();

            try
            {
                message.VerificaLinhas(tabela);
                if (idCliente && id != 0)
                {
                    var nome = tbNome.Text;

                    var confirmacao = message.MboxConfirmacao($"Deseja excluir o cliente: {nome} de id: {id}?");

                    if (confirmacao == DialogResult.Yes)
                    {
                        logica.Excluir(id);
                        ListarClientes();
                        LimparCadastro();
                    }
                    else
                    {
                        message.MboxInfo("Operação cancelada", "Falha");
                    }
                }
                else
                {
                    tbCodigo.BackColor = Color.Salmon;
                    message.MboxErro("Selecione um cliente existente para excluir");
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var tabela = dtgClientes;
                message.VerificaLinhas(tabela);

                var idCliente = dtgClientes.Rows[e.RowIndex].Cells["dtgIdCliente"].Value.ToString();
                var nome = dtgClientes.Rows[e.RowIndex].Cells["dtgNomeCliente"].Value.ToString();
                var rg = dtgClientes.Rows[e.RowIndex].Cells["dtgRgCliente"].Value.ToString();
                var cpf = dtgClientes.Rows[e.RowIndex].Cells["dtgCpfCliente"].Value.ToString();
                var endereco = dtgClientes.Rows[e.RowIndex].Cells["dtgEnderecoCliente"].Value.ToString();
                var bairro = dtgClientes.Rows[e.RowIndex].Cells["dtgBairroCliente"].Value.ToString();
                var cidade = dtgClientes.Rows[e.RowIndex].Cells["dtgCidadeCliente"].Value.ToString();
                var observacoes = dtgClientes.Rows[e.RowIndex].Cells["dtgObservacoesCliente"].Value.ToString();
                var celular = dtgClientes.Rows[e.RowIndex].Cells["dtgCelularCliente"].Value.ToString();
                var residencial = dtgClientes.Rows[e.RowIndex].Cells["dtgResidencialCliente"].Value.ToString();
                var cadastro = dtgClientes.Rows[e.RowIndex].Cells["dtgCadastroCliente"].Value.ToString();
                var nascimento = dtgClientes.Rows[e.RowIndex].Cells["dtgNascimentoCliente"].Value.ToString();

                if (dtgClientes.Rows.Count > 0)
                {
                    if (dtgClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")
                    {
                        HabilitarCadastro();
                        dtpCadastro.Enabled = false;
                        tbCodigo.Text = idCliente;
                        tbNome.Text = nome;
                        mtbRg.Text = rg;
                        mtbCpf.Text = cpf;
                        tbEndereco.Text = endereco;
                        tbBairro.Text = bairro;
                        tbCidade.Text = cidade;
                        tbObservacoes.Text = observacoes;
                        mtbResidencial.Text = residencial;
                        mtbCelular.Text = celular;
                        dtpNascimento.Value = Convert.ToDateTime(nascimento);
                        dtpCadastro.Value = Convert.ToDateTime(cadastro);
                    }
                    else if (dtgClientes.Columns[e.ColumnIndex].Name == "btnExcluirCliente")
                    {
                        tbCodigo.BackColor = Color.White;
                        Logica logica = new Logica();

                        var confirmacao = message.MboxConfirmacao($"Deseja excluir o cliente: {nome} de id: {idCliente}?");

                        if (confirmacao == DialogResult.Yes)
                        {
                            logica.Excluir(Convert.ToInt32(idCliente));
                            LimparCadastro();
                            ListarClientes();
                        }
                        else
                        {
                            message.MboxInfo("Operação cancelada", "Falha");
                        }
                    }
                    else
                    {
                        LimparCadastro();
                    }
                }
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void dtgClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            LimparCadastro();
        }

        private void RetornaClientePorNome(string nome)
        {
            try
            {
                var logica = new Logica();
                dtgClientes.DataSource = logica.RetornaClientePorNome(nome);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void RetornaClientePorCpf(string cpf)
        {
            try
            {
                var logica = new Logica();
                dtgClientes.DataSource = logica.RetornaClientePorCpf(cpf);
            }
            catch (Exception ex)
            {
                message.MboxErro(ex.Message);
            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                if (tbPesquisa.Text == "")
                {
                    ListarClientes();
                }
                else
                {
                    RetornaClientePorNome(tbPesquisa.Text);
                }
            }
            else if (rbCpf.Checked)
            {
                if (mtbPesquisaCpf.Text == "   .   .   -  ")
                {
                    ListarClientes();
                }
                else
                {
                    RetornaClientePorCpf(tbPesquisa.Text);
                }
            }
            else
            {
                message.MboxErro("Selecione uma opção");
            }

            Estilo();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
