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
    public partial class RealizarPedido : UserControl
    {
        public double total = 0;
        private Form1 main;
        SQLServer sqlServer;
        public RealizarPedido(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.main = main;
            this.sqlServer = sqlServer;
        }

        public void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaCaixa telaCaixa = new TelaCaixa(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaCaixa);
            telaCaixa.Dock = DockStyle.Fill;
        }

        private void addProduto_Click(object sender, EventArgs e)
        {

            /*SqlCommand select = new SqlCommand($"select ", this.sqlServer.Conn);
            SqlDataReader leitor = select.ExecuteReader();*/
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            SqlDataAdapter grid = new SqlDataAdapter("select * from Produto", this.sqlServer.Conn);
            grid.Fill(dataSet, "Produtos");
            produtosGrid.DataSource = dataSet;
            produtosGrid.DataMember = "Produtos";
            produtosLista.Visible = true;

        }

        private void botaoRemoverItem_Click(object sender, EventArgs e)
        {
            bool selecionado = false;
            if (listaProdutos.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia!!!", "ERRO!!!");
                return;
            }
            foreach (ListViewItem item in listaProdutos.Items) 
            {
                if (item.Checked)
                {
                    selecionado = true;
                    total -= double.Parse(item.SubItems[1].Text);
                    listaProdutos.Items.Remove(item);
                }
            }
            if (!selecionado)
                MessageBox.Show("Selecione pelo menos um item para remover.", "ERRO!");
            totalPreco.Text = "R$ " + total.ToString();
        }

        private void botaoFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = clientePedido.Text;
                int mesa = int.Parse(numeroMesa.Text);
                if(listaProdutos.Items.Count == 0)
                {
                    MessageBox.Show("Não há produtos na lista!!!", "ERRO!!!");
                    return;
                }
                if (clientePedido.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Selecione um cliente!!!", "ERRO!!!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Insira um número válido de mesa");
                return;
            }

            
            Pedido pedido = new Pedido();
            String totalString = totalPreco.Text.ToString();
            String[] split = totalString.Split(' ');
            
            double totalBanco = double.Parse(split[1]);
            pedido.inserirPedido(idClienteBox.Text, clientePedido.Text, totalBanco);
            ListaProdutos produtosLista = new ListaProdutos(sqlServer);
            SqlCommand comando = new SqlCommand($"select MAX(id) as id from Pedido where cliente_id = '{idClienteBox.Text}'", sqlServer.Conn);

            SqlDataReader select = comando.ExecuteReader();
            
            foreach (ListViewItem item in listaProdutos.Items){
                select.Read();
                MessageBox.Show(item.SubItems[1].Text);
                produtosLista.inserirProdutos(select["id"].ToString(), item.SubItems[0].Text, item.SubItems[1].Text);
                select.Close();
            }
            

            MensagemSucesso sucesso = new MensagemSucesso(this, panelRealizarPedido);
            panelRealizarPedido.Controls.Clear();
            panelRealizarPedido.Anchor = AnchorStyles.Top;
            panelRealizarPedido.Size = new Size(300, 300);
            panelRealizarPedido.Location = new Point(main.Width / 2 - 150, main.Height / 2 - 150);
            sucesso.Label.Text = "PEDIDO CADASTRADO!!!";
            sucesso.botao2edit.Text = "VER PEDIDO";
            sucesso.botao2edit.Visible = true;
            panelRealizarPedido.Controls.Add(sucesso);
            panelRealizarPedido.Visible = true;

        }

        private void botaoBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscaCpf buscaCpf = new BuscaCpf(panelRealizarPedido, this.sqlServer, this);
            panelRealizarPedido.Anchor = AnchorStyles.Top;
            panelRealizarPedido.Size = new Size(300, 150);
            panelRealizarPedido.Location = new Point(main.Width / 2 - 150, main.Height / 2 - 75);
            panelRealizarPedido.Controls.Clear();
            panelRealizarPedido.Controls.Add(buscaCpf);
            panelRealizarPedido.Visible = true;
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            if(listaProdutos.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia!!!", "ERRO!!!");
            }
            else
            {
                ConfirmacaoLimpar conf = new ConfirmacaoLimpar(this, panelRealizarPedido);
                panelRealizarPedido.Size = new Size(300, 150);
                panelRealizarPedido.Location = new Point(main.Width / 2 - 150, main.Height / 2 - 75);
                panelRealizarPedido.Controls.Clear();
                panelRealizarPedido.Controls.Add(conf);
                panelRealizarPedido.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem produto = new ListViewItem(produtosGrid.SelectedRows[0].Cells[1].Value.ToString());
            listaProdutos.Items.Add(produto);
            produto.SubItems.Add(produtosGrid.SelectedRows[0].Cells[3].Value.ToString());
            total += double.Parse(produtosGrid.SelectedRows[0].Cells[3].Value.ToString());
            totalPreco.Text = "R$ " + total.ToString();
            produtosLista.Visible = false;
        }
    }
}
