namespace Interface
{
    partial class frmInicial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
			this.tsFerramentas = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClientes = new System.Windows.Forms.ToolStripButton();
			this.btnProdutos = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnLogout = new System.Windows.Forms.ToolStripButton();
			this.ssDadosUsuario = new System.Windows.Forms.StatusStrip();
			this.tsNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsLoginUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsNivelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsRelogio = new System.Windows.Forms.ToolStripStatusLabel();
			this.relogio = new System.Windows.Forms.Timer(this.components);
			this.btnVendas = new System.Windows.Forms.ToolStripButton();
			this.tsFerramentas.SuspendLayout();
			this.ssDadosUsuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsFerramentas
			// 
			this.tsFerramentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tsFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsFerramentas.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnClientes,
            this.btnProdutos,
            this.toolStripSeparator3,
            this.btnUsuarios,
            this.toolStripSeparator2,
            this.btnLogout,
            this.btnVendas});
			this.tsFerramentas.Location = new System.Drawing.Point(0, 0);
			this.tsFerramentas.Name = "tsFerramentas";
			this.tsFerramentas.Size = new System.Drawing.Size(985, 46);
			this.tsFerramentas.TabIndex = 0;
			this.tsFerramentas.Text = "Ferramentas";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
			// 
			// btnClientes
			// 
			this.btnClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
			this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(53, 43);
			this.btnClientes.Text = "Clientes";
			this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// btnProdutos
			// 
			this.btnProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
			this.btnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(59, 43);
			this.btnProdutos.Text = "Produtos";
			this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
			this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(56, 43);
			this.btnUsuarios.Text = "Usuários";
			this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
			// 
			// btnLogout
			// 
			this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(51, 43);
			this.btnLogout.Text = "LogOut";
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// ssDadosUsuario
			// 
			this.ssDadosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
			this.ssDadosUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNomeUsuario,
            this.tsLoginUsuario,
            this.tsNivelUsuario,
            this.tsData,
            this.tsRelogio});
			this.ssDadosUsuario.Location = new System.Drawing.Point(0, 46);
			this.ssDadosUsuario.Name = "ssDadosUsuario";
			this.ssDadosUsuario.Size = new System.Drawing.Size(985, 24);
			this.ssDadosUsuario.TabIndex = 1;
			this.ssDadosUsuario.Text = "statusStrip1";
			this.ssDadosUsuario.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssDadosUsuario_ItemClicked);
			// 
			// tsNomeUsuario
			// 
			this.tsNomeUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
			this.tsNomeUsuario.Name = "tsNomeUsuario";
			this.tsNomeUsuario.Size = new System.Drawing.Size(44, 19);
			this.tsNomeUsuario.Text = "Nome";
			this.tsNomeUsuario.Click += new System.EventHandler(this.tsNivelUsuario_Click);
			// 
			// tsLoginUsuario
			// 
			this.tsLoginUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsLoginUsuario.Name = "tsLoginUsuario";
			this.tsLoginUsuario.Size = new System.Drawing.Size(41, 19);
			this.tsLoginUsuario.Text = "Login";
			// 
			// tsNivelUsuario
			// 
			this.tsNivelUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsNivelUsuario.Name = "tsNivelUsuario";
			this.tsNivelUsuario.Size = new System.Drawing.Size(38, 19);
			this.tsNivelUsuario.Text = "Nível";
			this.tsNivelUsuario.Click += new System.EventHandler(this.tsNivelUsuario_Click);
			// 
			// tsData
			// 
			this.tsData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.tsData.Name = "tsData";
			this.tsData.Size = new System.Drawing.Size(35, 19);
			this.tsData.Text = "Data";
			// 
			// tsRelogio
			// 
			this.tsRelogio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tsRelogio.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
			this.tsRelogio.Name = "tsRelogio";
			this.tsRelogio.Size = new System.Drawing.Size(47, 19);
			this.tsRelogio.Text = "Relógio";
			this.tsRelogio.Click += new System.EventHandler(this.tsRelogio_Click);
			// 
			// relogio
			// 
			this.relogio.Enabled = true;
			this.relogio.Interval = 1000;
			this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
			// 
			// btnVendas
			// 
			this.btnVendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
			this.btnVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnVendas.Name = "btnVendas";
			this.btnVendas.Size = new System.Drawing.Size(48, 43);
			this.btnVendas.Text = "Vendas";
			this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
			// 
			// frmInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(985, 503);
			this.Controls.Add(this.ssDadosUsuario);
			this.Controls.Add(this.tsFerramentas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInicial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCF - Sistema de Controle de Farmácia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmInicial_Load);
			this.tsFerramentas.ResumeLayout(false);
			this.tsFerramentas.PerformLayout();
			this.ssDadosUsuario.ResumeLayout(false);
			this.ssDadosUsuario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsFerramentas;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnUsuarios;
		private System.Windows.Forms.StatusStrip ssDadosUsuario;
		private System.Windows.Forms.ToolStripStatusLabel tsLoginUsuario;
		private System.Windows.Forms.ToolStripStatusLabel tsNivelUsuario;
		private System.Windows.Forms.ToolStripStatusLabel tsData;
		private System.Windows.Forms.ToolStripStatusLabel tsNomeUsuario;
		private System.Windows.Forms.ToolStripButton btnLogout;
		private System.Windows.Forms.Timer relogio;
		private System.Windows.Forms.ToolStripStatusLabel tsRelogio;
		private System.Windows.Forms.ToolStripButton btnVendas;
	}
}