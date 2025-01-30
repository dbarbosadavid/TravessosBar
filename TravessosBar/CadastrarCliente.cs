using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    public partial class CadastrarCliente : UserControl
    {
        Form1 main;
        SQLServer sqlServer;
        public CadastrarCliente(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.main = main;
            this.sqlServer = sqlServer;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaCaixa telaCaixa = new TelaCaixa(this.main, sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaCaixa);
            telaCaixa.Dock = DockStyle.Fill;
        }

        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            String nome = nomeCadastro.Text;
            String cpf = cpfCadastro.Text;

            if (sqlServer.Cliente.verificaCpf(cpf))
            {
                MessageBox.Show("Insira um CPF válido", "ERRO!!!");
                return;
            }

            ConfirmaçãoDadosCliente tela = new ConfirmaçãoDadosCliente(nome, cpf, panelCadastro, this.sqlServer);

            panelCadastro.Size = new Size(300, 300);
            panelCadastro.Location = new Point(main.Width / 2 - 150, main.Height / 2 - 150);
            panelCadastro.Visible = true;
            panelCadastro.Controls.Clear();
            panelCadastro.Controls.Add(tela);
            
        }

        

        
    }
}
