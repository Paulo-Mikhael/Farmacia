namespace Interface
{
	partial class frmPesquisarProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProdutos));
			this.tbProduto = new System.Windows.Forms.TextBox();
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
			this.lbQuantidade = new System.Windows.Forms.Label();
			this.tbQuantidade = new System.Windows.Forms.TextBox();
			this.btnAdicionar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
			this.SuspendLayout();
			// 
			// tbProduto
			// 
			this.tbProduto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbProduto.Location = new System.Drawing.Point(29, 22);
			this.tbProduto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbProduto.Name = "tbProduto";
			this.tbProduto.Size = new System.Drawing.Size(399, 36);
			this.tbProduto.TabIndex = 1;
			this.tbProduto.TextChanged += new System.EventHandler(this.tbProduto_TextChanged);
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
            this.dtgProdutosIdCategoria});
			this.dtgProdutos.Location = new System.Drawing.Point(14, 98);
			this.dtgProdutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.dtgProdutos.Name = "dtgProdutos";
			this.dtgProdutos.ReadOnly = true;
			this.dtgProdutos.RowHeadersVisible = false;
			this.dtgProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgProdutos.Size = new System.Drawing.Size(437, 259);
			this.dtgProdutos.TabIndex = 15;
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
			this.dtgProdutosCodigoBarras.Width = 140;
			// 
			// dtgProdutosNome
			// 
			this.dtgProdutosNome.DataPropertyName = "NOME";
			this.dtgProdutosNome.HeaderText = "Nome";
			this.dtgProdutosNome.Name = "dtgProdutosNome";
			this.dtgProdutosNome.ReadOnly = true;
			this.dtgProdutosNome.Width = 140;
			// 
			// dtgProdutosDetalhes
			// 
			this.dtgProdutosDetalhes.DataPropertyName = "DETALHES";
			this.dtgProdutosDetalhes.HeaderText = "Detalhes";
			this.dtgProdutosDetalhes.Name = "dtgProdutosDetalhes";
			this.dtgProdutosDetalhes.ReadOnly = true;
			this.dtgProdutosDetalhes.Width = 130;
			// 
			// dtgProdutosNomeCategoria
			// 
			this.dtgProdutosNomeCategoria.DataPropertyName = "NOME_CATEGORIA";
			this.dtgProdutosNomeCategoria.HeaderText = "Categoria";
			this.dtgProdutosNomeCategoria.Name = "dtgProdutosNomeCategoria";
			this.dtgProdutosNomeCategoria.ReadOnly = true;
			this.dtgProdutosNomeCategoria.Visible = false;
			// 
			// dtgProdutosEstoqueAtual
			// 
			this.dtgProdutosEstoqueAtual.DataPropertyName = "ESTOQUE_ATUAL";
			this.dtgProdutosEstoqueAtual.HeaderText = "Estoque";
			this.dtgProdutosEstoqueAtual.Name = "dtgProdutosEstoqueAtual";
			this.dtgProdutosEstoqueAtual.ReadOnly = true;
			this.dtgProdutosEstoqueAtual.Visible = false;
			this.dtgProdutosEstoqueAtual.Width = 70;
			// 
			// dtgProdutosVenda
			// 
			this.dtgProdutosVenda.DataPropertyName = "VALOR_VENDA";
			this.dtgProdutosVenda.HeaderText = "Venda";
			this.dtgProdutosVenda.Name = "dtgProdutosVenda";
			this.dtgProdutosVenda.ReadOnly = true;
			this.dtgProdutosVenda.Visible = false;
			this.dtgProdutosVenda.Width = 80;
			// 
			// dtgProdutosCadastro
			// 
			this.dtgProdutosCadastro.DataPropertyName = "DATA_CADASTRO";
			this.dtgProdutosCadastro.HeaderText = "DataCadastro";
			this.dtgProdutosCadastro.Name = "dtgProdutosCadastro";
			this.dtgProdutosCadastro.ReadOnly = true;
			this.dtgProdutosCadastro.Visible = false;
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
			// lbQuantidade
			// 
			this.lbQuantidade.AutoSize = true;
			this.lbQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQuantidade.Location = new System.Drawing.Point(12, 376);
			this.lbQuantidade.Name = "lbQuantidade";
			this.lbQuantidade.Size = new System.Drawing.Size(104, 21);
			this.lbQuantidade.TabIndex = 16;
			this.lbQuantidade.Text = "Quantidade:";
			// 
			// tbQuantidade
			// 
			this.tbQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade.Location = new System.Drawing.Point(122, 373);
			this.tbQuantidade.Name = "tbQuantidade";
			this.tbQuantidade.Size = new System.Drawing.Size(58, 29);
			this.tbQuantidade.TabIndex = 17;
			this.tbQuantidade.Text = "1";
			this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbQuantidade.Leave += new System.EventHandler(this.tbQuantidade_Leave);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
			this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdicionar.Location = new System.Drawing.Point(340, 370);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(111, 32);
			this.btnAdicionar.TabIndex = 18;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdicionar.UseMnemonic = false;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// frmPesquisarProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(465, 412);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.tbQuantidade);
			this.Controls.Add(this.lbQuantidade);
			this.Controls.Add(this.dtgProdutos);
			this.Controls.Add(this.tbProduto);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "frmPesquisarProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Insira um código de barras";
			this.Load += new System.EventHandler(this.frmPesquisarProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbProduto;
		private System.Windows.Forms.DataGridView dtgProdutos;
		private System.Windows.Forms.Label lbQuantidade;
		private System.Windows.Forms.TextBox tbQuantidade;
		private System.Windows.Forms.Button btnAdicionar;
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
	}
}