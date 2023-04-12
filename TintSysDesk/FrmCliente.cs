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
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(
                txtNomeCliente.Text, mstCpf.Text, txtEmailCliente.Text
                );
            clientes.Inserir();
            txtIdCliente.Text = clientes.Id.ToString();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            var cliente = Clientes.ObterPorId(Convert.ToInt32(txtIdCliente.Text));
            txtNomeCliente.Text = cliente.Nome;
            mstCpf.Text = cliente.Cpf;
            txtEmailCliente.Text = cliente.Email;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes(
                int.Parse(txtIdCliente.Text), txtNomeCliente.Text, mstCpf.Text, txtEmailCliente.Text
                );
            c.Alterar(8);
        }

        private void tpgDadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void tpgEnderecos_Click(object sender, EventArgs e)
        {
            
        }

        private void labelComplemento_Click(object sender, EventArgs e)
        {

        }


    }
}
