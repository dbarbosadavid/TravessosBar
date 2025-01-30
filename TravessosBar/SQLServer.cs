using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    public class SQLServer
    {

        private SqlConnection conn;
        private Cliente cliente;
        private Caixa caixa;
        private Produto produto;
        private Pedido pedido;
        private ListaProdutos listaProdutos;
        public SQLServer() 
        {
            this.conn = new SqlConnection("Server=DESKTOP-NJ8LCVS;DataBase=Travessos;Trusted_Connection=True;");
            this.conn.Open();

            this.Cliente = new Cliente(this);
            this.Caixa = new Caixa(this);
            this.Produto = new Produto(this);
            this.Pedido = new Pedido(this);
            this.listaProdutos = new ListaProdutos(this);
            this.Cliente.criarTabelaCliente();
            this.Caixa.criarTabelaCaixa();
            this.Produto.criarTabelaProduto();
            this.Pedido.criarTabelaPedido();
            this.listaProdutos.criaTabelaLista();
        }

        public SqlConnection Conn { get => conn; set => conn = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Caixa Caixa { get => caixa; set => caixa = value; }
        internal Produto Produto { get => produto; set => produto = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }
    }
}
