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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            comboBoxCliente.DataSource = Cliente.Listar();
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DisplayMember = "Nome";

            comboBoxAtendente.DataSource = Usuarios.Listar();
            comboBoxAtendente.ValueMember= "Id";
            comboBoxAtendente.DisplayMember = "Nome";
        }
    }
}
