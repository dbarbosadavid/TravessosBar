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
    public partial class BuscaCpf : UserControl
    {
        private Panel box;
        private SQLServer sqlServer;
        private RealizarPedido realizarPedido;
        public BuscaCpf(Panel box, SQLServer sqlServer, RealizarPedido realizarPedido)
        {
            InitializeComponent();
            this.box = box;
            this.sqlServer = sqlServer;
            this.realizarPedido = realizarPedido;
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            string cpf = campoCpf.Text;

            
            SqlCommand comando = new SqlCommand($"SELECT * FROM Cliente WHERE cpf = '{cpf}'", this.sqlServer.Conn);
            SqlDataReader leitor = comando.ExecuteReader();


            if (!leitor.Read())
            {
                MessageBox.Show("CPF não cadastrado!", "ERRO!!!");
            }
            else
            {

                this.realizarPedido.clientePedido.Text = leitor["nome"].ToString();
                this.realizarPedido.idClienteBox.Text = leitor["id"].ToString();
            }
            this.box.Visible = false;
            leitor.Close();
        }
    }
}
