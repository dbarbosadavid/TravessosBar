namespace TravessosBar
{
    partial class ExibePedido
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
            this.numeroPedido = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaProdutos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalizadoPendente = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.preco = new System.Windows.Forms.Label();
            this.botaFinaliza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(12, 12);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(122, 32);
            this.Label.TabIndex = 2;
            this.Label.Text = "Pedido Nº";
            // 
            // numeroPedido
            // 
            this.numeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeroPedido.AutoSize = true;
            this.numeroPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numeroPedido.Location = new System.Drawing.Point(129, 12);
            this.numeroPedido.Name = "numeroPedido";
            this.numeroPedido.Size = new System.Drawing.Size(153, 32);
            this.numeroPedido.TabIndex = 3;
            this.numeroPedido.Text = "NUMPEDIDO";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeCliente.AutoSize = true;
            this.nomeCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeCliente.Location = new System.Drawing.Point(12, 63);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(101, 32);
            this.nomeCliente.TabIndex = 4;
            this.nomeCliente.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRODUTOS";
            // 
            // listaProdutos
            // 
            this.listaProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listaProdutos.AutoSize = true;
            this.listaProdutos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaProdutos.Location = new System.Drawing.Point(63, 143);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(124, 20);
            this.listaProdutos.TabIndex = 6;
            this.listaProdutos.Text = "LISTA PRODUTOS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(197, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL:";
            // 
            // finalizadoPendente
            // 
            this.finalizadoPendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finalizadoPendente.AutoSize = true;
            this.finalizadoPendente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizadoPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.finalizadoPendente.Location = new System.Drawing.Point(223, 491);
            this.finalizadoPendente.Name = "finalizadoPendente";
            this.finalizadoPendente.Size = new System.Drawing.Size(160, 32);
            this.finalizadoPendente.TabIndex = 8;
            this.finalizadoPendente.Text = "FINZALIZADO";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(18, 499);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaoVoltar.Size = new System.Drawing.Size(135, 24);
            this.botaoVoltar.TabIndex = 14;
            this.botaoVoltar.Text = "VOLTAR";
            this.botaoVoltar.UseMnemonic = false;
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // preco
            // 
            this.preco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.preco.AutoSize = true;
            this.preco.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preco.Location = new System.Drawing.Point(298, 448);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(85, 32);
            this.preco.TabIndex = 15;
            this.preco.Text = "VALOR";
            // 
            // botaFinaliza
            // 
            this.botaFinaliza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaFinaliza.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaFinaliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaFinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaFinaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaFinaliza.Location = new System.Drawing.Point(18, 457);
            this.botaFinaliza.Name = "botaFinaliza";
            this.botaFinaliza.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaFinaliza.Size = new System.Drawing.Size(135, 24);
            this.botaFinaliza.TabIndex = 16;
            this.botaFinaliza.Text = "FINALIZAR PEDIDO";
            this.botaFinaliza.UseMnemonic = false;
            this.botaFinaliza.UseVisualStyleBackColor = false;
            // 
            // ExibePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.botaFinaliza);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.finalizadoPendente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.numeroPedido);
            this.Controls.Add(this.Label);
            this.Name = "ExibePedido";
            this.Size = new System.Drawing.Size(400, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label;
        public System.Windows.Forms.Label numeroPedido;
        public System.Windows.Forms.Label nomeCliente;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label listaProdutos;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label finalizadoPendente;
        private System.Windows.Forms.Button botaoVoltar;
        public System.Windows.Forms.Label preco;
        private System.Windows.Forms.Button botaFinaliza;
    }
}
