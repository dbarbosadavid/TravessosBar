using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravessosBar
{
    internal class Pedido
    {
        private SQLServer sqlServer;
        public Pedido(SQLServer sqlServer) { this.sqlServer = sqlServer; }
        public Pedido() { this.sqlServer = new SQLServer(); }

        public void criarTabelaPedido()
        {
            try
            {
                SqlCommand comando = new SqlCommand("CREATE TABLE " +
                                                        "Pedido (id INT PRIMARY KEY IDENTITY(1, 1), " +
                                                        "cliente_id char(50) NOT NULL, " +
                                                        "total decimal(6,2) NOT NULL, " +
                                                        "situacao char(15) DEFAULT 'PENDENTE' NOT NULL)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();
            }
            catch { }
        }

        public void inserirPedido(String cliente_id, String lista_produto_id, double total)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO " +
                                                    "Pedido (cliente_id, total) " +
                                                    $"VALUES ('{cliente_id}', {total})", this.sqlServer.Conn);

            comando.ExecuteNonQuery();
        }

        public void attPedido(String id)
        {
            SqlCommand comando = new SqlCommand($"UPDATE Pedido " +
                $"SET situacao = 'FINALIZADO'" +
                $"WHERE id = {id}", this.sqlServer.Conn);

            comando.ExecuteNonQuery();
        }

        public void deletarPedido(int id)
        {
            SqlCommand comando = new SqlCommand($"DELETE FROM Pedido WHERE id = '{id}'", this.sqlServer.Conn);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
