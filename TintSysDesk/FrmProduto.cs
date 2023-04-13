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
                double.Parse(txtPrecoProduto.Text),
                double.Parse(txtDescontoProduto.Text)
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

        private void CarregaGrid(string texto = "")
        {
            List<Produto> lista = null;
            if(texto!=String.Empty)
            {
                 lista = Produto.Listar(texto);
            }
            else
            {
                 lista = Produto.Listar();
            }
            int c = 0;
            dataGridViewProduto.Rows.Clear();
            foreach (var item in lista)
            {
                dataGridViewProduto.Rows.Add();
                dataGridViewProduto.Rows[c].Cells[0].Value = item.Id.ToString();
                dataGridViewProduto.Rows[c].Cells[1].Value = item.Descricao;
                dataGridViewProduto.Rows[c].Cells[2].Value = item.Unidade;
                dataGridViewProduto.Rows[c].Cells[3].Value = item.CodBar;
                dataGridViewProduto.Rows[c].Cells[4].Value = item.Preco.ToString();
                dataGridViewProduto.Rows[c].Cells[5].Value = item.Desconto.ToString();
                dataGridViewProduto.Rows[c].Cells[6].Value = item.Descontinuado;
                c++;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text=="...")
            {
                txtIdProduto.ReadOnly = false;
                txtIdProduto.Focus();
                btnBuscar.Text = "Buscar";
            }
            else if(txtIdProduto.Text!=String.Empty)
            {
                txtIdProduto.ReadOnly = true;
                btnBuscar.Text = "...";
                var produto = Produto.ObterPorId(int.Parse(txtIdProduto.Text));
                if(produto.Id > 0)
                {
                     txtDescricaoProduto.Text = produto.Descricao;
                     txtDescontoProduto.Text = produto.Desconto.ToString();
                     txtPrecoProduto.Text = produto.Preco.ToString();
                     txtCodBarProduto.Text = produto.CodBar;
                     cbxUnidadeProduto.Text = produto.Unidade;
                     checkBoxDescontinuado.Checked = produto.Descontinuado;
                     btnEditarProduto.Enabled = true;

                }
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                int.Parse(txtIdProduto.Text),
                txtDescricaoProduto.Text,
                cbxUnidadeProduto.Text,
                txtCodBarProduto.Text,
                double.Parse(txtDescontoProduto.Text),
                double.Parse(txtPrecoProduto.Text),
                checkBoxDescontinuado.Checked
                );
            produto.Atualizar();
        }

        private void btnListarProduto_Click(object sender, EventArgs e)
        {
        //    List<Produto> list = Produto.Listar(
        //        txtIdProduto.Text, txtDescricaoProduto.Text, txt);
             
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
             if(txtPesquisar.Text.Length > 1)
            {
                CarregaGrid(txtPesquisar.Text); 
            }
             else if (txtPesquisar.Text.Length < 2)
            {
                CarregaGrid();
            }
        }

        private void checkBoxDescontinuado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDescontinuado.Checked)
                Produto.Restaurar(int.Parse(txtIdProduto.Text));
            else
                Produto.Arquivar(int.Parse(txtIdProduto.Text));
            CarregaGrid();
        }

        private void dataGridViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }
    }
}
