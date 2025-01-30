namespace TravessosBar
{
    partial class BuscaCpf
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
            this.campoCpf = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoCpf
            // 
            this.campoCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.campoCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCpf.Location = new System.Drawing.Point(18, 62);
            this.campoCpf.Name = "campoCpf";
            this.campoCpf.Size = new System.Drawing.Size(201, 27);
            this.campoCpf.TabIndex = 12;
            this.campoCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(14, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 21);
            this.label.TabIndex = 13;
            this.label.Text = "INFORME O CPF";
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.BackColor = System.Drawing.Color.Black;
            this.botaoBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBuscar.ForeColor = System.Drawing.Color.White;
            this.botaoBuscar.Location = new System.Drawing.Point(189, 113);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(92, 24);
            this.botaoBuscar.TabIndex = 14;
            this.botaoBuscar.Text = "BUSCAR";
            this.botaoBuscar.UseVisualStyleBackColor = false;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // BuscaCpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.campoCpf);
            this.Name = "BuscaCpf";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoCpf;
        public System.Windows.Forms.Label label;
        private System.Windows.Forms.Button botaoBuscar;
    }
}
