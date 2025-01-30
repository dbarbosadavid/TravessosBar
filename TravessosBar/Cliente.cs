using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    internal class Cliente
    {
        private SQLServer sqlServer;
        public Cliente(SQLServer sqlServer) {this.sqlServer = sqlServer;}

        public void criarTabelaCliente()
        {
            try
            {
                SqlCommand tabelaCliente = new SqlCommand("CREATE TABLE " +
                                                        "Cliente (id INT PRIMARY KEY IDENTITY(1, 1), " +
                                                        "nome char(50) NOT NULL, " +
                                                        "cpf char(11) NOT NULL)", this.sqlServer.Conn);

                tabelaCliente.ExecuteNonQuery();
            }
            catch { }
        }

        public bool inserirCliente(String nome, String cpf)
        {
            SqlCommand comando = new SqlCommand($"SELECT * FROM Cliente WHERE cpf = '{cpf}'", this.sqlServer.Conn);
            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader["id"].ToString() != "")
                {
                    MessageBox.Show("CPF Já Cadastrado!", "ERRO");
                    dataReader.Close();
                    return false;
                }
                dataReader.Close();
            }
            try
            {
                dataReader.Close();
                comando = new SqlCommand("INSERT INTO " +
                                                    "Cliente (nome, cpf) " +
                                                    $"VALUES ('{nome}', '{cpf}')", this.sqlServer.Conn);
                comando.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        public void attCliente(String id, String nome, String cpf)
        {
            SqlCommand comando = new SqlCommand($"UPDATE Cliente " +
                $"SET nome = '{nome}', cpf = '{cpf}'" +
                $"WHERE id = {id}", this.sqlServer.Conn);

            comando.ExecuteNonQuery();
        }

        public void deletarCliente(int id)
        {
            SqlCommand comando = new SqlCommand($"DELETE FROM Cliente WHERE id = '{id}'", this.sqlServer.Conn);
            try
            {
                comando.ExecuteNonQuery();

            }
            catch { }
        }

        public bool verificaCpf(String cpf)
        {
            if (cpf.Length != 11)
                return true;

            int[] cpfInt = new int[11];
            int i = 0, somaDigito1 = 0, somaDigito2 = 0;

            foreach (char c in cpf)
            {
                cpfInt[i] = int.Parse(c.ToString());
                i++;
            }

            for (i = 0; i < 9; i++)
                somaDigito1 += cpfInt[i] * (10 - i);

            for (i = 0; i < 10; i++)
                somaDigito2 += cpfInt[i] * (11 - i);

            if (somaDigito1 % 11 == 0 || somaDigito1 % 11 == 1)
            {
                if (cpfInt[9] != 0)
                    return true;
            }
            else
            {
                if (cpfInt[9] != 11 - somaDigito1 % 11)
                    return true;
            }

            if (somaDigito2 % 11 == 0 || somaDigito2 % 11 == 1)
            {
                if (cpfInt[10] != 0)
                    return true;
            }
            else
            {
                if (cpfInt[10] != 11 - somaDigito2 % 11)
                    return true;
            }
            return false;
        }
    }
}
