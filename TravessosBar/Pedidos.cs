using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    public partial class Pedidos : UserControl
    {

        private Form1 main;
        SQLServer sqlServer;
        public Pedidos(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.main = main;
            this.sqlServer = sqlServer;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaCaixa telaCaixa = new TelaCaixa(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaCaixa);
            telaCaixa.Dock = DockStyle.Fill;
        }

        private void botaoPendentes_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SQLServer server = new SQLServer();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Pedido Where situacao = 'PENDENTE'", server.Conn);
            adapter.Fill(dataSet, "Pedido");
            pedidosGrid.DataSource = dataSet;
            pedidosGrid.DataMember = "Pedido";
            panel1.Visible = true;

        }

        private void pendentesPic_Click(object sender, EventArgs e)
        {
            botaoPendentes_Click(sender, e);
        }

        private void botaoFinalizados_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SQLServer server = new SQLServer();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Pedido Where situacao = 'FINALIZADO'", server.Conn);

            adapter.Fill(dataSet, "Pedido");
            pedidosGrid.DataSource = dataSet;
            pedidosGrid.DataMember = "Pedido";
            panel1.Visible = true;
        }

        private void finalizadosPic_Click(object sender, EventArgs e)
        {
            botaoFinalizados_Click(sender, e);
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = pedidosGrid.SelectedRows[0].Cells[0].Value.ToString();
            ExibePedido exibePedido = new ExibePedido(panelExibePedido);
            SQLServer server = new SQLServer();
            SqlCommand select = new SqlCommand($"select * from Pedido where id = '{id}'", server.Conn);
            SqlCommand listaProduto = new SqlCommand($"select * from ListaProduto where idPedido = {id}", server.Conn);
            SqlCommand clienteNome = new SqlCommand($"select * from Cliente where id = '{pedidosGrid.SelectedRows[0].Cells[1].Value.ToString()}'", server.Conn);
            SqlDataReader leitor = select.ExecuteReader();

            leitor.Read();
            exibePedido.numeroPedido.Text = leitor["id"].ToString();
            exibePedido.preco.Text = leitor["total"].ToString();
            leitor.Close();


            SqlDataReader clientereader = clienteNome.ExecuteReader();
            clientereader.Read();
            exibePedido.nomeCliente.Text = clientereader["nome"].ToString();
            clientereader.Close();

            SqlDataReader leitorlista = listaProduto.ExecuteReader();
            leitorlista.Read();

            exibePedido.listaProdutos.Text = "";
            exibePedido.precosInd.Text = "";

            /*do{
                exibePedido.listaProdutos.Text += leitorlista["nomeProduto"].ToString() + "\n";
                exibePedido.precosInd.Text += leitorlista["precoProduto"].ToString() + "\n";

            } while (leitorlista.NextResult());
            */
            exibePedido.voltar2.Visible = true;
            exibePedido.finalizadoPendente.Visible = false;
    

            panelExibePedido.Size = new Size(400, 540);
            panelExibePedido.Location = new Point(this.Width/2 - 200, 0);
            panelExibePedido.Controls.Clear();
            panelExibePedido.Controls.Add(exibePedido);
            panelExibePedido.Visible = true;
        }

        private void pedidosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = true;
        }
    }
}
