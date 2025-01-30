namespace TravessosBar
{
    partial class Pedidos
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
            this.botaoFinalizados = new System.Windows.Forms.Button();
            this.botaoPendentes = new System.Windows.Forms.Button();
            this.finalizadosPic = new System.Windows.Forms.PictureBox();
            this.pendentesPic = new System.Windows.Forms.PictureBox();
            this.pedidosGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelExibePedido = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.finalizadosPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendentesPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosGrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.botaoVoltar.TabIndex = 2;
            this.botaoVoltar.Text = "VOLTAR";
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoFinalizados
            // 
            this.botaoFinalizados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoFinalizados.AutoSize = true;
            this.botaoFinalizados.BackColor = System.Drawing.Color.Aqua;
            this.botaoFinalizados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFinalizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFinalizados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFinalizados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoFinalizados.Location = new System.Drawing.Point(460, 180);
            this.botaoFinalizados.Name = "botaoFinalizados";
            this.botaoFinalizados.Size = new System.Drawing.Size(187, 180);
            this.botaoFinalizados.TabIndex = 7;
            this.botaoFinalizados.Text = "PEDIDOS FINALIZADOS";
            this.botaoFinalizados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoFinalizados.UseVisualStyleBackColor = false;
            this.botaoFinalizados.Click += new System.EventHandler(this.botaoFinalizados_Click);
            // 
            // botaoPendentes
            // 
            this.botaoPendentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botaoPendentes.AutoSize = true;
            this.botaoPendentes.BackColor = System.Drawing.Color.Aqua;
            this.botaoPendentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPendentes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPendentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoPendentes.Location = new System.Drawing.Point(220, 180);
            this.botaoPendentes.Margin = new System.Windows.Forms.Padding(25);
            this.botaoPendentes.Name = "botaoPendentes";
            this.botaoPendentes.Size = new System.Drawing.Size(180, 180);
            this.botaoPendentes.TabIndex = 6;
            this.botaoPendentes.Text = "PEDIDOS PENDENTES";
            this.botaoPendentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPendentes.UseVisualStyleBackColor = false;
            this.botaoPendentes.Click += new System.EventHandler(this.botaoPendentes_Click);
            // 
            // finalizadosPic
            // 
            this.finalizadosPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finalizadosPic.BackColor = System.Drawing.Color.Aqua;
            this.finalizadosPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.finalizadosPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizadosPic.Image = global::TravessosBar.Properties.Resources.finalizado;
            this.finalizadosPic.Location = new System.Drawing.Point(515, 228);
            this.finalizadosPic.Name = "finalizadosPic";
            this.finalizadosPic.Size = new System.Drawing.Size(75, 74);
            this.finalizadosPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalizadosPic.TabIndex = 9;
            this.finalizadosPic.TabStop = false;
            this.finalizadosPic.Click += new System.EventHandler(this.finalizadosPic_Click);
            // 
            // pendentesPic
            // 
            this.pendentesPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pendentesPic.BackColor = System.Drawing.Color.Aqua;
            this.pendentesPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pendentesPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pendentesPic.Image = global::TravessosBar.Properties.Resources.pendente1;
            this.pendentesPic.Location = new System.Drawing.Point(272, 228);
            this.pendentesPic.Name = "pendentesPic";
            this.pendentesPic.Size = new System.Drawing.Size(75, 74);
            this.pendentesPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pendentesPic.TabIndex = 8;
            this.pendentesPic.TabStop = false;
            this.pendentesPic.Click += new System.EventHandler(this.pendentesPic_Click);
            // 
            // pedidosGrid
            // 
            this.pedidosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedidosGrid.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.pedidosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pedidosGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.pedidosGrid.Location = new System.Drawing.Point(0, 0);
            this.pedidosGrid.Name = "pedidosGrid";
            this.pedidosGrid.ReadOnly = true;
            this.pedidosGrid.RowHeadersVisible = false;
            this.pedidosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedidosGrid.Size = new System.Drawing.Size(546, 278);
            this.pedidosGrid.TabIndex = 0;
            this.pedidosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidosGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.botaoFechar);
            this.panel1.Controls.Add(this.pedidosGrid);
            this.panel1.Location = new System.Drawing.Point(161, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 315);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // botaoFechar
            // 
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFechar.Location = new System.Drawing.Point(226, 284);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(75, 23);
            this.botaoFechar.TabIndex = 1;
            this.botaoFechar.Text = "FECHAR";
            this.botaoFechar.UseVisualStyleBackColor = true;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(417, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ABRIR PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelExibePedido
            // 
            this.panelExibePedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelExibePedido.Location = new System.Drawing.Point(727, 15);
            this.panelExibePedido.Name = "panelExibePedido";
            this.panelExibePedido.Size = new System.Drawing.Size(200, 100);
            this.panelExibePedido.TabIndex = 12;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.panelExibePedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.finalizadosPic);
            this.Controls.Add(this.pendentesPic);
            this.Controls.Add(this.botaoFinalizados);
            this.Controls.Add(this.botaoPendentes);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(860, 540);
            ((System.ComponentModel.ISupportInitialize)(this.finalizadosPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendentesPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.PictureBox finalizadosPic;
        private System.Windows.Forms.PictureBox pendentesPic;
        private System.Windows.Forms.Button botaoFinalizados;
        private System.Windows.Forms.Button botaoPendentes;
        private System.Windows.Forms.DataGridView pedidosGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel panelExibePedido;
    }
}
