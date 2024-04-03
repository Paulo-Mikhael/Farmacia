namespace Interface
{
	partial class frmUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
			this.lbNome = new System.Windows.Forms.Label();
			this.lbLogin = new System.Windows.Forms.Label();
			this.lbSenha = new System.Windows.Forms.Label();
			this.lbStatus = new System.Windows.Forms.Label();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.lbNivel = new System.Windows.Forms.Label();
			this.lbReSenha = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.cbNivel = new System.Windows.Forms.ComboBox();
			this.tbReSenha = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.dtgUsuarios = new System.Windows.Forms.DataGridView();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.lbCadastro = new System.Windows.Forms.Label();
			this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
			this.lbCodigo = new System.Windows.Forms.Label();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.dtgUsuariosLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUsuariosEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnUsuariosExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			this.dtgUsuariosSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgUsuariosNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Enabled = false;
			this.lbNome.Location = new System.Drawing.Point(29, 105);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(61, 21);
			this.lbNome.TabIndex = 0;
			this.lbNome.Text = "Nome:";
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Enabled = false;
			this.lbLogin.Location = new System.Drawing.Point(29, 153);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(57, 21);
			this.lbLogin.TabIndex = 1;
			this.lbLogin.Text = "Login:";
			// 
			// lbSenha
			// 
			this.lbSenha.AutoSize = true;
			this.lbSenha.Enabled = false;
			this.lbSenha.Location = new System.Drawing.Point(29, 201);
			this.lbSenha.Name = "lbSenha";
			this.lbSenha.Size = new System.Drawing.Size(61, 21);
			this.lbSenha.TabIndex = 1;
			this.lbSenha.Text = "Senha:";
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Enabled = false;
			this.lbStatus.Location = new System.Drawing.Point(29, 249);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(61, 21);
			this.lbStatus.TabIndex = 1;
			this.lbStatus.Text = "Status:";
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(102, 102);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(469, 29);
			this.tbNome.TabIndex = 2;
			// 
			// tbLogin
			// 
			this.tbLogin.Enabled = false;
			this.tbLogin.Location = new System.Drawing.Point(102, 150);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(183, 29);
			this.tbLogin.TabIndex = 2;
			this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
			// 
			// tbSenha
			// 
			this.tbSenha.Enabled = false;
			this.tbSenha.Location = new System.Drawing.Point(102, 198);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.PasswordChar = '*';
			this.tbSenha.Size = new System.Drawing.Size(183, 29);
			this.tbSenha.TabIndex = 2;
			// 
			// lbNivel
			// 
			this.lbNivel.AutoSize = true;
			this.lbNivel.Enabled = false;
			this.lbNivel.Location = new System.Drawing.Point(306, 153);
			this.lbNivel.Name = "lbNivel";
			this.lbNivel.Size = new System.Drawing.Size(55, 21);
			this.lbNivel.TabIndex = 1;
			this.lbNivel.Text = "Nível:";
			// 
			// lbReSenha
			// 
			this.lbReSenha.AutoSize = true;
			this.lbReSenha.Enabled = false;
			this.lbReSenha.Location = new System.Drawing.Point(306, 201);
			this.lbReSenha.Name = "lbReSenha";
			this.lbReSenha.Size = new System.Drawing.Size(78, 21);
			this.lbReSenha.TabIndex = 1;
			this.lbReSenha.Text = "Redigite:";
			// 
			// cbStatus
			// 
			this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStatus.Enabled = false;
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
			this.cbStatus.Location = new System.Drawing.Point(102, 246);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(183, 29);
			this.cbStatus.TabIndex = 3;
			// 
			// cbNivel
			// 
			this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNivel.Enabled = false;
			this.cbNivel.FormattingEnabled = true;
			this.cbNivel.Location = new System.Drawing.Point(367, 150);
			this.cbNivel.Name = "cbNivel";
			this.cbNivel.Size = new System.Drawing.Size(204, 29);
			this.cbNivel.TabIndex = 3;
			// 
			// tbReSenha
			// 
			this.tbReSenha.Enabled = false;
			this.tbReSenha.Location = new System.Drawing.Point(388, 198);
			this.tbReSenha.Name = "tbReSenha";
			this.tbReSenha.PasswordChar = '*';
			this.tbReSenha.Size = new System.Drawing.Size(183, 29);
			this.tbReSenha.TabIndex = 2;
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
			this.toolStrip1.Size = new System.Drawing.Size(603, 38);
			this.toolStrip1.TabIndex = 4;
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
			// dtgUsuarios
			// 
			this.dtgUsuarios.AllowUserToAddRows = false;
			this.dtgUsuarios.AllowUserToDeleteRows = false;
			this.dtgUsuarios.AllowUserToResizeColumns = false;
			this.dtgUsuarios.AllowUserToResizeRows = false;
			this.dtgUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgUsuariosLogin,
            this.dtgUsuariosNomeNivel,
            this.dtgUsuariosStatus,
            this.btnUsuariosEditar,
            this.btnUsuariosExcluir,
            this.dtgUsuariosSenha,
            this.dtgUsuariosIdUsuario,
            this.dtgUsuariosNome,
            this.dtgUsuariosCadastro,
            this.dtgUsuariosNivel});
			this.dtgUsuarios.Location = new System.Drawing.Point(23, 305);
			this.dtgUsuarios.Name = "dtgUsuarios";
			this.dtgUsuarios.ReadOnly = true;
			this.dtgUsuarios.RowHeadersVisible = false;
			this.dtgUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgUsuarios.Size = new System.Drawing.Size(559, 197);
			this.dtgUsuarios.TabIndex = 5;
			this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Interface.Properties.Resources.lapis;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::Interface.Properties.Resources.excluir__2_;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			// 
			// lbCadastro
			// 
			this.lbCadastro.AutoSize = true;
			this.lbCadastro.Enabled = false;
			this.lbCadastro.Location = new System.Drawing.Point(306, 249);
			this.lbCadastro.Name = "lbCadastro";
			this.lbCadastro.Size = new System.Drawing.Size(119, 21);
			this.lbCadastro.TabIndex = 1;
			this.lbCadastro.Text = "Data cadastro:";
			// 
			// dtpCadastro
			// 
			this.dtpCadastro.Enabled = false;
			this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCadastro.Location = new System.Drawing.Point(431, 245);
			this.dtpCadastro.Name = "dtpCadastro";
			this.dtpCadastro.Size = new System.Drawing.Size(140, 29);
			this.dtpCadastro.TabIndex = 6;
			// 
			// lbCodigo
			// 
			this.lbCodigo.AutoSize = true;
			this.lbCodigo.Enabled = false;
			this.lbCodigo.Location = new System.Drawing.Point(29, 60);
			this.lbCodigo.Name = "lbCodigo";
			this.lbCodigo.Size = new System.Drawing.Size(69, 21);
			this.lbCodigo.TabIndex = 0;
			this.lbCodigo.Text = "Código:";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Enabled = false;
			this.tbCodigo.Location = new System.Drawing.Point(102, 57);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(58, 29);
			this.tbCodigo.TabIndex = 2;
			// 
			// dtgUsuariosLogin
			// 
			this.dtgUsuariosLogin.DataPropertyName = "LOGIN_USUARIO";
			this.dtgUsuariosLogin.HeaderText = "Login";
			this.dtgUsuariosLogin.Name = "dtgUsuariosLogin";
			this.dtgUsuariosLogin.ReadOnly = true;
			this.dtgUsuariosLogin.Width = 200;
			// 
			// dtgUsuariosNomeNivel
			// 
			this.dtgUsuariosNomeNivel.DataPropertyName = "NivelUsuario";
			this.dtgUsuariosNomeNivel.HeaderText = "Nível";
			this.dtgUsuariosNomeNivel.Name = "dtgUsuariosNomeNivel";
			this.dtgUsuariosNomeNivel.ReadOnly = true;
			this.dtgUsuariosNomeNivel.Width = 170;
			// 
			// dtgUsuariosStatus
			// 
			this.dtgUsuariosStatus.DataPropertyName = "STATUS_USUARIO";
			this.dtgUsuariosStatus.HeaderText = "Status";
			this.dtgUsuariosStatus.Name = "dtgUsuariosStatus";
			this.dtgUsuariosStatus.ReadOnly = true;
			// 
			// btnUsuariosEditar
			// 
			this.btnUsuariosEditar.HeaderText = "";
			this.btnUsuariosEditar.Image = global::Interface.Properties.Resources.lapis;
			this.btnUsuariosEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnUsuariosEditar.Name = "btnUsuariosEditar";
			this.btnUsuariosEditar.ReadOnly = true;
			this.btnUsuariosEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnUsuariosEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.btnUsuariosEditar.Width = 25;
			// 
			// btnUsuariosExcluir
			// 
			this.btnUsuariosExcluir.HeaderText = "";
			this.btnUsuariosExcluir.Image = global::Interface.Properties.Resources.excluir__2_;
			this.btnUsuariosExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnUsuariosExcluir.Name = "btnUsuariosExcluir";
			this.btnUsuariosExcluir.ReadOnly = true;
			this.btnUsuariosExcluir.Width = 25;
			// 
			// dtgUsuariosSenha
			// 
			this.dtgUsuariosSenha.DataPropertyName = "SENHA_USUARIO";
			this.dtgUsuariosSenha.HeaderText = "Senha";
			this.dtgUsuariosSenha.Name = "dtgUsuariosSenha";
			this.dtgUsuariosSenha.ReadOnly = true;
			this.dtgUsuariosSenha.Visible = false;
			// 
			// dtgUsuariosIdUsuario
			// 
			this.dtgUsuariosIdUsuario.DataPropertyName = "ID_USUARIO";
			this.dtgUsuariosIdUsuario.HeaderText = "IdUsuario";
			this.dtgUsuariosIdUsuario.Name = "dtgUsuariosIdUsuario";
			this.dtgUsuariosIdUsuario.ReadOnly = true;
			this.dtgUsuariosIdUsuario.Visible = false;
			// 
			// dtgUsuariosNome
			// 
			this.dtgUsuariosNome.DataPropertyName = "NOME";
			this.dtgUsuariosNome.HeaderText = "Nome";
			this.dtgUsuariosNome.Name = "dtgUsuariosNome";
			this.dtgUsuariosNome.ReadOnly = true;
			this.dtgUsuariosNome.Visible = false;
			// 
			// dtgUsuariosCadastro
			// 
			this.dtgUsuariosCadastro.DataPropertyName = "DATA_CADASTRO";
			this.dtgUsuariosCadastro.HeaderText = "DataCadastro";
			this.dtgUsuariosCadastro.Name = "dtgUsuariosCadastro";
			this.dtgUsuariosCadastro.ReadOnly = true;
			this.dtgUsuariosCadastro.Visible = false;
			// 
			// dtgUsuariosNivel
			// 
			this.dtgUsuariosNivel.DataPropertyName = "NIVEL_USUARIO";
			this.dtgUsuariosNivel.HeaderText = "nivelUsuario";
			this.dtgUsuariosNivel.Name = "dtgUsuariosNivel";
			this.dtgUsuariosNivel.ReadOnly = true;
			this.dtgUsuariosNivel.Visible = false;
			this.dtgUsuariosNivel.Width = 170;
			// 
			// frmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 513);
			this.Controls.Add(this.dtpCadastro);
			this.Controls.Add(this.dtgUsuarios);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.cbNivel);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.tbReSenha);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.tbCodigo);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.lbSenha);
			this.Controls.Add(this.lbCadastro);
			this.Controls.Add(this.lbReSenha);
			this.Controls.Add(this.lbNivel);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.lbCodigo);
			this.Controls.Add(this.lbNome);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SCF - Controle de Usuarios";
			this.Load += new System.EventHandler(this.frmUsuarios_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.Label lbSenha;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbSenha;
		private System.Windows.Forms.Label lbNivel;
		private System.Windows.Forms.Label lbReSenha;
		private System.Windows.Forms.ComboBox cbStatus;
		private System.Windows.Forms.ComboBox cbNivel;
		private System.Windows.Forms.TextBox tbReSenha;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSalvar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnExcluir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnAdicionar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.DataGridView dtgUsuarios;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.Label lbCadastro;
		private System.Windows.Forms.DateTimePicker dtpCadastro;
		private System.Windows.Forms.Label lbCodigo;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosLogin;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosNomeNivel;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosStatus;
		private System.Windows.Forms.DataGridViewImageColumn btnUsuariosEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnUsuariosExcluir;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosSenha;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosIdUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosCadastro;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgUsuariosNivel;
	}
}