namespace TravessosBar
{
    partial class SairConfirmar
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
            this.sairConfirmarLabel = new System.Windows.Forms.Label();
            this.botaoNao = new System.Windows.Forms.Button();
            this.botaoSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sairConfirmarLabel
            // 
            this.sairConfirmarLabel.AutoSize = true;
            this.sairConfirmarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairConfirmarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sairConfirmarLabel.Location = new System.Drawing.Point(48, 33);
            this.sairConfirmarLabel.Name = "sairConfirmarLabel";
            this.sairConfirmarLabel.Size = new System.Drawing.Size(196, 21);
            this.sairConfirmarLabel.TabIndex = 1;
            this.sairConfirmarLabel.Text = "DESEJA REALMENTE SAIR?";
            // 
            // botaoNao
            // 
            this.botaoNao.BackColor = System.Drawing.Color.White;
            this.botaoNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNao.Location = new System.Drawing.Point(165, 83);
            this.botaoNao.Name = "botaoNao";
            this.botaoNao.Size = new System.Drawing.Size(94, 33);
            this.botaoNao.TabIndex = 6;
            this.botaoNao.Text = "NÃO";
            this.botaoNao.UseVisualStyleBackColor = false;
            this.botaoNao.Click += new System.EventHandler(this.botaoNao_Click);
            // 
            // botaoSim
            // 
            this.botaoSim.BackColor = System.Drawing.Color.White;
            this.botaoSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSim.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSim.Location = new System.Drawing.Point(36, 83);
            this.botaoSim.Name = "botaoSim";
            this.botaoSim.Size = new System.Drawing.Size(92, 33);
            this.botaoSim.TabIndex = 5;
            this.botaoSim.Text = "SIM";
            this.botaoSim.UseVisualStyleBackColor = false;
            this.botaoSim.Click += new System.EventHandler(this.botaoSim_Click);
            // 
            // SairConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.botaoNao);
            this.Controls.Add(this.botaoSim);
            this.Controls.Add(this.sairConfirmarLabel);
            this.Name = "SairConfirmar";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaoNao;
        private System.Windows.Forms.Button botaoSim;
        public System.Windows.Forms.Label sairConfirmarLabel;
    }
}
