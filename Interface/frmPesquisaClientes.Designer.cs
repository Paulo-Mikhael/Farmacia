namespace LogicaNegocio
{
	partial class frmPesquisaClientes
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
			this.tbProduto = new System.Windows.Forms.TextBox();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.rbCpf = new System.Windows.Forms.RadioButton();
			this.btnAdicionar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
			this.SuspendLayout();
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
            this.dtgIdCliente});
			this.dtgClientes.Location = new System.Drawing.Point(11, 144);
			this.dtgClientes.Margin = new System.Windows.Forms.Padding(2);
			this.dtgClientes.Name = "dtgClientes";
			this.dtgClientes.ReadOnly = true;
			this.dtgClientes.RowHeadersVisible = false;
			this.dtgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgClientes.Size = new System.Drawing.Size(904, 230);
			this.dtgClientes.TabIndex = 1;
			this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
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
			// tbProduto
			// 
			this.tbProduto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbProduto.Location = new System.Drawing.Point(264, 33);
			this.tbProduto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbProduto.Name = "tbProduto";
			this.tbProduto.Size = new System.Drawing.Size(399, 36);
			this.tbProduto.TabIndex = 2;
			this.tbProduto.TextChanged += new System.EventHandler(this.tbProduto_TextChanged);
			// 
			// rbNome
			// 
			this.rbNome.AutoSize = true;
			this.rbNome.Location = new System.Drawing.Point(405, 91);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(63, 21);
			this.rbNome.TabIndex = 3;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// rbCpf
			// 
			this.rbCpf.AutoSize = true;
			this.rbCpf.Location = new System.Drawing.Point(474, 91);
			this.rbCpf.Name = "rbCpf";
			this.rbCpf.Size = new System.Drawing.Size(49, 21);
			this.rbCpf.TabIndex = 4;
			this.rbCpf.TabStop = true;
			this.rbCpf.Text = "CPF";
			this.rbCpf.UseVisualStyleBackColor = true;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnAdicionar.ForeColor = System.Drawing.Color.DarkGreen;
			this.btnAdicionar.Location = new System.Drawing.Point(177, 398);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(575, 42);
			this.btnAdicionar.TabIndex = 5;
			this.btnAdicionar.Text = "Adicionar o cliente";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// frmPesquisaClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(929, 452);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.rbCpf);
			this.Controls.Add(this.rbNome);
			this.Controls.Add(this.tbProduto);
			this.Controls.Add(this.dtgClientes);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimizeBox = false;
			this.Name = "frmPesquisaClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pesquise um cliente";
			this.Load += new System.EventHandler(this.frmPesquisaClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgClientes;
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
		private System.Windows.Forms.TextBox tbProduto;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.RadioButton rbCpf;
		private System.Windows.Forms.Button btnAdicionar;
	}
}