namespace Interface
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnMostraSenha = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEscondeSenha = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(214, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 45);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tela de Acesso";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(156, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Usuário:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(156, 331);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "Senha:";
			// 
			// tbUsuario
			// 
			this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsuario.Location = new System.Drawing.Point(271, 247);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(301, 35);
			this.tbUsuario.TabIndex = 1;
			this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
			this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
			// 
			// tbSenha
			// 
			this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSenha.Location = new System.Drawing.Point(271, 330);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.PasswordChar = '*';
			this.tbSenha.Size = new System.Drawing.Size(301, 35);
			this.tbSenha.TabIndex = 2;
			this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(214, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(505, 90);
			this.label4.TabIndex = 2;
			this.label4.Text = "Bem vindo ao SCF\r\nSistema de Controle de farmácia";
			// 
			// btnMostraSenha
			// 
			this.btnMostraSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMostraSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostraSenha.BackgroundImage")));
			this.btnMostraSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMostraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostraSenha.Location = new System.Drawing.Point(540, 333);
			this.btnMostraSenha.Name = "btnMostraSenha";
			this.btnMostraSenha.Size = new System.Drawing.Size(29, 30);
			this.btnMostraSenha.TabIndex = 6;
			this.btnMostraSenha.TabStop = false;
			this.btnMostraSenha.UseVisualStyleBackColor = false;
			this.btnMostraSenha.Click += new System.EventHandler(this.btnMostraSenha_Click);
			// 
			// btnSair
			// 
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
			this.btnSair.Location = new System.Drawing.Point(25, 397);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(103, 32);
			this.btnSair.TabIndex = 5;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnEntrar
			// 
			this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
			this.btnEntrar.Location = new System.Drawing.Point(604, 397);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(104, 32);
			this.btnEntrar.TabIndex = 5;
			this.btnEntrar.TabStop = false;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(25, 29);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 161);
			this.panel1.TabIndex = 0;
			// 
			// btnEscondeSenha
			// 
			this.btnEscondeSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEscondeSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEscondeSenha.BackgroundImage")));
			this.btnEscondeSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEscondeSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEscondeSenha.Location = new System.Drawing.Point(540, 333);
			this.btnEscondeSenha.Name = "btnEscondeSenha";
			this.btnEscondeSenha.Size = new System.Drawing.Size(29, 30);
			this.btnEscondeSenha.TabIndex = 6;
			this.btnEscondeSenha.TabStop = false;
			this.btnEscondeSenha.UseVisualStyleBackColor = false;
			this.btnEscondeSenha.Click += new System.EventHandler(this.btnEscondeSenha_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 464);
			this.Controls.Add(this.btnEscondeSenha);
			this.Controls.Add(this.btnMostraSenha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCF - Login";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnMostraSenha;
		private System.Windows.Forms.Button btnEscondeSenha;
	}
}