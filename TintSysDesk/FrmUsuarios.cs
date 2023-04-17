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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void CarregaGridNivel()
        {
            Nivel iten = new Nivel();
            List<Nivel> listaN = Nivel.Listar();
            int l = 0;
            dgvNíveis.Rows.Clear();
            foreach (var item in listaN)
            {
                dgvNíveis.Rows.Add();
                dgvNíveis.Rows[l].Cells[0].Value = item.Id.ToString();
                dgvNíveis.Rows[l].Cells[1].Value = item.Name;
                dgvNíveis.Rows[l].Cells[2].Value = item.Siglaa;
                l++;
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregaGridNivel();
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(
                txtNome.Text, txtEmail.Text, txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(comboBoxNivel.SelectedValue))
                );  
            user.Inserir();
            txtId.Text = user.Id.ToString();
            CarregaGrid();
        }

        private void CarrregaComboNivel()
        {
            comboBoxNivel.DataSource = Nivel.Listar();
            //comboBoxNivel.ValueMember = "Id";
            comboBoxNivel.DisplayMember = "Nome";
        }

        private void CarregaGrid()
        {
            List<Usuarios> list = Usuarios.Listar();
            int linha = 0;
            dgvUsuarios.Rows.Clear();
            foreach (var item in list)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = item.Id.ToString();
                dgvUsuarios.Rows[linha].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = item.Senha;
                dgvUsuarios.Rows[linha].Cells[4].Value = item.Nivel;
                //dgvUsuarios.Rows[linha].Cells[5].Value = item.Ativo;
                linha++;
            }
        }

        private void btnConsultarNível_Click(object sender, EventArgs e)
        {
            Nivel n = Nivel.ObterPorId(Convert.ToInt32(txtIdNível.Text));
            txtNomeNível.Text = n.Name;
            txtSigla.Text = n.Siglaa;
            //CarregaGridNivel();
        }

        private void btnInserirNível_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNível.Text, txtSigla.Text);
            nivel.Inserir();
            txtIdNível.Text = nivel.Id.ToString();
            CarregaGridNivel();
        }

        private void btnEditarNível_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(
                txtNomeNível.Text, txtSigla.Text
                );
            n.Atualizar(Convert.ToInt32(txtIdNível.Text));
            CarregaGridNivel();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var user = Usuarios.ObterPorId(Convert.ToInt32(txtId.Text));
            txtNome.Text = user.Nome;
            txtEmail.Text = user.Email;
            txtSenha.Text = user.Senha;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(
                txtNome.Text, txtEmail.Text, txtSenha.Text
                );
            user.Atualizar(Convert.ToInt32(txtId.Text));
            CarregaGrid();
        }
    }
}
