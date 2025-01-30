namespace TravessosBar
{
    partial class ConfirmacaoLimpar
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
            this.botaoNao = new System.Windows.Forms.Button();
            this.botaoSim = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoNao
            // 
            this.botaoNao.BackColor = System.Drawing.Color.White;
            this.botaoNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNao.Location = new System.Drawing.Point(168, 84);
            this.botaoNao.Name = "botaoNao";
            this.botaoNao.Size = new System.Drawing.Size(94, 33);
            this.botaoNao.TabIndex = 9;
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
            this.botaoSim.Location = new System.Drawing.Point(39, 84);
            this.botaoSim.Name = "botaoSim";
            this.botaoSim.Size = new System.Drawing.Size(92, 33);
            this.botaoSim.TabIndex = 8;
            this.botaoSim.Text = "SIM";
            this.botaoSim.UseVisualStyleBackColor = false;
            this.botaoSim.Click += new System.EventHandler(this.botaoSim_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(57, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(183, 21);
            this.label.TabIndex = 7;
            this.label.Text = "DESEJA LIMPAR A LISTA?";
            // 
            // ConfirmacaoLimpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.botaoNao);
            this.Controls.Add(this.botaoSim);
            this.Controls.Add(this.label);
            this.Name = "ConfirmacaoLimpar";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoNao;
        private System.Windows.Forms.Button botaoSim;
        public System.Windows.Forms.Label label;
    }
}
