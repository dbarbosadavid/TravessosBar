namespace TravessosBar
{
    partial class BuscarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nomeEdit = new System.Windows.Forms.Label();
            this.cpfEdit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoNao = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.botaoSim = new System.Windows.Forms.Button();
            this.editarBotao = new System.Windows.Forms.Button();
            this.deletarBotao = new System.Windows.Forms.Button();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteDeletado = new System.Windows.Forms.Panel();
            this.okBotao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.cpfAtt = new System.Windows.Forms.TextBox();
            this.nomeAtt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarBotao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idAtt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.clienteDeletado.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(15, 15);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(111, 29);
            this.botaoVoltar.TabIndex = 1;
            this.botaoVoltar.Text = "VOLTAR";
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.editarBotao);
            this.panel1.Controls.Add(this.deletarBotao);
            this.panel1.Controls.Add(this.gridCliente);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.cpfTextBox);
            this.panel1.Controls.Add(this.cpfLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Location = new System.Drawing.Point(88, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 361);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.nomeEdit);
            this.panel2.Controls.Add(this.cpfEdit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.botaoNao);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.botaoSim);
            this.panel2.Location = new System.Drawing.Point(187, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 167);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // nomeEdit
            // 
            this.nomeEdit.AutoSize = true;
            this.nomeEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeEdit.Location = new System.Drawing.Point(68, 41);
            this.nomeEdit.Name = "nomeEdit";
            this.nomeEdit.Size = new System.Drawing.Size(50, 21);
            this.nomeEdit.TabIndex = 16;
            this.nomeEdit.Text = "nome";
            // 
            // cpfEdit
            // 
            this.cpfEdit.AutoSize = true;
            this.cpfEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpfEdit.Location = new System.Drawing.Point(49, 74);
            this.cpfEdit.Name = "cpfEdit";
            this.cpfEdit.Size = new System.Drawing.Size(31, 21);
            this.cpfEdit.TabIndex = 15;
            this.cpfEdit.Text = "cpf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPF:";
            // 
            // botaoNao
            // 
            this.botaoNao.BackColor = System.Drawing.Color.White;
            this.botaoNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNao.Location = new System.Drawing.Point(158, 131);
            this.botaoNao.Name = "botaoNao";
            this.botaoNao.Size = new System.Drawing.Size(153, 33);
            this.botaoNao.TabIndex = 12;
            this.botaoNao.Text = "NÃO";
            this.botaoNao.UseVisualStyleBackColor = false;
            this.botaoNao.Click += new System.EventHandler(this.botaoNao_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(81, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 21);
            this.label.TabIndex = 10;
            this.label.Text = "DELETAR CLIENTE?";
            // 
            // botaoSim
            // 
            this.botaoSim.BackColor = System.Drawing.Color.White;
            this.botaoSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSim.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSim.Location = new System.Drawing.Point(3, 131);
            this.botaoSim.Name = "botaoSim";
            this.botaoSim.Size = new System.Drawing.Size(149, 33);
            this.botaoSim.TabIndex = 11;
            this.botaoSim.Text = "SIM";
            this.botaoSim.UseVisualStyleBackColor = false;
            this.botaoSim.Click += new System.EventHandler(this.botaoSim_Click);
            // 
            // editarBotao
            // 
            this.editarBotao.BackColor = System.Drawing.Color.Blue;
            this.editarBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarBotao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBotao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editarBotao.Location = new System.Drawing.Point(384, 322);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(117, 23);
            this.editarBotao.TabIndex = 7;
            this.editarBotao.Text = "EDITAR CLIENTE";
            this.editarBotao.UseVisualStyleBackColor = false;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // deletarBotao
            // 
            this.deletarBotao.BackColor = System.Drawing.Color.DarkRed;
            this.deletarBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarBotao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletarBotao.ForeColor = System.Drawing.Color.White;
            this.deletarBotao.Location = new System.Drawing.Point(517, 322);
            this.deletarBotao.Name = "deletarBotao";
            this.deletarBotao.Size = new System.Drawing.Size(117, 23);
            this.deletarBotao.TabIndex = 7;
            this.deletarBotao.Text = "DELETAR CLIENTE";
            this.deletarBotao.UseVisualStyleBackColor = false;
            this.deletarBotao.Click += new System.EventHandler(this.deletarBotao_Click);
            // 
            // gridCliente
            // 
            this.gridCliente.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.gridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridCliente.Location = new System.Drawing.Point(22, 49);
            this.gridCliente.MultiSelect = false;
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.RowHeadersVisible = false;
            this.gridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(619, 254);
            this.gridCliente.TabIndex = 6;
            this.gridCliente.Visible = false;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(555, 11);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(31, 21);
            this.id.TabIndex = 5;
            this.id.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(587, 10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 22);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.Location = new System.Drawing.Point(358, 11);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(157, 22);
            this.cpfTextBox.TabIndex = 3;
            this.cpfTextBox.TextChanged += new System.EventHandler(this.cpfTextBox_TextChanged);
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.Location = new System.Drawing.Point(318, 12);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(42, 21);
            this.cpfLabel.TabIndex = 2;
            this.cpfLabel.Text = "CPF:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(18, 11);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(63, 21);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "NOME:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(82, 11);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(215, 22);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // clienteDeletado
            // 
            this.clienteDeletado.BackColor = System.Drawing.Color.DarkCyan;
            this.clienteDeletado.Controls.Add(this.okBotao);
            this.clienteDeletado.Controls.Add(this.label3);
            this.clienteDeletado.Location = new System.Drawing.Point(15, 309);
            this.clienteDeletado.Name = "clienteDeletado";
            this.clienteDeletado.Size = new System.Drawing.Size(317, 167);
            this.clienteDeletado.TabIndex = 9;
            this.clienteDeletado.Visible = false;
            // 
            // okBotao
            // 
            this.okBotao.BackColor = System.Drawing.Color.White;
            this.okBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBotao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBotao.Location = new System.Drawing.Point(82, 113);
            this.okBotao.Name = "okBotao";
            this.okBotao.Size = new System.Drawing.Size(149, 33);
            this.okBotao.TabIndex = 12;
            this.okBotao.Text = "OK";
            this.okBotao.UseVisualStyleBackColor = false;
            this.okBotao.Click += new System.EventHandler(this.okBotao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(84, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "CLIENTE DELETADO";
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.DarkCyan;
            this.updatePanel.Controls.Add(this.idAtt);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.cpfAtt);
            this.updatePanel.Controls.Add(this.nomeAtt);
            this.updatePanel.Controls.Add(this.label6);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.salvarBotao);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Location = new System.Drawing.Point(543, 5);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(317, 167);
            this.updatePanel.TabIndex = 13;
            this.updatePanel.Visible = false;
            // 
            // cpfAtt
            // 
            this.cpfAtt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cpfAtt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfAtt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cpfAtt.Location = new System.Drawing.Point(77, 100);
            this.cpfAtt.Name = "cpfAtt";
            this.cpfAtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cpfAtt.Size = new System.Drawing.Size(160, 22);
            this.cpfAtt.TabIndex = 19;
            // 
            // nomeAtt
            // 
            this.nomeAtt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeAtt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAtt.Location = new System.Drawing.Point(77, 72);
            this.nomeAtt.Name = "nomeAtt";
            this.nomeAtt.Size = new System.Drawing.Size(215, 22);
            this.nomeAtt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(31, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "NOME:";
            // 
            // salvarBotao
            // 
            this.salvarBotao.BackColor = System.Drawing.Color.White;
            this.salvarBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salvarBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarBotao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBotao.Location = new System.Drawing.Point(121, 128);
            this.salvarBotao.Name = "salvarBotao";
            this.salvarBotao.Size = new System.Drawing.Size(75, 30);
            this.salvarBotao.TabIndex = 12;
            this.salvarBotao.Text = "SALVAR";
            this.salvarBotao.UseVisualStyleBackColor = false;
            this.salvarBotao.Click += new System.EventHandler(this.salvarBotao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(119, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "ATUALIZE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(43, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID:";
            // 
            // idAtt
            // 
            this.idAtt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idAtt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAtt.Location = new System.Drawing.Point(77, 44);
            this.idAtt.Name = "idAtt";
            this.idAtt.ReadOnly = true;
            this.idAtt.Size = new System.Drawing.Size(54, 22);
            this.idAtt.TabIndex = 21;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.clienteDeletado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "BuscarCliente";
            this.Size = new System.Drawing.Size(860, 540);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.clienteDeletado.ResumeLayout(false);
            this.clienteDeletado.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button editarBotao;
        private System.Windows.Forms.Button deletarBotao;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoNao;
        public System.Windows.Forms.Label label;
        private System.Windows.Forms.Button botaoSim;
        public System.Windows.Forms.Label nomeEdit;
        public System.Windows.Forms.Label cpfEdit;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel clienteDeletado;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okBotao;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button salvarBotao;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpfAtt;
        private System.Windows.Forms.TextBox nomeAtt;
        private System.Windows.Forms.TextBox idAtt;
        public System.Windows.Forms.Label label7;
    }
}
