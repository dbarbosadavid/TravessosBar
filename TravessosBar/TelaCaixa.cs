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
    public partial class TelaCaixa : UserControl
    {
        public Form1 main;
        SQLServer sqlServer;
        public TelaCaixa(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.main = main;
            this.sqlServer = sqlServer;
        }


        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(cadastrarCliente);
            cadastrarCliente.Dock = DockStyle.Fill;
        }

        

        private void sairPic_Click(object sender, EventArgs e)
        {
            botaoSair_Click(sender, e);
        }

        private void cadastraClientePic_Click_1(object sender, EventArgs e)
        {
            botaoCadastrarCliente_Click(sender, e);
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            SairConfirmar sair = new SairConfirmar(this, panelTelaCaixa);
            panelTelaCaixa.Size = new Size(300, 150);
            panelTelaCaixa.Location = new Point(main.Width / 2 - 150, main.Height / 2 - 75);
            panelTelaCaixa.Controls.Clear();
            panelTelaCaixa.Controls.Add(sair);
            panelTelaCaixa.Visible = true;
        }

        private void realizaPedidoPic_Click(object sender, EventArgs e)
        {
            botaoRealizarPedido_Click(sender, e);
        }

        private void botaoRealizarPedido_Click(object sender, EventArgs e)
        {
            RealizarPedido realizarPedido = new RealizarPedido(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(realizarPedido);
            realizarPedido.Dock = DockStyle.Fill;
        }

        private void botaoVerPedido_Click(object sender, EventArgs e)
        {
            Pedidos telaPedidos = new Pedidos(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaPedidos);
            telaPedidos.Dock = DockStyle.Fill;
        }

        private void verPedidoPic_Click(object sender, EventArgs e)
        {
            botaoVerPedido_Click(sender, e);
        }

        private void buscaClientePic_Click(object sender, EventArgs e)
        {
            botaoBuscarCliente_Click(sender, e);  
        }

        private void botaoBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente(this.main, this.main.SqlServer);
            this.Controls.Clear();
            this.Controls.Add(buscarCliente);
            buscarCliente.Dock = DockStyle.Fill;
        }
    }
}
