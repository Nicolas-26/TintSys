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
            CarregaGridEnd();
            CarregaGridTel();
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
            c.Alterar(Convert.ToInt32(txtIdCliente.Text));
            CarregaGrid();
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
            List<Endereco> list = Endereco.Listar();
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
                dgvEndereco.Rows[a].Cells[10].Value = item.Cliente.Id.ToString();
                a++;
            }
        }

        private void btnInserirEnd_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco(
                txtCepEnd.Text, txtLograEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, txtEstadoEnd.Text, Convert.ToString(txtUF.Text), txtTipoEnd.Text,
                Cliente.ObterPorId(Convert.ToInt32(txtCliente_id.Text))
                );
            end.Inserir();
            txtIdEnd.Text = end.Id.ToString();
            CarregaGridEnd();
        }

        private void btnConsultarEnd_Click(object sender, EventArgs e)
        {
            Endereco end = Endereco.ObterPorId(Convert.ToInt32(txtIdEnd.Text));
            txtCepEnd.Text = end.Cep;
            txtLograEnd.Text = end.Logradouro;
            txtBairroEnd.Text = end.Bairro;
            txtCidadeEnd.Text = end.Cidade;
            txtEstadoEnd.Text = end.Estado;
            txtUF.Text = end.UF.ToString();
            txtTipoEnd.Text = end.Tipo;
            txtCliente_id.Text = end.Cliente.Id.ToString();
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarEnd_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco( txtCepEnd.Text,
                txtLograEnd.Text, txtBairroEnd.Text, txtCidadeEnd.Text, txtEstadoEnd.Text, Convert.ToString(txtUF.Text), txtTipoEnd.Text
                );
            endereco.Atualizar(Convert.ToInt32(txtIdEnd.Text));
            CarregaGridEnd();
        }

        private void btnInserirTel_Click(object sender, EventArgs e)
        {
            Telefone tel = new Telefone(
                txtNumeroTel.Text, comboBoxTipo.Text
                );
            tel.Inserir(5);
            txtIdTel.Text = tel.Id.ToString();
            CarregaGridTel();
        }

        private void CarregaGridTel()
        {
            List<Telefone> list = Telefone.Listar();
            int a = 0;
            dgvTelefone.Rows.Clear();
            foreach(var item in list)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[a].Cells[0].Value = item.Id.ToString();
                dgvTelefone.Rows[a].Cells[1].Value = item.Numero;
                dgvTelefone.Rows[a].Cells[2].Value = item.Tipo;
                dgvTelefone.Rows[a].Cells[3].Value = item.Cliente.Id.ToString();
                a++;
            }
        }

        private void btnConsultarTel_Click(object sender, EventArgs e)
        {
            var telefone = Telefone.ObterPorId(Convert.ToInt32(txtIdTel.Text));
            txtNumeroTel.Text = telefone.Numero;
            comboBoxTipo.Text = telefone.Tipo;
            txtClienteidTel.Text = telefone.Cliente.Id.ToString();
        }

        private void btnEditarTel_Click(object sender, EventArgs e)
        {
            Telefone tel = new Telefone(
                txtNumeroTel.Text, comboBoxTipo.Text
                );
            tel.Atualizar(Convert.ToInt32(txtIdTel.Text));
            CarregaGridTel();
        }
    }
}
