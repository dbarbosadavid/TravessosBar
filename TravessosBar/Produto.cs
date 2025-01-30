using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    internal class Produto
    {
        private SQLServer sqlServer;
        public Produto(SQLServer sqlServer) {this.sqlServer = sqlServer;}

        
        public void criarTabelaProduto()
        {
            try
            {
                SqlCommand comando = new SqlCommand("CREATE TABLE " +
                                                        "Produto (id INT PRIMARY KEY IDENTITY(1, 1), " +
                                                        "nome char(50) NOT NULL, " +
                                                        "descricao char(50) NOT NULL, " +
                                                        "preco decimal(6,2) NOT NULL)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();

                comando = new SqlCommand("INSERT INTO Produto " +
                "(nome, descricao, preco) " +
                "VALUES ('Cigarro Malboro', 'Maço de Cigarro Malboro', 20.00)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();

                comando = new SqlCommand("INSERT INTO Produto " +
                "(nome, descricao, preco) " +
                "VALUES ('Cerveja 600ml', 'Cerveja Original Garrafa 600ml', 15.00)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();

                comando = new SqlCommand("INSERT INTO Produto " +
                "(nome, descricao, preco) " +
                "VALUES ('Coca-Cola 350ml', 'Refrigerante Coca-Cola Lata 350ml', 7.00)", this.sqlServer.Conn);

                comando.ExecuteNonQuery();
            }
            catch { }
        }

        public void inserirProduto(String nome, String descricao, double preco)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO " +
                                                    "Produto (nome, descricao, preco) " +
                                                    $"VALUES ('{nome}', '{descricao}', '{preco}')", this.sqlServer.Conn);
            comando.ExecuteNonQuery();
        }

        public void attProduto(String id, String nome, String descricao, double preco)
        {
            SqlCommand comando = new SqlCommand($"UPDATE Produto " +
                $"SET nome = '{nome}', descricao = '{descricao}', preco = '{preco}'" +
                $"WHERE id = {id}", this.sqlServer.Conn);

            comando.ExecuteNonQuery();
        }

        public void deletarProduto(int id)
        {
            SqlCommand comando = new SqlCommand($"DELETE FROM Produto WHERE id = '{id}'", this.sqlServer.Conn);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
