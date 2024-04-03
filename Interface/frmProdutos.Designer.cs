namespace Interface
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategoria = new System.Windows.Forms.ToolStripButton();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigoBarras = new System.Windows.Forms.Label();
            this.tbCodigoBarras = new System.Windows.Forms.TextBox();
            this.lbDetalhes = new System.Windows.Forms.Label();
            this.tbDetalhes = new System.Windows.Forms.TextBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.tbEstoqueAtual = new System.Windows.Forms.TextBox();
            this.tbEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.tbValorCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbCodigoBarras = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgProdutosEstoque = new System.Windows.Forms.DataGridView();
            this.dtgProdutosEstoqueNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueEstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.dtgProdutosIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosNomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProdutosIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProdutosEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnProdutosExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.gbValores.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripSeparator4,
            this.btnCategoria});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1257, 38);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(46, 35);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(62, 35);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(138, 35);
            this.btnCategoria.Text = "Adicionar categoria";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCodigo.Location = new System.Drawing.Point(95, 56);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(42, 25);
            this.tbCodigo.TabIndex = 4;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Enabled = false;
            this.lbCodigo.Location = new System.Drawing.Point(24, 59);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(56, 17);
            this.lbCodigo.TabIndex = 5;
            this.lbCodigo.Text = "Código:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbNome.Location = new System.Drawing.Point(95, 101);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(514, 25);
            this.tbNome.TabIndex = 6;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Enabled = false;
            this.lbNome.Location = new System.Drawing.Point(24, 104);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome:";
            // 
            // lbCodigoBarras
            // 
            this.lbCodigoBarras.AutoSize = true;
            this.lbCodigoBarras.Enabled = false;
            this.lbCodigoBarras.Location = new System.Drawing.Point(292, 62);
            this.lbCodigoBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoBarras.Name = "lbCodigoBarras";
            this.lbCodigoBarras.Size = new System.Drawing.Size(117, 17);
            this.lbCodigoBarras.TabIndex = 8;
            this.lbCodigoBarras.Text = "Código de barras:";
            // 
            // tbCodigoBarras
            // 
            this.tbCodigoBarras.Enabled = false;
            this.tbCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCodigoBarras.Location = new System.Drawing.Point(413, 59);
            this.tbCodigoBarras.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoBarras.Name = "tbCodigoBarras";
            this.tbCodigoBarras.Size = new System.Drawing.Size(196, 25);
            this.tbCodigoBarras.TabIndex = 9;
            // 
            // lbDetalhes
            // 
            this.lbDetalhes.AutoSize = true;
            this.lbDetalhes.Enabled = false;
            this.lbDetalhes.Location = new System.Drawing.Point(24, 151);
            this.lbDetalhes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDetalhes.Name = "lbDetalhes";
            this.lbDetalhes.Size = new System.Drawing.Size(66, 17);
            this.lbDetalhes.TabIndex = 10;
            this.lbDetalhes.Text = "Detalhes:";
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.Enabled = false;
            this.tbDetalhes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbDetalhes.Location = new System.Drawing.Point(27, 170);
            this.tbDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.tbDetalhes.Multiline = true;
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Size = new System.Drawing.Size(152, 94);
            this.tbDetalhes.TabIndex = 6;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.tbEstoqueAtual);
            this.gbEstoque.Controls.Add(this.tbEstoqueMinimo);
            this.gbEstoque.Controls.Add(this.label5);
            this.gbEstoque.Controls.Add(this.label4);
            this.gbEstoque.Enabled = false;
            this.gbEstoque.Location = new System.Drawing.Point(205, 155);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(190, 109);
            this.gbEstoque.TabIndex = 11;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // tbEstoqueAtual
            // 
            this.tbEstoqueAtual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbEstoqueAtual.Location = new System.Drawing.Point(92, 68);
            this.tbEstoqueAtual.Margin = new System.Windows.Forms.Padding(2);
            this.tbEstoqueAtual.Name = "tbEstoqueAtual";
            this.tbEstoqueAtual.Size = new System.Drawing.Size(81, 25);
            this.tbEstoqueAtual.TabIndex = 6;
            // 
            // tbEstoqueMinimo
            // 
            this.tbEstoqueMinimo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbEstoqueMinimo.Location = new System.Drawing.Point(92, 33);
            this.tbEstoqueMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.tbEstoqueMinimo.Name = "tbEstoqueMinimo";
            this.tbEstoqueMinimo.Size = new System.Drawing.Size(81, 25);
            this.tbEstoqueMinimo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mínimo:";
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.tbValorVenda);
            this.gbValores.Controls.Add(this.tbValorCompra);
            this.gbValores.Controls.Add(this.label6);
            this.gbValores.Controls.Add(this.label7);
            this.gbValores.Enabled = false;
            this.gbValores.Location = new System.Drawing.Point(419, 155);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(190, 109);
            this.gbValores.TabIndex = 11;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Valor unitário";
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbValorVenda.Location = new System.Drawing.Point(92, 68);
            this.tbValorVenda.Margin = new System.Windows.Forms.Padding(2);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.Size = new System.Drawing.Size(81, 25);
            this.tbValorVenda.TabIndex = 6;
            this.tbValorVenda.Leave += new System.EventHandler(this.tbValorVenda_Leave);
            // 
            // tbValorCompra
            // 
            this.tbValorCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbValorCompra.Location = new System.Drawing.Point(92, 33);
            this.tbValorCompra.Margin = new System.Windows.Forms.Padding(2);
            this.tbValorCompra.Name = "tbValorCompra";
            this.tbValorCompra.Size = new System.Drawing.Size(81, 25);
            this.tbValorCompra.TabIndex = 6;
            this.tbValorCompra.Leave += new System.EventHandler(this.tbValorCompra_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Custo:";
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Enabled = false;
            this.lbCadastro.Location = new System.Drawing.Point(622, 62);
            this.lbCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(99, 17);
            this.lbCadastro.TabIndex = 8;
            this.lbCadastro.Text = "Data Cadastro:";
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Enabled = false;
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastro.Location = new System.Drawing.Point(721, 59);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(155, 25);
            this.dtpCadastro.TabIndex = 12;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Enabled = false;
            this.lbCategoria.Location = new System.Drawing.Point(622, 104);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(71, 17);
            this.lbCategoria.TabIndex = 8;
            this.lbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(698, 101);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(178, 25);
            this.cbCategoria.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rbCodigoBarras);
            this.groupBox3.Controls.Add(this.rbCategoria);
            this.groupBox3.Controls.Add(this.rbNome);
            this.groupBox3.Controls.Add(this.tbPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(625, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Digite o termo da pesquisa";
            // 
            // rbCodigoBarras
            // 
            this.rbCodigoBarras.AutoSize = true;
            this.rbCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoBarras.Location = new System.Drawing.Point(180, 80);
            this.rbCodigoBarras.Name = "rbCodigoBarras";
            this.rbCodigoBarras.Size = new System.Drawing.Size(105, 17);
            this.rbCodigoBarras.TabIndex = 10;
            this.rbCodigoBarras.TabStop = true;
            this.rbCodigoBarras.Text = "Código de barras";
            this.rbCodigoBarras.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategoria.Location = new System.Drawing.Point(93, 80);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbCategoria.TabIndex = 10;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(20, 80);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 10;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbPesquisa.Location = new System.Drawing.Point(16, 41);
            this.tbPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(269, 25);
            this.tbPesquisa.TabIndex = 9;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(953, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Produtos com estoque baixo:";
            // 
            // dtgProdutosEstoque
            // 
            this.dtgProdutosEstoque.AllowUserToAddRows = false;
            this.dtgProdutosEstoque.AllowUserToDeleteRows = false;
            this.dtgProdutosEstoque.AllowUserToResizeColumns = false;
            this.dtgProdutosEstoque.AllowUserToResizeRows = false;
            this.dtgProdutosEstoque.BackgroundColor = System.Drawing.Color.Salmon;
            this.dtgProdutosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgProdutosEstoqueNome,
            this.dtgProdutosEstoqueDetalhes,
            this.dtgProdutosEstoqueIdCategoria,
            this.dtgProdutosEstoqueIdProduto,
            this.dtgProdutosEstoqueCodigoBarras,
            this.dtgProdutosEstoqueCadastro,
            this.dtgProdutosEstoqueEstoqueMinimo,
            this.dtgProdutosEstoqueEstoqueAtual,
            this.dtgProdutosEstoqueCompra,
            this.dtgProdutosEstoqueVenda});
            this.dtgProdutosEstoque.Location = new System.Drawing.Point(957, 88);
            this.dtgProdutosEstoque.Name = "dtgProdutosEstoque";
            this.dtgProdutosEstoque.ReadOnly = true;
            this.dtgProdutosEstoque.RowHeadersVisible = false;
            this.dtgProdutosEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgProdutosEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutosEstoque.Size = new System.Drawing.Size(292, 403);
            this.dtgProdutosEstoque.TabIndex = 0;
            this.dtgProdutosEstoque.TabStop = false;
            this.dtgProdutosEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutosEstoque_CellDoubleClick);
            // 
            // dtgProdutosEstoqueNome
            // 
            this.dtgProdutosEstoqueNome.DataPropertyName = "NOME";
            this.dtgProdutosEstoqueNome.HeaderText = "Nome";
            this.dtgProdutosEstoqueNome.Name = "dtgProdutosEstoqueNome";
            this.dtgProdutosEstoqueNome.ReadOnly = true;
            // 
            // dtgProdutosEstoqueDetalhes
            // 
            this.dtgProdutosEstoqueDetalhes.DataPropertyName = "DETALHES";
            this.dtgProdutosEstoqueDetalhes.HeaderText = "Detalhes";
            this.dtgProdutosEstoqueDetalhes.Name = "dtgProdutosEstoqueDetalhes";
            this.dtgProdutosEstoqueDetalhes.ReadOnly = true;
            this.dtgProdutosEstoqueDetalhes.Width = 187;
            // 
            // dtgProdutosEstoqueIdCategoria
            // 
            this.dtgProdutosEstoqueIdCategoria.DataPropertyName = "ID_CATEGORIA";
            this.dtgProdutosEstoqueIdCategoria.HeaderText = "idCategoria";
            this.dtgProdutosEstoqueIdCategoria.Name = "dtgProdutosEstoqueIdCategoria";
            this.dtgProdutosEstoqueIdCategoria.ReadOnly = true;
            this.dtgProdutosEstoqueIdCategoria.Visible = false;
            // 
            // dtgProdutosEstoqueIdProduto
            // 
            this.dtgProdutosEstoqueIdProduto.DataPropertyName = "ID_PRODUTO";
            this.dtgProdutosEstoqueIdProduto.HeaderText = "ID_PRODUTO";
            this.dtgProdutosEstoqueIdProduto.Name = "dtgProdutosEstoqueIdProduto";
            this.dtgProdutosEstoqueIdProduto.ReadOnly = true;
            this.dtgProdutosEstoqueIdProduto.Visible = false;
            // 
            // dtgProdutosEstoqueCodigoBarras
            // 
            this.dtgProdutosEstoqueCodigoBarras.DataPropertyName = "CODIGO_BARRAS";
            this.dtgProdutosEstoqueCodigoBarras.HeaderText = "codigoBarras";
            this.dtgProdutosEstoqueCodigoBarras.Name = "dtgProdutosEstoqueCodigoBarras";
            this.dtgProdutosEstoqueCodigoBarras.ReadOnly = true;
            this.dtgProdutosEstoqueCodigoBarras.Visible = false;
            // 
            // dtgProdutosEstoqueCadastro
            // 
            this.dtgProdutosEstoqueCadastro.DataPropertyName = "DATA_CADASTRO";
            this.dtgProdutosEstoqueCadastro.HeaderText = "dataCadastro";
            this.dtgProdutosEstoqueCadastro.Name = "dtgProdutosEstoqueCadastro";
            this.dtgProdutosEstoqueCadastro.ReadOnly = true;
            this.dtgProdutosEstoqueCadastro.Visible = false;
            // 
            // dtgProdutosEstoqueEstoqueMinimo
            // 
            this.dtgProdutosEstoqueEstoqueMinimo.DataPropertyName = "ESTOQUE_MINIMO";
            this.dtgProdutosEstoqueEstoqueMinimo.HeaderText = "estoqueMinimo";
            this.dtgProdutosEstoqueEstoqueMinimo.Name = "dtgProdutosEstoqueEstoqueMinimo";
            this.dtgProdutosEstoqueEstoqueMinimo.ReadOnly = true;
            this.dtgProdutosEstoqueEstoqueMinimo.Visible = false;
            // 
            // dtgProdutosEstoqueEstoqueAtual
            // 
            this.dtgProdutosEstoqueEstoqueAtual.DataPropertyName = "ESTOQUE_ATUAL";
            this.dtgProdutosEstoqueEstoqueAtual.HeaderText = "estoqueAtual";
            this.dtgProdutosEstoqueEstoqueAtual.Name = "dtgProdutosEstoqueEstoqueAtual";
            this.dtgProdutosEstoqueEstoqueAtual.ReadOnly = true;
            this.dtgProdutosEstoqueEstoqueAtual.Visible = false;
            // 
            // dtgProdutosEstoqueCompra
            // 
            this.dtgProdutosEstoqueCompra.DataPropertyName = "VALOR_COMPRA";
            this.dtgProdutosEstoqueCompra.HeaderText = "valorCompra";
            this.dtgProdutosEstoqueCompra.Name = "dtgProdutosEstoqueCompra";
            this.dtgProdutosEstoqueCompra.ReadOnly = true;
            this.dtgProdutosEstoqueCompra.Visible = false;
            // 
            // dtgProdutosEstoqueVenda
            // 
            this.dtgProdutosEstoqueVenda.DataPropertyName = "VALOR_VENDA";
            this.dtgProdutosEstoqueVenda.HeaderText = "valorVenda";
            this.dtgProdutosEstoqueVenda.Name = "dtgProdutosEstoqueVenda";
            this.dtgProdutosEstoqueVenda.ReadOnly = true;
            this.dtgProdutosEstoqueVenda.Visible = false;
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.AllowUserToResizeRows = false;
            this.dtgProdutos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgProdutosIdProduto,
            this.dtgProdutosCodigoBarras,
            this.dtgProdutosNome,
            this.dtgProdutosDetalhes,
            this.dtgProdutosNomeCategoria,
            this.dtgProdutosEstoqueAtual,
            this.dtgProdutosVenda,
            this.dtgProdutosCadastro,
            this.dtgProdutosCompra,
            this.dtgProdutosEstoqueMinimo,
            this.dtgProdutosIdCategoria,
            this.btnProdutosEditar,
            this.btnProdutosExcluir});
            this.dtgProdutos.Location = new System.Drawing.Point(12, 293);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(931, 198);
            this.dtgProdutos.TabIndex = 14;
            this.dtgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellContentClick);
            // 
            // dtgProdutosIdProduto
            // 
            this.dtgProdutosIdProduto.DataPropertyName = "ID_PRODUTO";
            this.dtgProdutosIdProduto.HeaderText = "idProduto";
            this.dtgProdutosIdProduto.Name = "dtgProdutosIdProduto";
            this.dtgProdutosIdProduto.ReadOnly = true;
            this.dtgProdutosIdProduto.Visible = false;
            // 
            // dtgProdutosCodigoBarras
            // 
            this.dtgProdutosCodigoBarras.DataPropertyName = "CODIGO_BARRAS";
            this.dtgProdutosCodigoBarras.HeaderText = "Código de Barras";
            this.dtgProdutosCodigoBarras.Name = "dtgProdutosCodigoBarras";
            this.dtgProdutosCodigoBarras.ReadOnly = true;
            this.dtgProdutosCodigoBarras.Width = 150;
            // 
            // dtgProdutosNome
            // 
            this.dtgProdutosNome.DataPropertyName = "NOME";
            this.dtgProdutosNome.HeaderText = "Nome";
            this.dtgProdutosNome.Name = "dtgProdutosNome";
            this.dtgProdutosNome.ReadOnly = true;
            this.dtgProdutosNome.Width = 150;
            // 
            // dtgProdutosDetalhes
            // 
            this.dtgProdutosDetalhes.DataPropertyName = "DETALHES";
            this.dtgProdutosDetalhes.HeaderText = "Detalhes";
            this.dtgProdutosDetalhes.Name = "dtgProdutosDetalhes";
            this.dtgProdutosDetalhes.ReadOnly = true;
            this.dtgProdutosDetalhes.Width = 200;
            // 
            // dtgProdutosNomeCategoria
            // 
            this.dtgProdutosNomeCategoria.DataPropertyName = "NOME_CATEGORIA";
            this.dtgProdutosNomeCategoria.HeaderText = "Categoria";
            this.dtgProdutosNomeCategoria.Name = "dtgProdutosNomeCategoria";
            this.dtgProdutosNomeCategoria.ReadOnly = true;
            // 
            // dtgProdutosEstoqueAtual
            // 
            this.dtgProdutosEstoqueAtual.DataPropertyName = "ESTOQUE_ATUAL";
            this.dtgProdutosEstoqueAtual.HeaderText = "Estoque";
            this.dtgProdutosEstoqueAtual.Name = "dtgProdutosEstoqueAtual";
            this.dtgProdutosEstoqueAtual.ReadOnly = true;
            this.dtgProdutosEstoqueAtual.Width = 70;
            // 
            // dtgProdutosVenda
            // 
            this.dtgProdutosVenda.DataPropertyName = "VALOR_VENDA";
            this.dtgProdutosVenda.HeaderText = "Venda";
            this.dtgProdutosVenda.Name = "dtgProdutosVenda";
            this.dtgProdutosVenda.ReadOnly = true;
            this.dtgProdutosVenda.Width = 80;
            // 
            // dtgProdutosCadastro
            // 
            this.dtgProdutosCadastro.DataPropertyName = "DATA_CADASTRO";
            this.dtgProdutosCadastro.HeaderText = "DataCadastro";
            this.dtgProdutosCadastro.Name = "dtgProdutosCadastro";
            this.dtgProdutosCadastro.ReadOnly = true;
            // 
            // dtgProdutosCompra
            // 
            this.dtgProdutosCompra.DataPropertyName = "VALOR_COMPRA";
            this.dtgProdutosCompra.HeaderText = "Compra";
            this.dtgProdutosCompra.Name = "dtgProdutosCompra";
            this.dtgProdutosCompra.ReadOnly = true;
            this.dtgProdutosCompra.Visible = false;
            // 
            // dtgProdutosEstoqueMinimo
            // 
            this.dtgProdutosEstoqueMinimo.DataPropertyName = "ESTOQUE_MINIMO";
            this.dtgProdutosEstoqueMinimo.HeaderText = "EstoqueMinimo";
            this.dtgProdutosEstoqueMinimo.Name = "dtgProdutosEstoqueMinimo";
            this.dtgProdutosEstoqueMinimo.ReadOnly = true;
            this.dtgProdutosEstoqueMinimo.Visible = false;
            // 
            // dtgProdutosIdCategoria
            // 
            this.dtgProdutosIdCategoria.DataPropertyName = "ID_CATEGORIA";
            this.dtgProdutosIdCategoria.HeaderText = "IdCategoria";
            this.dtgProdutosIdCategoria.Name = "dtgProdutosIdCategoria";
            this.dtgProdutosIdCategoria.ReadOnly = true;
            this.dtgProdutosIdCategoria.Visible = false;
            // 
            // btnProdutosEditar
            // 
            this.btnProdutosEditar.HeaderText = "";
            this.btnProdutosEditar.Image = global::Interface.Properties.Resources.lapis;
            this.btnProdutosEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnProdutosEditar.Name = "btnProdutosEditar";
            this.btnProdutosEditar.ReadOnly = true;
            this.btnProdutosEditar.Width = 25;
            // 
            // btnProdutosExcluir
            // 
            this.btnProdutosExcluir.HeaderText = "";
            this.btnProdutosExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutosExcluir.Image")));
            this.btnProdutosExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnProdutosExcluir.Name = "btnProdutosExcluir";
            this.btnProdutosExcluir.ReadOnly = true;
            this.btnProdutosExcluir.Width = 25;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 503);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.dtgProdutosEstoque);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dtpCadastro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.lbDetalhes);
            this.Controls.Add(this.tbCodigoBarras);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.lbCodigoBarras);
            this.Controls.Add(this.tbDetalhes);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SCF - Controle de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigoBarras;
        private System.Windows.Forms.TextBox tbCodigoBarras;
        private System.Windows.Forms.Label lbDetalhes;
        private System.Windows.Forms.TextBox tbDetalhes;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.TextBox tbEstoqueMinimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEstoqueAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCodigoBarras;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgProdutosEstoque;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueEstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueVenda;
        private System.Windows.Forms.ToolStripButton btnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosNomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgProdutosIdCategoria;
        private System.Windows.Forms.DataGridViewImageColumn btnProdutosEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnProdutosExcluir;
        private System.Windows.Forms.TextBox tbValorVenda;
        private System.Windows.Forms.TextBox tbValorCompra;
    }
}