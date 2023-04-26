using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmListarPedidos : Form
    {
        public FrmListarPedidos()
        {
            InitializeComponent();
        }

        private void FrmListarPedidos_Load(object sender, EventArgs e)
        {
            List<Pedido> list = Pedido.Listar();
            int c = 0;
            dgvListarPedidos.Rows.Clear();
            foreach (var item in list)
            {
                dgvListarPedidos.Rows.Add();
                dgvListarPedidos.Rows[c].Cells[0].Value = item.Id;
                dgvListarPedidos.Rows[c].Cells[1].Value = item.Data;
                dgvListarPedidos.Rows[c].Cells[2].Value = item.Status;
                dgvListarPedidos.Rows[c].Cells[3].Value = item.Desconto;
                dgvListarPedidos.Rows[c].Cells[4].Value = item.Cliente.Id;
                dgvListarPedidos.Rows[c].Cells[5].Value = item.Usuario.Id;
                dgvListarPedidos.Rows[c].Cells[7].Value = item.HashCode;
                c++;
            }
        }
    }
}
