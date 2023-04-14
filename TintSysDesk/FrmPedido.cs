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
            if (textBoxCodigo.Text.Length > 0)
            {
                Produto produto = Produto.ObterPorId(Convert.ToInt32(textBoxCodigo.Text));
                if (produto != null)
                {
                    textBoxDescricao.Text = produto.Descricao;
                    textBoxPreco.Text = produto.Preco.ToString();   
                    comboBoxUnidade.Text = produto.Unidade;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(
                Cliente.ObterPorId(Convert.ToInt32(comboBoxCliente.SelectedValue)),
                Usuarios.ObterPorId(Convert.ToInt32(comboBoxAtendente.SelectedValue))
                );
            pedido.Inserir();
            Pedido newped = Pedido.ObterPorId(pedido.Id);
            label2.Text = newped.Status + " - " + newped.HashCode;
            txtPedido.Text = newped.Id.ToString();
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ItemPedido item = new ItemPedido(
                Convert.ToInt32(textBoxCodigo.Text),
                Produto.ObterPorId(Convert.ToInt32(textBoxCodigo.Text)),
                Convert.ToDouble(textBoxPreco.Text),
                Convert.ToDouble(textBoxQuantidade.Text),
                Convert.ToDouble(textBoxDesconto.Text)
                );
            item.Adicionar();
            CarregaGrid();
        }
        private void CarregaGrid()
        {
            List<ItemPedido> lista = ItemPedido.ListarPorPedido(Convert.ToInt32(txtPedido.Text));
            double subtotal = 0;
            int c = 0;
            foreach (var item in lista)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[c].Cells[0].Value = c + 1;
                dataGridView1.Rows[c].Cells[1].Value = item.Produto.Id;
                dataGridView1.Rows[c].Cells[2].Value = item.Produto.Descricao;
                dataGridView1.Rows[c].Cells[3].Value = item.Produto.Unidade;
                dataGridView1.Rows[c].Cells[4].Value = item.Preco;
                dataGridView1.Rows[c].Cells[5].Value = item.Quantidade;
                dataGridView1.Rows[c].Cells[6].Value = item.Desconto;
                double valorItem = item.Preco * item.Quantidade - item.Desconto;
                dataGridView1.Rows[c].Cells[7].Value = valorItem;
                subtotal += valorItem;
                c++;         
            }
            textBoxTotal.Text = subtotal.ToString();
        }
    }
}
