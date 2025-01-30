using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravessosBar
{
    public partial class Pedidos : UserControl
    {

        private Form1 main;
        SQLServer sqlServer;
        public Pedidos(Form1 main, SQLServer sqlServer)
        {
            InitializeComponent();
            this.main = main;
            this.sqlServer = sqlServer;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            TelaCaixa telaCaixa = new TelaCaixa(this.main, this.sqlServer);
            this.Controls.Clear();
            this.Controls.Add(telaCaixa);
            telaCaixa.Dock = DockStyle.Fill;
        }

        private void botaoPendentes_Click(object sender, EventArgs e)
        {

        }

        private void pendentesPic_Click(object sender, EventArgs e)
        {

        }
    }
}
