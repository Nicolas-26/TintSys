using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TintSysDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();   
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagemProd frmListagemProd = new FrmListagemProd();
            frmListagemProd.MdiParent = this;
            frmListagemProd.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarUser frmListarUser = new FrmListarUser();
            frmListarUser.MdiParent = this;
            frmListarUser.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarPedidos frmListarPedidos = new FrmListarPedidos();
            frmListarPedidos.MdiParent = this;
            frmListarPedidos.Show();
        }
    }
}
