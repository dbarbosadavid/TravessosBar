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
    public partial class MensagemSucesso : UserControl
    {
        public Panel panelPai = new Panel();
        public RealizarPedido classePai;
        public MensagemSucesso(RealizarPedido classePai, Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
            this.classePai = classePai;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            classePai.botaoVoltar_Click(sender, e);
            this.panelPai.Visible = false;
        }

        private void botao2edit_Click(object sender, EventArgs e)
        {
            SQLServer server = new SQLServer();
            SqlCommand select = new SqlCommand($"select * from Produto where cliente_id = '{this.classePai.idClienteBox.Text}'", server.Conn);
            this.classePai.idClienteBox.Visible = false;
            ExibePedido exibePedido = new ExibePedido(this.classePai, this.panelPai);

            SqlCommand comando = new SqlCommand($"select MAX(id) as id, situacao from Pedido where cliente_id = '{this.classePai.idClienteBox.Text}' group by situacao", server.Conn);
            SqlDataReader leitor = comando.ExecuteReader();
            leitor.Read();
            exibePedido.numeroPedido.Text = leitor["id"].ToString();
            exibePedido.nomeCliente.Text = this.classePai.clientePedido.Text;
            exibePedido.preco.Text = this.classePai.totalPreco.Text;
            exibePedido.listaProdutos.Text = "";
            exibePedido.precosInd.Text = "";
            foreach (ListViewItem item in this.classePai.listaProdutos.Items)
            {
                exibePedido.listaProdutos.Text += item.SubItems[0].Text + "\n";
                exibePedido.precosInd.Text += item.SubItems[1].Text + "\n";
            }
            exibePedido.finalizadoPendente.Visible = false;
            
             
            this.panelPai.Size = new Size(400, 540);
            this.panelPai.Location = new Point(this.panelPai.Location.X-50, 0);
            this.panelPai.Controls.Clear();
            this.panelPai.Controls.Add(exibePedido);
        }
    }
}
