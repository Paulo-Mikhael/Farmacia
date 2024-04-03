namespace Interface
{
	partial class frmVendas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
			this.gbProduto = new System.Windows.Forms.GroupBox();
			this.btnDigitarCod = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbProduto = new System.Windows.Forms.TextBox();
			this.gbDetalhes = new System.Windows.Forms.GroupBox();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.lbUsuario = new System.Windows.Forms.Label();
			this.lbData = new System.Windows.Forms.Label();
			this.lbNomeCliente = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbItemDestaque = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbDescricaoProduto = new System.Windows.Forms.Label();
			this.lbTotalProduto = new System.Windows.Forms.Label();
			this.lbQuantidadeProduto = new System.Windows.Forms.Label();
			this.lbPrecoProduto = new System.Windows.Forms.Label();
			this.lbNomeProduto = new System.Windows.Forms.Label();
			this.dtgDetalhesVenda = new System.Windows.Forms.DataGridView();
			this.dtgDetalhesVendaIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaCodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaDetalhesProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDetalhesVendaSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDetalhesVendasMenosUm = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnDetalhesVendasRemover = new System.Windows.Forms.DataGridViewImageColumn();
			this.label19 = new System.Windows.Forms.Label();
			this.lbSubtotal = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCancelar = new System.Windows.Forms.ToolStripButton();
			this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Relogio = new System.Windows.Forms.Timer(this.components);
			this.btnRemoverCliente = new System.Windows.Forms.Button();
			this.gbProduto.SuspendLayout();
			this.gbDetalhes.SuspendLayout();
			this.gbItemDestaque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalhesVenda)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbProduto
			// 
			this.gbProduto.BackColor = System.Drawing.SystemColors.ControlLight;
			this.gbProduto.Controls.Add(this.btnDigitarCod);
			this.gbProduto.Controls.Add(this.label1);
			this.gbProduto.Controls.Add(this.tbProduto);
			this.gbProduto.Location = new System.Drawing.Point(22, 23);
			this.gbProduto.Margin = new System.Windows.Forms.Padding(5);
			this.gbProduto.Name = "gbProduto";
			this.gbProduto.Padding = new System.Windows.Forms.Padding(5);
			this.gbProduto.Size = new System.Drawing.Size(367, 159);
			this.gbProduto.TabIndex = 0;
			this.gbProduto.TabStop = false;
			this.gbProduto.Text = "Produto por código";
			// 
			// btnDigitarCod
			// 
			this.btnDigitarCod.Image = global::Interface.Properties.Resources.codigo_de_barras;
			this.btnDigitarCod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDigitarCod.Location = new System.Drawing.Point(239, 104);
			this.btnDigitarCod.Name = "btnDigitarCod";
			this.btnDigitarCod.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnDigitarCod.Size = new System.Drawing.Size(110, 31);
			this.btnDigitarCod.TabIndex = 2;
			this.btnDigitarCod.Text = "Digitar";
			this.btnDigitarCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDigitarCod.UseVisualStyleBackColor = true;
			this.btnDigitarCod.Click += new System.EventHandler(this.btnDigitarCod_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Entre com o código de barras \r\ndo produto";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbProduto
			// 
			this.tbProduto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbProduto.Location = new System.Drawing.Point(16, 42);
			this.tbProduto.Name = "tbProduto";
			this.tbProduto.Size = new System.Drawing.Size(334, 36);
			this.tbProduto.TabIndex = 0;
			this.tbProduto.TextChanged += new System.EventHandler(this.tbProduto_TextChanged);
			// 
			// gbDetalhes
			// 
			this.gbDetalhes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.gbDetalhes.Controls.Add(this.btnRemoverCliente);
			this.gbDetalhes.Controls.Add(this.btnPesquisa);
			this.gbDetalhes.Controls.Add(this.lbUsuario);
			this.gbDetalhes.Controls.Add(this.lbData);
			this.gbDetalhes.Controls.Add(this.lbNomeCliente);
			this.gbDetalhes.Controls.Add(this.label6);
			this.gbDetalhes.Controls.Add(this.label4);
			this.gbDetalhes.Controls.Add(this.label2);
			this.gbDetalhes.Location = new System.Drawing.Point(419, 23);
			this.gbDetalhes.Name = "gbDetalhes";
			this.gbDetalhes.Size = new System.Drawing.Size(450, 158);
			this.gbDetalhes.TabIndex = 1;
			this.gbDetalhes.TabStop = false;
			this.gbDetalhes.Text = "Detalhes da Venda";
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnPesquisa.BackgroundImage = global::Interface.Properties.Resources.lupa;
			this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPesquisa.Location = new System.Drawing.Point(367, 40);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(40, 40);
			this.btnPesquisa.TabIndex = 2;
			this.btnPesquisa.UseVisualStyleBackColor = false;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// lbUsuario
			// 
			this.lbUsuario.AutoSize = true;
			this.lbUsuario.Location = new System.Drawing.Point(183, 109);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(120, 21);
			this.lbUsuario.TabIndex = 3;
			this.lbUsuario.Text = "Administrador";
			// 
			// lbData
			// 
			this.lbData.AutoSize = true;
			this.lbData.Location = new System.Drawing.Point(9, 109);
			this.lbData.Name = "lbData";
			this.lbData.Size = new System.Drawing.Size(107, 21);
			this.lbData.TabIndex = 3;
			this.lbData.Text = "Data de hoje";
			// 
			// lbNomeCliente
			// 
			this.lbNomeCliente.AutoSize = true;
			this.lbNomeCliente.Location = new System.Drawing.Point(9, 52);
			this.lbNomeCliente.Name = "lbNomeCliente";
			this.lbNomeCliente.Size = new System.Drawing.Size(251, 21);
			this.lbNomeCliente.TabIndex = 3;
			this.lbNomeCliente.Text = "Não informado para esta venda";
			this.lbNomeCliente.Click += new System.EventHandler(this.lbNomeCliente_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(184, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Usuário";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Data";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome do cliente";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbItemDestaque
			// 
			this.gbItemDestaque.Controls.Add(this.label17);
			this.gbItemDestaque.Controls.Add(this.label18);
			this.gbItemDestaque.Controls.Add(this.label16);
			this.gbItemDestaque.Controls.Add(this.label10);
			this.gbItemDestaque.Controls.Add(this.label8);
			this.gbItemDestaque.Controls.Add(this.label12);
			this.gbItemDestaque.Controls.Add(this.lbDescricaoProduto);
			this.gbItemDestaque.Controls.Add(this.lbTotalProduto);
			this.gbItemDestaque.Controls.Add(this.lbQuantidadeProduto);
			this.gbItemDestaque.Controls.Add(this.lbPrecoProduto);
			this.gbItemDestaque.Controls.Add(this.lbNomeProduto);
			this.gbItemDestaque.Location = new System.Drawing.Point(22, 196);
			this.gbItemDestaque.Name = "gbItemDestaque";
			this.gbItemDestaque.Size = new System.Drawing.Size(846, 146);
			this.gbItemDestaque.TabIndex = 2;
			this.gbItemDestaque.TabStop = false;
			this.gbItemDestaque.Text = "Item em destaque";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label17.Location = new System.Drawing.Point(658, 80);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(77, 16);
			this.label17.TabIndex = 2;
			this.label17.Text = "Quantidade";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label18.Location = new System.Drawing.Point(761, 80);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 16);
			this.label18.TabIndex = 2;
			this.label18.Text = "Total";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label16.Location = new System.Drawing.Point(563, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(43, 16);
			this.label16.TabIndex = 2;
			this.label16.Text = "Preço";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(10, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Descrição";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(10, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Nome do produto";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(637, 103);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 21);
			this.label12.TabIndex = 3;
			this.label12.Text = "X";
			// 
			// lbDescricaoProduto
			// 
			this.lbDescricaoProduto.AutoSize = true;
			this.lbDescricaoProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbDescricaoProduto.Location = new System.Drawing.Point(9, 103);
			this.lbDescricaoProduto.Name = "lbDescricaoProduto";
			this.lbDescricaoProduto.Size = new System.Drawing.Size(306, 21);
			this.lbDescricaoProduto.TabIndex = 3;
			this.lbDescricaoProduto.Text = "DEscriçãoDEscriçãoDEscriçãoDEscrição";
			this.lbDescricaoProduto.Visible = false;
			// 
			// lbTotalProduto
			// 
			this.lbTotalProduto.AutoSize = true;
			this.lbTotalProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbTotalProduto.Location = new System.Drawing.Point(764, 103);
			this.lbTotalProduto.Name = "lbTotalProduto";
			this.lbTotalProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbTotalProduto.Size = new System.Drawing.Size(68, 21);
			this.lbTotalProduto.TabIndex = 3;
			this.lbTotalProduto.Text = "1000,00";
			this.lbTotalProduto.Visible = false;
			// 
			// lbQuantidadeProduto
			// 
			this.lbQuantidadeProduto.AutoSize = true;
			this.lbQuantidadeProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbQuantidadeProduto.Location = new System.Drawing.Point(661, 103);
			this.lbQuantidadeProduto.Name = "lbQuantidadeProduto";
			this.lbQuantidadeProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbQuantidadeProduto.Size = new System.Drawing.Size(68, 21);
			this.lbQuantidadeProduto.TabIndex = 3;
			this.lbQuantidadeProduto.Text = "1000,00";
			this.lbQuantidadeProduto.Visible = false;
			// 
			// lbPrecoProduto
			// 
			this.lbPrecoProduto.AutoSize = true;
			this.lbPrecoProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbPrecoProduto.Location = new System.Drawing.Point(566, 103);
			this.lbPrecoProduto.Name = "lbPrecoProduto";
			this.lbPrecoProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbPrecoProduto.Size = new System.Drawing.Size(68, 21);
			this.lbPrecoProduto.TabIndex = 3;
			this.lbPrecoProduto.Text = "1000,00";
			this.lbPrecoProduto.Visible = false;
			// 
			// lbNomeProduto
			// 
			this.lbNomeProduto.AutoSize = true;
			this.lbNomeProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbNomeProduto.Location = new System.Drawing.Point(9, 49);
			this.lbNomeProduto.Name = "lbNomeProduto";
			this.lbNomeProduto.Size = new System.Drawing.Size(72, 21);
			this.lbNomeProduto.TabIndex = 3;
			this.lbNomeProduto.Text = "Produto";
			this.lbNomeProduto.Visible = false;
			// 
			// dtgDetalhesVenda
			// 
			this.dtgDetalhesVenda.AllowUserToAddRows = false;
			this.dtgDetalhesVenda.AllowUserToDeleteRows = false;
			this.dtgDetalhesVenda.AllowUserToResizeColumns = false;
			this.dtgDetalhesVenda.AllowUserToResizeRows = false;
			this.dtgDetalhesVenda.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dtgDetalhesVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDetalhesVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgDetalhesVendaIdProduto,
            this.dtgDetalhesVendaCodBarras,
            this.dtgDetalhesVendaNomeProduto,
            this.dtgDetalhesVendaDetalhesProduto,
            this.dtgDetalhesVendaValorUnitario,
            this.dtgDetalhesVendaQuantidade,
            this.dtgDetalhesVendaSubtotal,
            this.btnDetalhesVendasMenosUm,
            this.btnDetalhesVendasRemover});
			this.dtgDetalhesVenda.Location = new System.Drawing.Point(22, 369);
			this.dtgDetalhesVenda.Name = "dtgDetalhesVenda";
			this.dtgDetalhesVenda.ReadOnly = true;
			this.dtgDetalhesVenda.RowHeadersVisible = false;
			this.dtgDetalhesVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgDetalhesVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgDetalhesVenda.Size = new System.Drawing.Size(846, 228);
			this.dtgDetalhesVenda.TabIndex = 3;
			this.dtgDetalhesVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalhesVenda_CellContentClick);
			// 
			// dtgDetalhesVendaIdProduto
			// 
			this.dtgDetalhesVendaIdProduto.DataPropertyName = "ID_PRODUTO";
			this.dtgDetalhesVendaIdProduto.HeaderText = "idProduto";
			this.dtgDetalhesVendaIdProduto.Name = "dtgDetalhesVendaIdProduto";
			this.dtgDetalhesVendaIdProduto.ReadOnly = true;
			this.dtgDetalhesVendaIdProduto.Visible = false;
			// 
			// dtgDetalhesVendaCodBarras
			// 
			this.dtgDetalhesVendaCodBarras.DataPropertyName = "CODIGO_BARRAS";
			this.dtgDetalhesVendaCodBarras.HeaderText = "Cód. Barras";
			this.dtgDetalhesVendaCodBarras.Name = "dtgDetalhesVendaCodBarras";
			this.dtgDetalhesVendaCodBarras.ReadOnly = true;
			this.dtgDetalhesVendaCodBarras.Width = 118;
			// 
			// dtgDetalhesVendaNomeProduto
			// 
			this.dtgDetalhesVendaNomeProduto.DataPropertyName = "NOME";
			this.dtgDetalhesVendaNomeProduto.HeaderText = "Nome";
			this.dtgDetalhesVendaNomeProduto.Name = "dtgDetalhesVendaNomeProduto";
			this.dtgDetalhesVendaNomeProduto.ReadOnly = true;
			this.dtgDetalhesVendaNomeProduto.Width = 160;
			// 
			// dtgDetalhesVendaDetalhesProduto
			// 
			this.dtgDetalhesVendaDetalhesProduto.DataPropertyName = "DETALHES";
			this.dtgDetalhesVendaDetalhesProduto.HeaderText = "Detalhes";
			this.dtgDetalhesVendaDetalhesProduto.Name = "dtgDetalhesVendaDetalhesProduto";
			this.dtgDetalhesVendaDetalhesProduto.ReadOnly = true;
			this.dtgDetalhesVendaDetalhesProduto.Width = 200;
			// 
			// dtgDetalhesVendaValorUnitario
			// 
			this.dtgDetalhesVendaValorUnitario.DataPropertyName = "VALOR_VENDA";
			this.dtgDetalhesVendaValorUnitario.HeaderText = "Valor Unitário";
			this.dtgDetalhesVendaValorUnitario.Name = "dtgDetalhesVendaValorUnitario";
			this.dtgDetalhesVendaValorUnitario.ReadOnly = true;
			this.dtgDetalhesVendaValorUnitario.Width = 140;
			// 
			// dtgDetalhesVendaQuantidade
			// 
			this.dtgDetalhesVendaQuantidade.DataPropertyName = "QUANTIDADE";
			this.dtgDetalhesVendaQuantidade.HeaderText = "Qtde.";
			this.dtgDetalhesVendaQuantidade.Name = "dtgDetalhesVendaQuantidade";
			this.dtgDetalhesVendaQuantidade.ReadOnly = true;
			this.dtgDetalhesVendaQuantidade.Width = 60;
			// 
			// dtgDetalhesVendaSubtotal
			// 
			this.dtgDetalhesVendaSubtotal.HeaderText = "Subtotal";
			this.dtgDetalhesVendaSubtotal.Name = "dtgDetalhesVendaSubtotal";
			this.dtgDetalhesVendaSubtotal.ReadOnly = true;
			this.dtgDetalhesVendaSubtotal.Width = 80;
			// 
			// btnDetalhesVendasMenosUm
			// 
			this.btnDetalhesVendasMenosUm.HeaderText = "";
			this.btnDetalhesVendasMenosUm.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhesVendasMenosUm.Image")));
			this.btnDetalhesVendasMenosUm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnDetalhesVendasMenosUm.Name = "btnDetalhesVendasMenosUm";
			this.btnDetalhesVendasMenosUm.ReadOnly = true;
			this.btnDetalhesVendasMenosUm.Width = 25;
			// 
			// btnDetalhesVendasRemover
			// 
			this.btnDetalhesVendasRemover.HeaderText = "";
			this.btnDetalhesVendasRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhesVendasRemover.Image")));
			this.btnDetalhesVendasRemover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnDetalhesVendasRemover.Name = "btnDetalhesVendasRemover";
			this.btnDetalhesVendasRemover.ReadOnly = true;
			this.btnDetalhesVendasRemover.Width = 25;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(637, 633);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(103, 30);
			this.label19.TabIndex = 3;
			this.label19.Text = "Subtotal:";
			// 
			// lbSubtotal
			// 
			this.lbSubtotal.AutoSize = true;
			this.lbSubtotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSubtotal.ForeColor = System.Drawing.Color.ForestGreen;
			this.lbSubtotal.Location = new System.Drawing.Point(746, 633);
			this.lbSubtotal.Name = "lbSubtotal";
			this.lbSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbSubtotal.Size = new System.Drawing.Size(87, 30);
			this.lbSubtotal.TabIndex = 3;
			this.lbSubtotal.Text = "R$ 0,00";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripSeparator4,
            this.btnCancelar,
            this.btnFinalizar,
            this.toolStripSeparator1,
            this.toolStripSeparator3});
			this.toolStrip1.Location = new System.Drawing.Point(896, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(105, 669);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(102, 6);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(102, 6);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(102, 51);
			this.btnCancelar.Text = "Cancelar e Fechar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancelar.ToolTipText = "Cancela a operação e fecha a venda";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
			this.btnFinalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(102, 51);
			this.btnFinalizar.Text = "Salvar e Finalizar";
			this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFinalizar.ToolTipText = "Salva a operação e finaliza a venda";
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(102, 6);
			// 
			// Relogio
			// 
			this.Relogio.Enabled = true;
			this.Relogio.Interval = 1000;
			this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
			// 
			// btnRemoverCliente
			// 
			this.btnRemoverCliente.BackColor = System.Drawing.Color.Transparent;
			this.btnRemoverCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoverCliente.BackgroundImage")));
			this.btnRemoverCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRemoverCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoverCliente.FlatAppearance.BorderSize = 0;
			this.btnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverCliente.Location = new System.Drawing.Point(119, 28);
			this.btnRemoverCliente.Name = "btnRemoverCliente";
			this.btnRemoverCliente.Size = new System.Drawing.Size(20, 20);
			this.btnRemoverCliente.TabIndex = 0;
			this.btnRemoverCliente.UseVisualStyleBackColor = false;
			this.btnRemoverCliente.Visible = false;
			this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
			// 
			// frmVendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 669);
			this.ControlBox = false;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dtgDetalhesVenda);
			this.Controls.Add(this.gbItemDestaque);
			this.Controls.Add(this.gbDetalhes);
			this.Controls.Add(this.lbSubtotal);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.gbProduto);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "frmVendas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCF - Controle de Vendas";
			this.Load += new System.EventHandler(this.frmVendas_Load);
			this.gbProduto.ResumeLayout(false);
			this.gbProduto.PerformLayout();
			this.gbDetalhes.ResumeLayout(false);
			this.gbDetalhes.PerformLayout();
			this.gbItemDestaque.ResumeLayout(false);
			this.gbItemDestaque.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalhesVenda)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbProduto;
		private System.Windows.Forms.GroupBox gbDetalhes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbNomeCliente;
		private System.Windows.Forms.Label lbData;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.Label lbUsuario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gbItemDestaque;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbNomeProduto;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbDescricaoProduto;
		private System.Windows.Forms.Label lbPrecoProduto;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbTotalProduto;
		private System.Windows.Forms.Label lbQuantidadeProduto;
		private System.Windows.Forms.DataGridView dtgDetalhesVenda;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lbSubtotal;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnFinalizar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnCancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaIdProduto;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaCodBarras;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaNomeProduto;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaDetalhesProduto;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaValorUnitario;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaQuantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetalhesVendaSubtotal;
		private System.Windows.Forms.DataGridViewImageColumn btnDetalhesVendasMenosUm;
		private System.Windows.Forms.DataGridViewImageColumn btnDetalhesVendasRemover;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Timer Relogio;
		private System.Windows.Forms.Button btnDigitarCod;
		private System.Windows.Forms.Button btnRemoverCliente;
	}
}