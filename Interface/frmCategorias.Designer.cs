namespace Interface
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.dtgCategoriasIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCategoriasNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCategoriasDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCategoriasEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCategoriasExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AllowUserToAddRows = false;
            this.dtgCategorias.AllowUserToDeleteRows = false;
            this.dtgCategorias.AllowUserToResizeColumns = false;
            this.dtgCategorias.AllowUserToResizeRows = false;
            this.dtgCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgCategoriasIdCategoria,
            this.dtgCategoriasNome,
            this.dtgCategoriasDescricao,
            this.btnCategoriasEditar,
            this.btnCategoriasExcluir});
            this.dtgCategorias.Location = new System.Drawing.Point(16, 168);
            this.dtgCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.ReadOnly = true;
            this.dtgCategorias.RowHeadersVisible = false;
            this.dtgCategorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategorias.Size = new System.Drawing.Size(547, 203);
            this.dtgCategorias.TabIndex = 0;
            this.dtgCategorias.TabStop = false;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // dtgCategoriasIdCategoria
            // 
            this.dtgCategoriasIdCategoria.DataPropertyName = "ID_CATEGORIA";
            this.dtgCategoriasIdCategoria.HeaderText = "Código";
            this.dtgCategoriasIdCategoria.Name = "dtgCategoriasIdCategoria";
            this.dtgCategoriasIdCategoria.ReadOnly = true;
            this.dtgCategoriasIdCategoria.Width = 70;
            // 
            // dtgCategoriasNome
            // 
            this.dtgCategoriasNome.DataPropertyName = "NOME";
            this.dtgCategoriasNome.HeaderText = "Nome";
            this.dtgCategoriasNome.Name = "dtgCategoriasNome";
            this.dtgCategoriasNome.ReadOnly = true;
            this.dtgCategoriasNome.Width = 150;
            // 
            // dtgCategoriasDescricao
            // 
            this.dtgCategoriasDescricao.DataPropertyName = "DESCRICAO";
            this.dtgCategoriasDescricao.HeaderText = "Descrição";
            this.dtgCategoriasDescricao.Name = "dtgCategoriasDescricao";
            this.dtgCategoriasDescricao.ReadOnly = true;
            this.dtgCategoriasDescricao.Width = 250;
            // 
            // btnCategoriasEditar
            // 
            this.btnCategoriasEditar.HeaderText = "";
            this.btnCategoriasEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriasEditar.Image")));
            this.btnCategoriasEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnCategoriasEditar.Name = "btnCategoriasEditar";
            this.btnCategoriasEditar.ReadOnly = true;
            this.btnCategoriasEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnCategoriasEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnCategoriasEditar.Width = 25;
            // 
            // btnCategoriasExcluir
            // 
            this.btnCategoriasExcluir.HeaderText = "";
            this.btnCategoriasExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriasExcluir.Image")));
            this.btnCategoriasExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnCategoriasExcluir.Name = "btnCategoriasExcluir";
            this.btnCategoriasExcluir.ReadOnly = true;
            this.btnCategoriasExcluir.Width = 25;
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
            this.toolStrip1.Size = new System.Drawing.Size(579, 38);
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
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCodigo.Location = new System.Drawing.Point(83, 61);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(71, 25);
            this.tbCodigo.TabIndex = 6;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Enabled = false;
            this.lbCodigo.Location = new System.Drawing.Point(24, 64);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(56, 17);
            this.lbCodigo.TabIndex = 7;
            this.lbCodigo.Text = "Código:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbNome.Location = new System.Drawing.Point(83, 110);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(246, 25);
            this.tbNome.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Enabled = false;
            this.lbNome.Location = new System.Drawing.Point(24, 113);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Enabled = false;
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbDescricao.Location = new System.Drawing.Point(338, 61);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(225, 74);
            this.tbDescricao.TabIndex = 10;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Enabled = false;
            this.lbDescricao.Location = new System.Drawing.Point(258, 64);
            this.lbDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 11;
            this.lbDescricao.Text = "Descrição:";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 379);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgCategorias);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SCF - Categoria dos produtos";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategorias;
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
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCategoriasIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCategoriasNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCategoriasDescricao;
        private System.Windows.Forms.DataGridViewImageColumn btnCategoriasEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnCategoriasExcluir;
    }
}