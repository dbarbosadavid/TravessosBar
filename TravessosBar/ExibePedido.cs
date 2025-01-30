using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public ExibePedido(Panel panelPai)
        {
            InitializeComponent();
            this.panelPai = panelPai;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.classePai.botaoVoltar_Click(sender, e);
            this.panelPai.Visible = false;
        }

        private void botaFinaliza_Click(object sender, EventArgs e)
        {
            String id = numeroPedido.Text;
            Pedido pedido = new Pedido();
            pedido.attPedido(id);
            botaFinaliza.Visible = false;
            finalizadoPendente.Visible = true;
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.panelPai.Visible = false;
        }
    }
}
