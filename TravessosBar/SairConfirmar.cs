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
    public partial class SairConfirmar : UserControl
    {
        private TelaCaixa pai;
        private Panel box;
        public SairConfirmar(TelaCaixa pai, Panel box)
        {
            InitializeComponent();
            this.pai = pai;
            this.box = box;
        }

        private void botaoNao_Click(object sender, EventArgs e)
        {
            this.box.Visible = false;
        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            pai.main.panel1.Visible = false;
            this.box.Visible = false;
        }
    }
}
