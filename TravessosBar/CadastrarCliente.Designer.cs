namespace TravessosBar
{
    partial class CadastrarCliente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.Fundo = new System.Windows.Forms.Label();
            this.nomeCadastro = new System.Windows.Forms.TextBox();
            this.cpfCadastro = new System.Windows.Forms.TextBox();
            this.botaoCadastrarCliente = new System.Windows.Forms.Button();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(15, 15);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(111, 29);
            this.botaoVoltar.TabIndex = 0;
            this.botaoVoltar.Text = "VOLTAR";
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // Fundo
            // 
            this.Fundo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fundo.AutoSize = true;
            this.Fundo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Fundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fundo.Location = new System.Drawing.Point(250, 179);
            this.Fundo.Name = "Fundo";
            this.Fundo.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Fundo.Size = new System.Drawing.Size(360, 181);
            this.Fundo.TabIndex = 1;
            this.Fundo.Text = "      ";
            // 
            // nomeCadastro
            // 
            this.nomeCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeCadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCadastro.Location = new System.Drawing.Point(310, 215);
            this.nomeCadastro.Name = "nomeCadastro";
            this.nomeCadastro.Size = new System.Drawing.Size(240, 27);
            this.nomeCadastro.TabIndex = 2;
            this.nomeCadastro.Text = "NOME COMPLETO";
            this.nomeCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cpfCadastro
            // 
            this.cpfCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cpfCadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfCadastro.Location = new System.Drawing.Point(310, 264);
            this.cpfCadastro.Name = "cpfCadastro";
            this.cpfCadastro.Size = new System.Drawing.Size(240, 27);
            this.cpfCadastro.TabIndex = 3;
            this.cpfCadastro.Text = "CPF";
            this.cpfCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botaoCadastrarCliente
            // 
            this.botaoCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoCadastrarCliente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botaoCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastrarCliente.Location = new System.Drawing.Point(385, 311);
            this.botaoCadastrarCliente.Name = "botaoCadastrarCliente";
            this.botaoCadastrarCliente.Size = new System.Drawing.Size(90, 26);
            this.botaoCadastrarCliente.TabIndex = 4;
            this.botaoCadastrarCliente.Text = "CADASTRAR";
            this.botaoCadastrarCliente.UseVisualStyleBackColor = false;
            this.botaoCadastrarCliente.Click += new System.EventHandler(this.botaoCadastrarCliente_Click);
            // 
            // panelCadastro
            // 
            this.panelCadastro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelCadastro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelCadastro.Location = new System.Drawing.Point(698, 29);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(114, 108);
            this.panelCadastro.TabIndex = 5;
            this.panelCadastro.Visible = false;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.botaoCadastrarCliente);
            this.Controls.Add(this.cpfCadastro);
            this.Controls.Add(this.nomeCadastro);
            this.Controls.Add(this.Fundo);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "CadastrarCliente";
            this.Size = new System.Drawing.Size(860, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label Fundo;
        private System.Windows.Forms.TextBox nomeCadastro;
        private System.Windows.Forms.TextBox cpfCadastro;
        private System.Windows.Forms.Button botaoCadastrarCliente;
        private System.Windows.Forms.Panel panelCadastro;
    }
}
