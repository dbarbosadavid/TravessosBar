using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    internal class ListaProdutos
    {   
        SQLServer sqlServer;
        public ListaProdutos(SQLServer sqlServer) { this.sqlServer = sqlServer; }

        public void criaTabelaLista()
        {
            try
            {
                SqlCommand comando = new SqlCommand("CREATE TABLE " +
                                                        "ListaProduto (idPedido INT NOT NULL, " +
                                                        "nomeProduto char(50) NOT NULL, " +
                                                        "precoProduto decimal(6,2) NOT NULL)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();
            }
            catch { }
        }

        public void inserirProdutos(String idPedido, String nomeProduto, String precoProduto)

        {
            SQLServer server = new SQLServer();
            SqlCommand comando = new SqlCommand("INSERT INTO " +
                                                    "ListaProduto (idPedido, nomeProduto, precoProduto) " +
                                                    $"VALUES ({idPedido}, '{nomeProduto}', {precoProduto.Split(',')[1]}.00)", server.Conn);

            comando.ExecuteNonQuery();
        }
    }
}
