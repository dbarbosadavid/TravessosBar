namespace TravessosBar
{
    partial class MensagemSucesso
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
            this.Label = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botao2edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(13, 127);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(280, 32);
            this.Label.TabIndex = 1;
            this.Label.Text = "CLIENTE CADASTRADO!!!";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.BackColor = System.Drawing.Color.White;
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.ForeColor = System.Drawing.Color.Black;
            this.botaoVoltar.Location = new System.Drawing.Point(92, 246);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(107, 42);
            this.botaoVoltar.TabIndex = 2;
            this.botaoVoltar.Text = "VOLTAR";
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botao2edit
            // 
            this.botao2edit.BackColor = System.Drawing.Color.White;
            this.botao2edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao2edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao2edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2edit.ForeColor = System.Drawing.Color.Black;
            this.botao2edit.Location = new System.Drawing.Point(92, 210);
            this.botao2edit.Name = "botao2edit";
            this.botao2edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botao2edit.Size = new System.Drawing.Size(107, 30);
            this.botao2edit.TabIndex = 3;
            this.botao2edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao2edit.UseVisualStyleBackColor = false;
            this.botao2edit.Visible = false;
            this.botao2edit.Click += new System.EventHandler(this.botao2edit_Click);
            // 
            // MensagemSucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.botao2edit);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.Label);
            this.Name = "MensagemSucesso";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaoVoltar;
        public System.Windows.Forms.Label Label;
        public System.Windows.Forms.Button botao2edit;
    }
}
