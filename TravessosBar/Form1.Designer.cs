namespace TravessosBar
{
    partial class Form1
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
            this.login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.recuperarSenha = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invalido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AcceptsReturn = true;
            this.login.AcceptsTab = true;
            this.login.AccessibleDescription = "";
            this.login.AllowDrop = true;
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.login.BackColor = System.Drawing.Color.Azure;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(274, 225);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(312, 26);
            this.login.TabIndex = 1;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senha
            // 
            this.senha.AcceptsReturn = true;
            this.senha.AcceptsTab = true;
            this.senha.AllowDrop = true;
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.senha.BackColor = System.Drawing.Color.Azure;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(274, 292);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(312, 26);
            this.senha.TabIndex = 2;
            this.senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senha.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(394, 196);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(72, 26);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "LOGIN";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLabel.ForeColor = System.Drawing.Color.White;
            this.SenhaLabel.Location = new System.Drawing.Point(392, 263);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(76, 26);
            this.SenhaLabel.TabIndex = 4;
            this.SenhaLabel.Text = "SENHA";
            this.SenhaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.AllowDrop = true;
            this.botaoEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoEntrar.BackColor = System.Drawing.Color.Black;
            this.botaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoEntrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEntrar.ForeColor = System.Drawing.Color.White;
            this.botaoEntrar.Location = new System.Drawing.Point(389, 344);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(84, 30);
            this.botaoEntrar.TabIndex = 5;
            this.botaoEntrar.Text = "ENTRAR";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // recuperarSenha
            // 
            this.recuperarSenha.ActiveLinkColor = System.Drawing.Color.PaleTurquoise;
            this.recuperarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recuperarSenha.AutoSize = true;
            this.recuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recuperarSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperarSenha.LinkColor = System.Drawing.Color.Black;
            this.recuperarSenha.Location = new System.Drawing.Point(366, 391);
            this.recuperarSenha.Name = "recuperarSenha";
            this.recuperarSenha.Size = new System.Drawing.Size(128, 13);
            this.recuperarSenha.TabIndex = 7;
            this.recuperarSenha.TabStop = true;
            this.recuperarSenha.Text = "ESQUECI MINHA SENHA";
            this.recuperarSenha.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // invalido
            // 
            this.invalido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invalido.AutoSize = true;
            this.invalido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invalido.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalido.ForeColor = System.Drawing.Color.Red;
            this.invalido.Location = new System.Drawing.Point(312, 320);
            this.invalido.Name = "invalido";
            this.invalido.Size = new System.Drawing.Size(237, 21);
            this.invalido.TabIndex = 9;
            this.invalido.Text = "usuario e/ou senha invalidos";
            this.invalido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.invalido.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::TravessosBar.Properties.Resources.@__desde_2025____1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(344, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.invalido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recuperarSenha);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "0";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.LinkLabel recuperarSenha;
        private System.Windows.Forms.Label invalido;
        public System.Windows.Forms.Panel panel1;
    }
}

