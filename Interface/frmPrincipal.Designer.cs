namespace Interface
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbCodigo = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.lbNome = new System.Windows.Forms.Label();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.lbEndereco = new System.Windows.Forms.Label();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.tbBairro = new System.Windows.Forms.TextBox();
			this.tbCidade = new System.Windows.Forms.TextBox();
			this.lbBairro = new System.Windows.Forms.Label();
			this.lbCidade = new System.Windows.Forms.Label();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.lbNascimento = new System.Windows.Forms.Label();
			this.tbObservacoes = new System.Windows.Forms.TextBox();
			this.lbObservacoes = new System.Windows.Forms.Label();
			this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
			this.gbDocumentos = new System.Windows.Forms.GroupBox();
			this.mtbRg = new System.Windows.Forms.MaskedTextBox();
			this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.gbContato = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
			this.mtbResidencial = new System.Windows.Forms.MaskedTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lbCadastro = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.mtbPesquisaCpf = new System.Windows.Forms.MaskedTextBox();
			this.btnTeste = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.rbCpf = new System.Windows.Forms.RadioButton();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.tbPesquisa = new System.Windows.Forms.TextBox();
			this.dtgClientes = new System.Windows.Forms.DataGridView();
			this.dtgNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgCpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgCelularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgCidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgCadastroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgRgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgResidencialCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgNascimentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgObservacoesCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgBairroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgEnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditarCliente = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluirCliente = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.toolStrip1.SuspendLayout();
			this.gbDocumentos.SuspendLayout();
			this.gbContato.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// lbCodigo
			// 
			this.lbCodigo.AutoSize = true;
			this.lbCodigo.Enabled = false;
			this.lbCodigo.Location = new System.Drawing.Point(12, 37);
			this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCodigo.Name = "lbCodigo";
			this.lbCodigo.Size = new System.Drawing.Size(56, 17);
			this.lbCodigo.TabIndex = 0;
			this.lbCodigo.Text = "Código:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnAdicionar,
            this.toolStripSeparator4});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(925, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(58, 22);
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(62, 22);
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
			this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(78, 22);
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tbCodigo
			// 
			this.tbCodigo.Enabled = false;
			this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbCodigo.Location = new System.Drawing.Point(100, 34);
			this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(46, 25);
			this.tbCodigo.TabIndex = 0;
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Enabled = false;
			this.lbNome.Location = new System.Drawing.Point(12, 74);
			this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(49, 17);
			this.lbNome.TabIndex = 0;
			this.lbNome.Text = "Nome:";
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbNome.Location = new System.Drawing.Point(100, 71);
			this.tbNome.Margin = new System.Windows.Forms.Padding(2);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(267, 25);
			this.tbNome.TabIndex = 1;
			// 
			// lbEndereco
			// 
			this.lbEndereco.AutoSize = true;
			this.lbEndereco.Enabled = false;
			this.lbEndereco.Location = new System.Drawing.Point(12, 110);
			this.lbEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbEndereco.Name = "lbEndereco";
			this.lbEndereco.Size = new System.Drawing.Size(68, 17);
			this.lbEndereco.TabIndex = 0;
			this.lbEndereco.Text = "Endereco:";
			// 
			// tbEndereco
			// 
			this.tbEndereco.Enabled = false;
			this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbEndereco.Location = new System.Drawing.Point(100, 107);
			this.tbEndereco.Margin = new System.Windows.Forms.Padding(2);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(267, 25);
			this.tbEndereco.TabIndex = 2;
			// 
			// tbBairro
			// 
			this.tbBairro.Enabled = false;
			this.tbBairro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbBairro.Location = new System.Drawing.Point(100, 143);
			this.tbBairro.Margin = new System.Windows.Forms.Padding(2);
			this.tbBairro.Name = "tbBairro";
			this.tbBairro.Size = new System.Drawing.Size(267, 25);
			this.tbBairro.TabIndex = 3;
			// 
			// tbCidade
			// 
			this.tbCidade.Enabled = false;
			this.tbCidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbCidade.Location = new System.Drawing.Point(100, 179);
			this.tbCidade.Margin = new System.Windows.Forms.Padding(2);
			this.tbCidade.Name = "tbCidade";
			this.tbCidade.Size = new System.Drawing.Size(267, 25);
			this.tbCidade.TabIndex = 4;
			// 
			// lbBairro
			// 
			this.lbBairro.AutoSize = true;
			this.lbBairro.Enabled = false;
			this.lbBairro.Location = new System.Drawing.Point(12, 146);
			this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbBairro.Name = "lbBairro";
			this.lbBairro.Size = new System.Drawing.Size(49, 17);
			this.lbBairro.TabIndex = 0;
			this.lbBairro.Text = "Bairro:";
			// 
			// lbCidade
			// 
			this.lbCidade.AutoSize = true;
			this.lbCidade.Enabled = false;
			this.lbCidade.Location = new System.Drawing.Point(12, 182);
			this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCidade.Name = "lbCidade";
			this.lbCidade.Size = new System.Drawing.Size(54, 17);
			this.lbCidade.TabIndex = 0;
			this.lbCidade.Text = "Cidade:";
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.CustomFormat = "dd/MM/yy";
			this.dtpNascimento.Enabled = false;
			this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimento.Location = new System.Drawing.Point(482, 37);
			this.dtpNascimento.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(137, 25);
			this.dtpNascimento.TabIndex = 5;
			this.dtpNascimento.Value = new System.DateTime(2024, 2, 19, 0, 0, 0, 0);
			// 
			// lbNascimento
			// 
			this.lbNascimento.AutoSize = true;
			this.lbNascimento.Enabled = false;
			this.lbNascimento.Location = new System.Drawing.Point(394, 40);
			this.lbNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbNascimento.Name = "lbNascimento";
			this.lbNascimento.Size = new System.Drawing.Size(85, 17);
			this.lbNascimento.TabIndex = 0;
			this.lbNascimento.Text = "Nascimento:";
			// 
			// tbObservacoes
			// 
			this.tbObservacoes.Enabled = false;
			this.tbObservacoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbObservacoes.Location = new System.Drawing.Point(100, 214);
			this.tbObservacoes.Margin = new System.Windows.Forms.Padding(2);
			this.tbObservacoes.Multiline = true;
			this.tbObservacoes.Name = "tbObservacoes";
			this.tbObservacoes.Size = new System.Drawing.Size(267, 111);
			this.tbObservacoes.TabIndex = 10;
			// 
			// lbObservacoes
			// 
			this.lbObservacoes.AutoSize = true;
			this.lbObservacoes.Enabled = false;
			this.lbObservacoes.Location = new System.Drawing.Point(10, 217);
			this.lbObservacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbObservacoes.Name = "lbObservacoes";
			this.lbObservacoes.Size = new System.Drawing.Size(90, 17);
			this.lbObservacoes.TabIndex = 0;
			this.lbObservacoes.Text = "Observações:";
			// 
			// dtpCadastro
			// 
			this.dtpCadastro.CustomFormat = "dd/MM/yy HH:mm";
			this.dtpCadastro.Enabled = false;
			this.dtpCadastro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastro.Location = new System.Drawing.Point(772, 37);
			this.dtpCadastro.Margin = new System.Windows.Forms.Padding(2);
			this.dtpCadastro.Name = "dtpCadastro";
			this.dtpCadastro.Size = new System.Drawing.Size(137, 25);
			this.dtpCadastro.TabIndex = 0;
			this.dtpCadastro.TabStop = false;
			// 
			// gbDocumentos
			// 
			this.gbDocumentos.Controls.Add(this.mtbRg);
			this.gbDocumentos.Controls.Add(this.mtbCpf);
			this.gbDocumentos.Controls.Add(this.label10);
			this.gbDocumentos.Controls.Add(this.label9);
			this.gbDocumentos.Enabled = false;
			this.gbDocumentos.Location = new System.Drawing.Point(392, 74);
			this.gbDocumentos.Margin = new System.Windows.Forms.Padding(2);
			this.gbDocumentos.Name = "gbDocumentos";
			this.gbDocumentos.Padding = new System.Windows.Forms.Padding(2);
			this.gbDocumentos.Size = new System.Drawing.Size(247, 96);
			this.gbDocumentos.TabIndex = 0;
			this.gbDocumentos.TabStop = false;
			this.gbDocumentos.Text = "Documentos";
			// 
			// mtbRg
			// 
			this.mtbRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.mtbRg.Location = new System.Drawing.Point(49, 62);
			this.mtbRg.Margin = new System.Windows.Forms.Padding(2);
			this.mtbRg.Mask = "99,999,999-99";
			this.mtbRg.Name = "mtbRg";
			this.mtbRg.Size = new System.Drawing.Size(101, 25);
			this.mtbRg.TabIndex = 7;
			// 
			// mtbCpf
			// 
			this.mtbCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.mtbCpf.Location = new System.Drawing.Point(49, 25);
			this.mtbCpf.Margin = new System.Windows.Forms.Padding(2);
			this.mtbCpf.Mask = "999,999,999-99";
			this.mtbCpf.Name = "mtbCpf";
			this.mtbCpf.Size = new System.Drawing.Size(101, 25);
			this.mtbCpf.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(7, 65);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 19);
			this.label10.TabIndex = 0;
			this.label10.Text = "RG:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(7, 28);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 19);
			this.label9.TabIndex = 0;
			this.label9.Text = "CPF:";
			// 
			// gbContato
			// 
			this.gbContato.Controls.Add(this.label12);
			this.gbContato.Controls.Add(this.mtbCelular);
			this.gbContato.Controls.Add(this.mtbResidencial);
			this.gbContato.Controls.Add(this.label11);
			this.gbContato.Enabled = false;
			this.gbContato.Location = new System.Drawing.Point(661, 74);
			this.gbContato.Margin = new System.Windows.Forms.Padding(2);
			this.gbContato.Name = "gbContato";
			this.gbContato.Padding = new System.Windows.Forms.Padding(2);
			this.gbContato.Size = new System.Drawing.Size(247, 96);
			this.gbContato.TabIndex = 0;
			this.gbContato.TabStop = false;
			this.gbContato.Text = "Contato";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(8, 65);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 19);
			this.label12.TabIndex = 0;
			this.label12.Text = "Celular:";
			// 
			// mtbCelular
			// 
			this.mtbCelular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.mtbCelular.Location = new System.Drawing.Point(100, 62);
			this.mtbCelular.Margin = new System.Windows.Forms.Padding(2);
			this.mtbCelular.Mask = "(99) 99999-9999";
			this.mtbCelular.Name = "mtbCelular";
			this.mtbCelular.Size = new System.Drawing.Size(105, 25);
			this.mtbCelular.TabIndex = 9;
			// 
			// mtbResidencial
			// 
			this.mtbResidencial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.mtbResidencial.Location = new System.Drawing.Point(100, 22);
			this.mtbResidencial.Margin = new System.Windows.Forms.Padding(2);
			this.mtbResidencial.Mask = "(99) 99999-9999";
			this.mtbResidencial.Name = "mtbResidencial";
			this.mtbResidencial.Size = new System.Drawing.Size(105, 25);
			this.mtbResidencial.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label11.Location = new System.Drawing.Point(8, 25);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 19);
			this.label11.TabIndex = 0;
			this.label11.Text = "Residencial:";
			// 
			// lbCadastro
			// 
			this.lbCadastro.AutoSize = true;
			this.lbCadastro.Enabled = false;
			this.lbCadastro.Location = new System.Drawing.Point(650, 43);
			this.lbCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCadastro.Name = "lbCadastro";
			this.lbCadastro.Size = new System.Drawing.Size(118, 17);
			this.lbCadastro.TabIndex = 0;
			this.lbCadastro.Text = "Data de Cadastro:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.mtbPesquisaCpf);
			this.groupBox3.Controls.Add(this.btnTeste);
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Controls.Add(this.rbCpf);
			this.groupBox3.Controls.Add(this.rbNome);
			this.groupBox3.Controls.Add(this.tbPesquisa);
			this.groupBox3.Location = new System.Drawing.Point(392, 217);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(517, 110);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pesquisa";
			// 
			// mtbPesquisaCpf
			// 
			this.mtbPesquisaCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.mtbPesquisaCpf.Location = new System.Drawing.Point(11, 36);
			this.mtbPesquisaCpf.Margin = new System.Windows.Forms.Padding(2);
			this.mtbPesquisaCpf.Mask = "999,999,999-99";
			this.mtbPesquisaCpf.Name = "mtbPesquisaCpf";
			this.mtbPesquisaCpf.Size = new System.Drawing.Size(266, 25);
			this.mtbPesquisaCpf.TabIndex = 11;
			this.mtbPesquisaCpf.TabStop = false;
			this.mtbPesquisaCpf.Visible = false;
			this.mtbPesquisaCpf.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
			// 
			// btnTeste
			// 
			this.btnTeste.Location = new System.Drawing.Point(380, 45);
			this.btnTeste.Name = "btnTeste";
			this.btnTeste.Size = new System.Drawing.Size(124, 26);
			this.btnTeste.TabIndex = 14;
			this.btnTeste.Text = "Botao pra teste";
			this.btnTeste.UseVisualStyleBackColor = true;
			this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(398, -66);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(8, 8);
			this.dataGridView1.TabIndex = 5;
			// 
			// rbCpf
			// 
			this.rbCpf.AutoSize = true;
			this.rbCpf.Location = new System.Drawing.Point(75, 73);
			this.rbCpf.Margin = new System.Windows.Forms.Padding(2);
			this.rbCpf.Name = "rbCpf";
			this.rbCpf.Size = new System.Drawing.Size(47, 21);
			this.rbCpf.TabIndex = 13;
			this.rbCpf.TabStop = true;
			this.rbCpf.Text = "Cpf";
			this.rbCpf.UseVisualStyleBackColor = true;
			// 
			// rbNome
			// 
			this.rbNome.AutoSize = true;
			this.rbNome.Location = new System.Drawing.Point(10, 73);
			this.rbNome.Margin = new System.Windows.Forms.Padding(2);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(63, 21);
			this.rbNome.TabIndex = 12;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// tbPesquisa
			// 
			this.tbPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tbPesquisa.Location = new System.Drawing.Point(10, 36);
			this.tbPesquisa.Margin = new System.Windows.Forms.Padding(2);
			this.tbPesquisa.Name = "tbPesquisa";
			this.tbPesquisa.Size = new System.Drawing.Size(267, 25);
			this.tbPesquisa.TabIndex = 11;
			this.tbPesquisa.TabStop = false;
			this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
			// 
			// dtgClientes
			// 
			this.dtgClientes.AllowUserToAddRows = false;
			this.dtgClientes.AllowUserToDeleteRows = false;
			this.dtgClientes.AllowUserToResizeColumns = false;
			this.dtgClientes.AllowUserToResizeRows = false;
			this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgNomeCliente,
            this.dtgCpfCliente,
            this.dtgCelularCliente,
            this.dtgCidadeCliente,
            this.dtgCadastroCliente,
            this.dtgRgCliente,
            this.dtgResidencialCliente,
            this.dtgNascimentoCliente,
            this.dtgObservacoesCliente,
            this.dtgBairroCliente,
            this.dtgEnderecoCliente,
            this.dtgIdCliente,
            this.btnEditarCliente,
            this.btnExcluirCliente});
			this.dtgClientes.Location = new System.Drawing.Point(10, 355);
			this.dtgClientes.Margin = new System.Windows.Forms.Padding(2);
			this.dtgClientes.Name = "dtgClientes";
			this.dtgClientes.ReadOnly = true;
			this.dtgClientes.RowHeadersVisible = false;
			this.dtgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgClientes.Size = new System.Drawing.Size(904, 137);
			this.dtgClientes.TabIndex = 0;
			this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
			this.dtgClientes.CurrentCellChanged += new System.EventHandler(this.dtgClientes_CurrentCellChanged);
			// 
			// dtgNomeCliente
			// 
			this.dtgNomeCliente.DataPropertyName = "NOME";
			this.dtgNomeCliente.HeaderText = "Nome";
			this.dtgNomeCliente.Name = "dtgNomeCliente";
			this.dtgNomeCliente.ReadOnly = true;
			this.dtgNomeCliente.Width = 300;
			// 
			// dtgCpfCliente
			// 
			this.dtgCpfCliente.DataPropertyName = "CPF";
			this.dtgCpfCliente.HeaderText = "CPF";
			this.dtgCpfCliente.Name = "dtgCpfCliente";
			this.dtgCpfCliente.ReadOnly = true;
			this.dtgCpfCliente.Width = 130;
			// 
			// dtgCelularCliente
			// 
			this.dtgCelularCliente.DataPropertyName = "CELULAR";
			this.dtgCelularCliente.HeaderText = "Celular";
			this.dtgCelularCliente.Name = "dtgCelularCliente";
			this.dtgCelularCliente.ReadOnly = true;
			this.dtgCelularCliente.Width = 130;
			// 
			// dtgCidadeCliente
			// 
			this.dtgCidadeCliente.DataPropertyName = "CIDADE";
			this.dtgCidadeCliente.HeaderText = "Cidade";
			this.dtgCidadeCliente.Name = "dtgCidadeCliente";
			this.dtgCidadeCliente.ReadOnly = true;
			this.dtgCidadeCliente.Width = 130;
			// 
			// dtgCadastroCliente
			// 
			this.dtgCadastroCliente.DataPropertyName = "DATA_CADASTRO";
			this.dtgCadastroCliente.HeaderText = "Data cadastro";
			this.dtgCadastroCliente.Name = "dtgCadastroCliente";
			this.dtgCadastroCliente.ReadOnly = true;
			this.dtgCadastroCliente.Width = 130;
			// 
			// dtgRgCliente
			// 
			this.dtgRgCliente.DataPropertyName = "RG";
			this.dtgRgCliente.HeaderText = "RG";
			this.dtgRgCliente.Name = "dtgRgCliente";
			this.dtgRgCliente.ReadOnly = true;
			this.dtgRgCliente.Visible = false;
			// 
			// dtgResidencialCliente
			// 
			this.dtgResidencialCliente.DataPropertyName = "RESIDENCIAL";
			this.dtgResidencialCliente.HeaderText = "Residencial";
			this.dtgResidencialCliente.Name = "dtgResidencialCliente";
			this.dtgResidencialCliente.ReadOnly = true;
			this.dtgResidencialCliente.Visible = false;
			// 
			// dtgNascimentoCliente
			// 
			this.dtgNascimentoCliente.DataPropertyName = "NASCIMENTO";
			this.dtgNascimentoCliente.HeaderText = "Nascimento";
			this.dtgNascimentoCliente.Name = "dtgNascimentoCliente";
			this.dtgNascimentoCliente.ReadOnly = true;
			this.dtgNascimentoCliente.Visible = false;
			// 
			// dtgObservacoesCliente
			// 
			this.dtgObservacoesCliente.DataPropertyName = "OBSERVACOES";
			this.dtgObservacoesCliente.HeaderText = "Observacoes";
			this.dtgObservacoesCliente.Name = "dtgObservacoesCliente";
			this.dtgObservacoesCliente.ReadOnly = true;
			this.dtgObservacoesCliente.Visible = false;
			// 
			// dtgBairroCliente
			// 
			this.dtgBairroCliente.DataPropertyName = "BAIRRO";
			this.dtgBairroCliente.HeaderText = "Bairro";
			this.dtgBairroCliente.Name = "dtgBairroCliente";
			this.dtgBairroCliente.ReadOnly = true;
			this.dtgBairroCliente.Visible = false;
			// 
			// dtgEnderecoCliente
			// 
			this.dtgEnderecoCliente.DataPropertyName = "ENDERECO";
			this.dtgEnderecoCliente.HeaderText = "Endereco";
			this.dtgEnderecoCliente.Name = "dtgEnderecoCliente";
			this.dtgEnderecoCliente.ReadOnly = true;
			this.dtgEnderecoCliente.Visible = false;
			// 
			// dtgIdCliente
			// 
			this.dtgIdCliente.DataPropertyName = "ID_CLIENTE";
			this.dtgIdCliente.HeaderText = "ID_CLIENTE";
			this.dtgIdCliente.Name = "dtgIdCliente";
			this.dtgIdCliente.ReadOnly = true;
			this.dtgIdCliente.Visible = false;
			// 
			// btnEditarCliente
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
			this.btnEditarCliente.DefaultCellStyle = dataGridViewCellStyle5;
			this.btnEditarCliente.HeaderText = "";
			this.btnEditarCliente.Image = global::Interface.Properties.Resources.lapis;
			this.btnEditarCliente.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnEditarCliente.Name = "btnEditarCliente";
			this.btnEditarCliente.ReadOnly = true;
			this.btnEditarCliente.Width = 25;
			// 
			// btnExcluirCliente
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
			this.btnExcluirCliente.DefaultCellStyle = dataGridViewCellStyle6;
			this.btnExcluirCliente.HeaderText = "";
			this.btnExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCliente.Image")));
			this.btnExcluirCliente.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnExcluirCliente.Name = "btnExcluirCliente";
			this.btnExcluirCliente.ReadOnly = true;
			this.btnExcluirCliente.Width = 25;
			// 
			// dataGridViewImageColumn1
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
			this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Interface.Properties.Resources.editar;
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 30;
			// 
			// dataGridViewImageColumn2
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
			this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::Interface.Properties.Resources.excluir;
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 30;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 503);
			this.Controls.Add(this.dtgClientes);
			this.Controls.Add(this.gbContato);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.gbDocumentos);
			this.Controls.Add(this.dtpCadastro);
			this.Controls.Add(this.dtpNascimento);
			this.Controls.Add(this.tbObservacoes);
			this.Controls.Add(this.tbCidade);
			this.Controls.Add(this.tbBairro);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbCodigo);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lbObservacoes);
			this.Controls.Add(this.lbCadastro);
			this.Controls.Add(this.lbNascimento);
			this.Controls.Add(this.lbCidade);
			this.Controls.Add(this.lbBairro);
			this.Controls.Add(this.lbEndereco);
			this.Controls.Add(this.lbNome);
			this.Controls.Add(this.lbCodigo);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCF - Controle de Clientes";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.gbDocumentos.ResumeLayout(false);
			this.gbDocumentos.PerformLayout();
			this.gbContato.ResumeLayout(false);
			this.gbContato.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label lbObservacoes;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.GroupBox gbDocumentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbResidencial;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCelularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCadastroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgRgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgResidencialCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNascimentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgObservacoesCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgBairroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgEnderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgIdCliente;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarCliente;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluirCliente;
        private System.Windows.Forms.MaskedTextBox mtbPesquisaCpf;
    }
}

