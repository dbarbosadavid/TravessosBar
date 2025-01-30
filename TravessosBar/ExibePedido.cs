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
    public partial class ExibePedido : UserControl
    {
        Panel panelPai;
        public RealizarPedido classePai;
        public ExibePedido(RealizarPedido classePai, Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
            this.classePai = classePai;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.classePai.botaoVoltar_Click(sender, e);
            this.panelPai.Visible = false;
        }
    }
}
