using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravessosBar
{
    public partial class Form1 : Form
    {
        private SQLServer sqlServer;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SQLServer sqlServer)
        {
            InitializeComponent();
            this.sqlServer = sqlServer;
        }

        public SQLServer SqlServer { get => sqlServer; set => sqlServer = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand comando = new SqlCommand($"SELECT login, senha FROM Caixa WHERE login = '{login.Text}' and senha = '{senha.Text}'", this.sqlServer.Conn);
            SqlDataReader dataReader = comando.ExecuteReader();
            
            if (!String.IsNullOrWhiteSpace(login.Text) && !String.IsNullOrWhiteSpace(senha.Text))
            {
                if (dataReader.Read())
                {
                    TelaCaixa telaCaixa = new TelaCaixa(this, this.SqlServer);
                    panel1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(telaCaixa);
                    panel1.Visible = true;
                    telaCaixa.Dock = DockStyle.Fill;
                    invalido.Visible = false;
                }
                else
                {
                    invalido.Text = "Usuário e/ou senha inválidos";
                    dataReader.Close();
                    invalido.Visible = true;
                    invalido.Visible = false;
                    Thread.Sleep(50);
                    invalido.Visible = true;
                }
                dataReader.Close();
            }
            else
            {
                invalido.Text = "Preencha todos os campos";
                invalido.Location = new Point(this.Width/2-109, 320);
                invalido.Visible = true;
                invalido.Visible = false;
                Thread.Sleep(50);
                invalido.Visible = true;
            }
            dataReader.Close();
        }

        
    }
}
