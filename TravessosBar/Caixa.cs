using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravessosBar
{
    internal class Caixa
    {
        private SQLServer sqlServer;
        public Caixa(SQLServer sqlServer) { this.sqlServer = sqlServer; }

        public void criarTabelaCaixa()
        {
            try
            {
                SqlCommand comando = new SqlCommand("INSERT INTO Caixa (nome, login, senha) " +
                                                    "VALUES ('DAVID', 'DAVID', '123')", this.sqlServer.Conn);
                comando.ExecuteNonQuery();
            }
            catch { }
        }
        public void addCaixa(string nome, string login, string senha)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Caixa (nome, login, senha) " +
                                                $"VALUES ('{nome}', '{login}', '{senha}')", this.sqlServer.Conn);

            comando.ExecuteNonQuery();
        }
    }
}
