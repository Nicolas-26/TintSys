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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            List<Nivel> listaN = Nivel.Listar();
            int l = 0;
            foreach (var item in listaN)
            {
                dgvNíveis.Rows.Add();
                dgvNíveis.Rows[l].Cells[0].Value = Nivel.Id.ToString();
                dgvNíveis.Rows[l].Cells[1].Value = Nivel.Nome;
                dgvNíveis.Rows[l].Cells[2].Value = Nivel.Sigla;
            }


            List<Usuarios> listaU = Usuarios.Listar();
            int li = 0;
            foreach (var item in listaU)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[li].Cells[0].Value = item.Id.ToString();
                li++;
            }

            //CarrregaComboNivel();
            //CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(
                txtNome.Text, txtEmail.Text, txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(comboBoxNivel.SelectedValue))
                );  
            user.Inserir();
            txtId.Text = user.Id.ToString();
            //CarregaGrid();
        }

        private void CarrregaComboNivel()
        {
            comboBoxNivel.DataSource = Nivel.Listar();
            //comboBoxNivel.ValueMember = "Id";
            comboBoxNivel.DisplayMember = "Nome";
        }

        //private void CarregaGrid()
        //{
        //    List<Usuarios> list = Usuarios.Listar();
        //    int linha = 0;
        //    dgvNíveis.Rows.Clear();
        //    foreach (var item in list)
        //    {
        //        dgvNíveis.Rows.Add();
        //        dgvNíveis.Rows[linha].Cells[0].Value = item.Id.ToString();
        //        dgvNíveis.Rows[linha].Cells[1].Value = item.Nome;
        //        dgvNíveis.Rows[linha].Cells[2].Value = item.Email;
        //        dgvNíveis.Rows[linha].Cells[3].Value = item.Senha;
        //        dgvNíveis.Rows[linha].Cells[4].Value = item.Nivel;
        //        dgvNíveis.Rows[linha].Cells[5].Value = item.Ativo;
        //        linha++;
        //    }
        //}

        private void btnConsultarNível_Click(object sender, EventArgs e)
        {
            Nivel n = Nivel.ObterPorId(Convert.ToInt32(txtIdNível.Text));
            txtNomeNível.Text = Nivel.Nome;
            txtSigla.Text = Nivel.Sigla;
        }

        private void btnInserirNível_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNível.Text, txtSigla.Text);
            nivel.Inserir();
            txtIdNível.Text = Nivel.Id.ToString();
        }

        private void btnEditarNível_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(
                txtNomeNível.Text, txtSigla.Text
                );
            n.Atualizar();
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
            user.Atualizar();
        }
    }
}
