namespace TravessosBar
{
    partial class RealizarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.Fundo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarLabel = new System.Windows.Forms.Label();
            this.clientePedido = new System.Windows.Forms.TextBox();
            this.listaProdutos = new System.Windows.Forms.ListView();
            this.produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPreco = new System.Windows.Forms.Label();
            this.botaoRemoverItem = new System.Windows.Forms.Button();
            this.numeroMesa = new System.Windows.Forms.TextBox();
            this.botaoBuscarCliente = new System.Windows.Forms.Button();
            this.botaoFinalizarPedido = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.panelRealizarPedido = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.produtosLista = new System.Windows.Forms.Panel();
            this.produtosGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.idClienteBox = new System.Windows.Forms.TextBox();
            this.produtosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosGrid)).BeginInit();
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
            this.botaoVoltar.TabIndex = 1;
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
            this.Fundo.Location = new System.Drawing.Point(250, 15);
            this.Fundo.Name = "Fundo";
            this.Fundo.Padding = new System.Windows.Forms.Padding(0, 0, 25, 319);
            this.Fundo.Size = new System.Drawing.Size(360, 500);
            this.Fundo.TabIndex = 2;
            this.Fundo.Text = "      ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 216);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 69);
            this.label1.Size = new System.Drawing.Size(340, 250);
            this.label1.TabIndex = 3;
            this.label1.Text = "      ";
            // 
            // cadastrarLabel
            // 
            this.cadastrarLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cadastrarLabel.AutoSize = true;
            this.cadastrarLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cadastrarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarLabel.Location = new System.Drawing.Point(255, 192);
            this.cadastrarLabel.Name = "cadastrarLabel";
            this.cadastrarLabel.Size = new System.Drawing.Size(65, 21);
            this.cadastrarLabel.TabIndex = 4;
            this.cadastrarLabel.Text = "PEDIDO";
            // 
            // clientePedido
            // 
            this.clientePedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePedido.Location = new System.Drawing.Point(259, 57);
            this.clientePedido.Name = "clientePedido";
            this.clientePedido.ReadOnly = true;
            this.clientePedido.Size = new System.Drawing.Size(246, 24);
            this.clientePedido.TabIndex = 5;
            // 
            // listaProdutos
            // 
            this.listaProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProdutos.CheckBoxes = true;
            this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.produto,
            this.preco});
            this.listaProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaProdutos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProdutos.HideSelection = false;
            this.listaProdutos.HoverSelection = true;
            this.listaProdutos.Location = new System.Drawing.Point(260, 217);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(340, 202);
            this.listaProdutos.TabIndex = 6;
            this.listaProdutos.UseCompatibleStateImageBehavior = false;
            this.listaProdutos.View = System.Windows.Forms.View.Details;
            // 
            // produto
            // 
            this.produto.Text = "PROUTO";
            this.produto.Width = 275;
            // 
            // preco
            // 
            this.preco.Text = "PREÇO";
            this.preco.Width = 64;
            // 
            // addProduto
            // 
            this.addProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduto.Location = new System.Drawing.Point(271, 426);
            this.addProduto.Name = "addProduto";
            this.addProduto.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addProduto.Size = new System.Drawing.Size(33, 32);
            this.addProduto.TabIndex = 7;
            this.addProduto.Text = "+";
            this.addProduto.UseMnemonic = false;
            this.addProduto.UseVisualStyleBackColor = false;
            this.addProduto.Click += new System.EventHandler(this.addProduto_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(449, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL:";
            // 
            // totalPreco
            // 
            this.totalPreco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalPreco.AutoSize = true;
            this.totalPreco.BackColor = System.Drawing.Color.White;
            this.totalPreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPreco.ForeColor = System.Drawing.Color.Black;
            this.totalPreco.Location = new System.Drawing.Point(500, 431);
            this.totalPreco.Name = "totalPreco";
            this.totalPreco.Size = new System.Drawing.Size(42, 21);
            this.totalPreco.TabIndex = 9;
            this.totalPreco.Text = "R$ 0";
            // 
            // botaoRemoverItem
            // 
            this.botaoRemoverItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoRemoverItem.BackColor = System.Drawing.Color.Salmon;
            this.botaoRemoverItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemoverItem.Location = new System.Drawing.Point(310, 426);
            this.botaoRemoverItem.Name = "botaoRemoverItem";
            this.botaoRemoverItem.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaoRemoverItem.Size = new System.Drawing.Size(33, 32);
            this.botaoRemoverItem.TabIndex = 10;
            this.botaoRemoverItem.Text = "-";
            this.botaoRemoverItem.UseMnemonic = false;
            this.botaoRemoverItem.UseVisualStyleBackColor = false;
            this.botaoRemoverItem.Click += new System.EventHandler(this.botaoRemoverItem_Click);
            // 
            // numeroMesa
            // 
            this.numeroMesa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeroMesa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroMesa.Location = new System.Drawing.Point(260, 87);
            this.numeroMesa.Name = "numeroMesa";
            this.numeroMesa.Size = new System.Drawing.Size(100, 27);
            this.numeroMesa.TabIndex = 11;
            this.numeroMesa.Text = "MESA";
            // 
            // botaoBuscarCliente
            // 
            this.botaoBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoBuscarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBuscarCliente.Location = new System.Drawing.Point(370, 24);
            this.botaoBuscarCliente.Name = "botaoBuscarCliente";
            this.botaoBuscarCliente.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaoBuscarCliente.Size = new System.Drawing.Size(135, 24);
            this.botaoBuscarCliente.TabIndex = 12;
            this.botaoBuscarCliente.Text = "BUSCAR CLIENTE";
            this.botaoBuscarCliente.UseMnemonic = false;
            this.botaoBuscarCliente.UseVisualStyleBackColor = false;
            this.botaoBuscarCliente.Click += new System.EventHandler(this.botaoBuscarCliente_Click);
            // 
            // botaoFinalizarPedido
            // 
            this.botaoFinalizarPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoFinalizarPedido.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoFinalizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFinalizarPedido.Location = new System.Drawing.Point(465, 482);
            this.botaoFinalizarPedido.Name = "botaoFinalizarPedido";
            this.botaoFinalizarPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaoFinalizarPedido.Size = new System.Drawing.Size(135, 24);
            this.botaoFinalizarPedido.TabIndex = 13;
            this.botaoFinalizarPedido.Text = "FAZER PEDIDO";
            this.botaoFinalizarPedido.UseMnemonic = false;
            this.botaoFinalizarPedido.UseVisualStyleBackColor = false;
            this.botaoFinalizarPedido.Click += new System.EventHandler(this.botaoFinalizarPedido_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoLimpar.BackColor = System.Drawing.Color.Wheat;
            this.botaoLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.Location = new System.Drawing.Point(349, 426);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.botaoLimpar.Size = new System.Drawing.Size(81, 32);
            this.botaoLimpar.TabIndex = 14;
            this.botaoLimpar.Text = "LIMPAR";
            this.botaoLimpar.UseMnemonic = false;
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // panelRealizarPedido
            // 
            this.panelRealizarPedido.AutoScroll = true;
            this.panelRealizarPedido.Location = new System.Drawing.Point(5, 109);
            this.panelRealizarPedido.Name = "panelRealizarPedido";
            this.panelRealizarPedido.Size = new System.Drawing.Size(200, 100);
            this.panelRealizarPedido.TabIndex = 15;
            this.panelRealizarPedido.Visible = false;
            // 
            // produtosLista
            // 
            this.produtosLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.produtosLista.Controls.Add(this.addButton);
            this.produtosLista.Controls.Add(this.label3);
            this.produtosLista.Controls.Add(this.produtosGrid);
            this.produtosLista.Location = new System.Drawing.Point(291, 109);
            this.produtosLista.Name = "produtosLista";
            this.produtosLista.Size = new System.Drawing.Size(268, 310);
            this.produtosLista.TabIndex = 16;
            this.produtosLista.Visible = false;
            // 
            // produtosGrid
            // 
            this.produtosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtosGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.produtosGrid.Location = new System.Drawing.Point(19, 52);
            this.produtosGrid.Name = "produtosGrid";
            this.produtosGrid.ReadOnly = true;
            this.produtosGrid.RowHeadersVisible = false;
            this.produtosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosGrid.Size = new System.Drawing.Size(232, 150);
            this.produtosGrid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SELECIONE UM PRODUTO";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(58, 262);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addButton.Size = new System.Drawing.Size(156, 24);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "ADICIONAR PRODUTO";
            this.addButton.UseMnemonic = false;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idClienteBox
            // 
            this.idClienteBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idClienteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteBox.Location = new System.Drawing.Point(259, 24);
            this.idClienteBox.Name = "idClienteBox";
            this.idClienteBox.ReadOnly = true;
            this.idClienteBox.Size = new System.Drawing.Size(101, 24);
            this.idClienteBox.TabIndex = 17;
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.idClienteBox);
            this.Controls.Add(this.produtosLista);
            this.Controls.Add(this.panelRealizarPedido);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoFinalizarPedido);
            this.Controls.Add(this.botaoBuscarCliente);
            this.Controls.Add(this.numeroMesa);
            this.Controls.Add(this.botaoRemoverItem);
            this.Controls.Add(this.totalPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProduto);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.clientePedido);
            this.Controls.Add(this.cadastrarLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fundo);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "RealizarPedido";
            this.Size = new System.Drawing.Size(860, 540);
            this.produtosLista.ResumeLayout(false);
            this.produtosLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label Fundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cadastrarLabel;
        private System.Windows.Forms.ColumnHeader produto;
        private System.Windows.Forms.ColumnHeader preco;
        private System.Windows.Forms.Button addProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoRemoverItem;
        private System.Windows.Forms.TextBox numeroMesa;
        private System.Windows.Forms.Button botaoBuscarCliente;
        private System.Windows.Forms.Button botaoFinalizarPedido;
        private System.Windows.Forms.Button botaoLimpar;
        public System.Windows.Forms.Panel panelRealizarPedido;
        public System.Windows.Forms.ListView listaProdutos;
        public System.Windows.Forms.Label totalPreco;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.TextBox clientePedido;
        private System.Windows.Forms.Panel produtosLista;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView produtosGrid;
        public System.Windows.Forms.TextBox idClienteBox;
    }
}
