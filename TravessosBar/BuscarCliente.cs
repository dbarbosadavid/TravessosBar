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
    public partial class BuscarCliente : UserControl
    {

        private DataSet dataset = new DataSet();
        SQLServer sqlServer;
        private Form1 main;
        public BuscarCliente(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.sqlServer = sqlServer;
            this.main = main;
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
            dataset.Clear();
            if (idTextBox.Text.Length != 0 && cpfTextBox.Text.Length != 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and cpf LIKE '%{cpfTextBox.Text}%' and id = '{idTextBox.Text}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            if (idTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and cpf LIKE '%{cpfTextBox.Text}%'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            else if(cpfTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and id = '{id}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaCaixa telaCaixa = new TelaCaixa(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaCaixa);
            telaCaixa.Dock = DockStyle.Fill;
        }

        private void deletarBotao_Click(object sender, EventArgs e)
        {
            if (gridCliente.SelectedRows.Count == 0 || gridCliente.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Selecione ao menos um Cliente");
                return;
            }
            nomeEdit.Text = gridCliente.SelectedRows[0].Cells[1].Value.ToString();
            cpfEdit.Text = gridCliente.SelectedRows[0].Cells[2].Value.ToString();
            panel2.Visible = true;
        }

        private void cpfTextBox_TextChanged(object sender, EventArgs e)
        {
            dataset.Clear();
            if (idTextBox.Text.Length != 0 && nomeTextBox.Text.Length != 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and cpf LIKE '%{cpfTextBox.Text}%' and id = '{idTextBox.Text}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            if (idTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and cpf LIKE '%{cpfTextBox.Text}%'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            else if (nomeTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE cpf LIKE '%{cpfTextBox.Text}%' and id = '{id}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idTextBox.Text.Length == 0)
                return;

            dataset.Clear();
            if (cpfTextBox.Text.Length != 0 && nomeTextBox.Text.Length != 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and cpf LIKE '%{cpfTextBox.Text}%' and id = '{idTextBox.Text}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            if (nomeTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE id = '{idTextBox.Text}' and cpf LIKE '%{cpfTextBox.Text}%'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
            else if (cpfTextBox.Text.Length == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id as ID, nome as NOME, cpf as CPF FROM CLIENTE " +
                    $"WHERE nome LIKE '%{nomeTextBox.Text}%' and id = '{id}'", this.sqlServer.Conn);
                dataAdapter.Fill(dataset, "Cliente");
                gridCliente.DataSource = dataset;
                gridCliente.DataMember = "Cliente";
                gridCliente.Visible = true;
                return;
            }
        }

        private void botaoNao_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            int id;
            try
            { 
                id = int.Parse(gridCliente.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione ao menos um Cliente");
                return;
            }

            sqlServer.Cliente.deletarCliente(id);
            nomeTextBox_TextChanged(sender, e);
            panel2.Visible = false;
            clienteDeletado.Visible = true;
            clienteDeletado.Location = new Point(317, 167);
        }


        private void editarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridCliente.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Selecione ao menos um Cliente");
                    return;
                }
                id.Text = gridCliente.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Selecione ao menos um Cliente");
                return;
            }
            updatePanel.Visible = true;
            updatePanel.Location = new Point(317, 167);
            nomeAtt.Text = gridCliente.SelectedRows[0].Cells[1].Value.ToString();
            cpfAtt.Text = gridCliente.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void okBotao_Click(object sender, EventArgs e)
        {
            clienteDeletado.Visible = false;
        }

        private void salvarBotao_Click(object sender, EventArgs e)
        {
            if (this.sqlServer.Cliente.verificaCpf(cpfAtt.Text))
            {
                MessageBox.Show("CPF Inválido", "ERRO!!!");
                return;
            }
            this.sqlServer.Cliente.attCliente(gridCliente.SelectedRows[0].Cells[0].Value.ToString(), nomeAtt.Text, cpfAtt.Text);
            updatePanel.Visible = false;
        }
    }
}
