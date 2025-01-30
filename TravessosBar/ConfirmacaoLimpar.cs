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
    public partial class ConfirmacaoLimpar : UserControl
    {
        private RealizarPedido pai;
        private Panel box;
        public ConfirmacaoLimpar(RealizarPedido pai, Panel box)
        {
            InitializeComponent();

            this.pai = pai;
            this.box = box;
        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            this.pai.listaProdutos.Items.Clear();
            this.pai.totalPreco.Text = "R$ 0";
            this.pai.total = 0; 
            this.box.Visible = false;
        }

        private void botaoNao_Click(object sender, EventArgs e)
        {
            this.box.Visible = false;
        }
    }
}
