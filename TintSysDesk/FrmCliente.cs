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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //Clientes cli = new Clientes();
            //cli.Excluir(2); 
            CarregaGrid();
           
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente(
                txtNomeCliente.Text, mstCpf.Text, txtEmailCliente.Text
                );
            clientes.Inserir();
            txtIdCliente.Text = clientes.Id.ToString();
            CarregaGrid();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            var cliente = Cliente.ObterPorId(Convert.ToInt32(txtIdCliente.Text));
            txtNomeCliente.Text = cliente.Nome;
            mstCpf.Text = cliente.Cpf;
            txtEmailCliente.Text = cliente.Email;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(
                int.Parse(txtIdCliente.Text), txtNomeCliente.Text, mstCpf.Text, txtEmailCliente.Text
                );
            c.Alterar(8);
        }

        private void tpgDadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void tpgEnderecos_Click(object sender, EventArgs e)
        {
            CarregaGridEnd(); 
        }

        private void labelComplemento_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGrid()
        {
            List<Cliente> list = Cliente.Listar();
            int c = 0;
            dgvCliente.Rows.Clear();
            foreach (var item in list)
            {
                dgvCliente.Rows.Add();
                dgvCliente.Rows[c].Cells[0].Value = item.Id.ToString();
                dgvCliente.Rows[c].Cells[1].Value = item.Nome;
                dgvCliente.Rows[c].Cells[2].Value = item.Cpf;
                dgvCliente.Rows[c].Cells[3].Value = item.Email;
                dgvCliente.Rows[c].Cells[4].Value = item.Data;
                dgvCliente.Rows[c].Cells[5].Value = Convert.ToBoolean(item.Ativo);
                c++;
            }
        }

        private void CarregaGridEnd()
        {
            List<Endereco> list = new List<Endereco>();
            int a = 0;
            dgvEndereco.Rows.Clear();
            foreach(var item in list)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[a].Cells[0].Value = item.Id.ToString();
                dgvEndereco.Rows[a].Cells[1].Value = item.Cep;
                dgvEndereco.Rows[a].Cells[2].Value = item.Logradouro;
                dgvEndereco.Rows[a].Cells[3].Value = item.Numero;
                dgvEndereco.Rows[a].Cells[4].Value = item.Complemento;
                dgvEndereco.Rows[a].Cells[5].Value = item.Bairro;
                dgvEndereco.Rows[a].Cells[6].Value = item.Cidade;
                dgvEndereco.Rows[a].Cells[7].Value = item.Estado;
                dgvEndereco.Rows[a].Cells[8].Value = item.UF;
                dgvEndereco.Rows[a].Cells[9].Value = item.Tipo;
                dgvEndereco.Rows[a].Cells[10].Value = item.Clientes.Id.ToString();
                a++;
            }
        }

        private void btnInserirEnd_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco(
                txtCepEnd.Text, txtLograEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, txtEstadoEnd.Text, txtUF.Text, txtTipoEnd.Text
                );
            end.Inserir(2);
            txtIdEnd.Text = end.Id.ToString();
        }
    }
}
