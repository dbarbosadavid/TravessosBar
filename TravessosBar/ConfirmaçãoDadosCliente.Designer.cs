namespace TravessosBar
{
    partial class ConfirmaçãoDadosCliente
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
            this.cadastrarLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.botaoSim = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.nomeEditavel = new System.Windows.Forms.Label();
            this.cpfEditavel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadastrarLabel
            // 
            this.cadastrarLabel.AutoSize = true;
            this.cadastrarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarLabel.Location = new System.Drawing.Point(27, 32);
            this.cadastrarLabel.Name = "cadastrarLabel";
            this.cadastrarLabel.Size = new System.Drawing.Size(239, 21);
            this.cadastrarLabel.TabIndex = 0;
            this.cadastrarLabel.Text = "DESEJA CADASTRAR O CLIENTE?";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.Color.White;
            this.nomeLabel.Location = new System.Drawing.Point(27, 90);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(55, 20);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "NOME:";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.ForeColor = System.Drawing.Color.White;
            this.cpfLabel.Location = new System.Drawing.Point(27, 133);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(36, 20);
            this.cpfLabel.TabIndex = 2;
            this.cpfLabel.Text = "CPF:";
            // 
            // botaoSim
            // 
            this.botaoSim.BackColor = System.Drawing.Color.White;
            this.botaoSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSim.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSim.Location = new System.Drawing.Point(31, 246);
            this.botaoSim.Name = "botaoSim";
            this.botaoSim.Size = new System.Drawing.Size(92, 33);
            this.botaoSim.TabIndex = 3;
            this.botaoSim.Text = "SIM";
            this.botaoSim.UseVisualStyleBackColor = false;
            this.botaoSim.Click += new System.EventHandler(this.botaoSim_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancelar.Location = new System.Drawing.Point(172, 246);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(94, 33);
            this.botaoCancelar.TabIndex = 4;
            this.botaoCancelar.Text = "CANCELAR";
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // nomeEditavel
            // 
            this.nomeEditavel.AutoSize = true;
            this.nomeEditavel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEditavel.ForeColor = System.Drawing.Color.Silver;
            this.nomeEditavel.Location = new System.Drawing.Point(79, 90);
            this.nomeEditavel.Name = "nomeEditavel";
            this.nomeEditavel.Size = new System.Drawing.Size(47, 20);
            this.nomeEditavel.TabIndex = 5;
            this.nomeEditavel.Text = "nome";
            // 
            // cpfEditavel
            // 
            this.cpfEditavel.AutoSize = true;
            this.cpfEditavel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfEditavel.ForeColor = System.Drawing.Color.Silver;
            this.cpfEditavel.Location = new System.Drawing.Point(60, 133);
            this.cpfEditavel.Name = "cpfEditavel";
            this.cpfEditavel.Size = new System.Drawing.Size(30, 20);
            this.cpfEditavel.TabIndex = 6;
            this.cpfEditavel.Text = "cpf";
            // 
            // ConfirmaçãoDadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.cpfEditavel);
            this.Controls.Add(this.nomeEditavel);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSim);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.cadastrarLabel);
            this.Name = "ConfirmaçãoDadosCliente";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.ConfirmaçãoDadosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastrarLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Button botaoSim;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Label nomeEditavel;
        private System.Windows.Forms.Label cpfEditavel;
    }
}
