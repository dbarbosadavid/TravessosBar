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
    public partial class ConfirmaçãoDadosCliente : UserControl
    {
        private String nome;
        private String cpf;
        private Panel pai;
        SQLServer sqlServer;
        public ConfirmaçãoDadosCliente(string nome, string cpf, Panel pai, SQLServer sqlServer)
        {
            InitializeComponent();
            this.nome = nome;
            this.cpf = cpf;
            this.pai = pai;
            this.sqlServer = sqlServer;
        }

        private void ConfirmaçãoDadosCliente_Load(object sender, EventArgs e)
        {
            this.nomeEditavel.Text = this.nome;
            this.cpfEditavel.Text = this.cpf;
        }

       
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Visible = false;
            this.pai.Visible = false;
        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            if (this.sqlServer.Cliente.inserirCliente(nome, cpf))
            {
                MensagemSucesso clienteCadastrado = new MensagemSucesso(new RealizarPedido(new Form1(), this.sqlServer), pai);
                this.pai.Controls.Add(clienteCadastrado);
            }
            else
                this.botaoCancelar_Click(sender, e);
        }
    }
}
