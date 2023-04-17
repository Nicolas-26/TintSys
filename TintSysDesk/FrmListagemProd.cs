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
    public partial class FrmListagemProd : Form
    {
        public FrmListagemProd()
        {
            InitializeComponent();
        }

        private void FrmListagemProd_Load(object sender, EventArgs e)
        {
            List<Produto> list = Produto.Listar();
            int a = 0;
            dgvListagem.Rows.Clear();
            foreach (Produto produto in list)
            {
                dgvListagem.Rows.Add();
                dgvListagem.Rows[a].Cells[0].Value = produto.Id;
                dgvListagem.Rows[a].Cells[1].Value = produto.Descricao;
                dgvListagem.Rows[a].Cells[2].Value = produto.Unidade;
                dgvListagem.Rows[a].Cells[3].Value = produto.CodBar;
                dgvListagem.Rows[a].Cells[4].Value = produto.Preco;
                dgvListagem.Rows[a].Cells[5].Value = produto.Desconto;
                dgvListagem.Rows[a].Cells[6].Value = produto.Descontinuado;
                a++;
            }
        }
    }
}
