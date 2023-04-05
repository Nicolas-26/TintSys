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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricaoProduto.Text,
                cbxUnidadeProduto.Text,
                txtCodBarProduto.Text,
                double.Parse(txtDescontoProduto.Text),
                double.Parse(txtPrecoProduto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                txtIdProduto.Text = produto.Id.ToString();
                MessageBox.Show("Produto Gravado com sucesso!");
                CarregaGrid();
            }
            else
                MessageBox.Show("Falha ao Gravar Produto!");
        }

        private void CarregaGrid()
        {
            var lista = Produto.Listar();
            int c = 0;
            dataGridViewProduto.Rows.Clear();
            foreach (var item in lista)
            {
                dataGridViewProduto.Rows.Add();
                dataGridViewProduto.Rows[c].Cells[0].Value = item.Id.ToString();
                dataGridViewProduto.Rows[c].Cells[1].Value = item.Descricao;
                dataGridViewProduto.Rows[c].Cells[2].Value = item.Unidade;
                dataGridViewProduto.Rows[c].Cells[3].Value = item.CodBar;
                dataGridViewProduto.Rows[c].Cells[4].Value = item.Preco.ToString("R$ ##0.00");
                dataGridViewProduto.Rows[c].Cells[5].Value = item.Desconto.ToString("#.##%");
                dataGridViewProduto.Rows[c].Cells[6].Value = item.Descontinuado;
                c++;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
