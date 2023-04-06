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
            CarrregaComboNivel();
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(
                txtNome.Text, txtEmail.Text, txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(comboBoxNivel.SelectedValue))
                );  
            user.Inserir();
            //Id = user.Id.ToString();
            CarregaGrid();
        }

        private void CarrregaComboNivel()
        {
            comboBoxNivel.Items.Clear();
            comboBoxNivel.DataSource = Nivel.Listar();
            comboBoxNivel.ValueMember = "Id";
            comboBoxNivel.DisplayMember = "Nome";
        }

        private void CarregaGrid()
        {
            List<Usuarios> list = Usuarios.Listar();
            int linha = 0;
            dgvNíveis.Rows.Clear();
            foreach (var item in list)
            {
                dgvNíveis.Rows.Add();
                dgvNíveis.Rows[linha].Cells[0].Value = item.Id.ToString();
                dgvNíveis.Rows[linha].Cells[1].Value = item.Nome;
                dgvNíveis.Rows[linha].Cells[2].Value = item.Email;
                dgvNíveis.Rows[linha].Cells[3].Value = item.Nivel;
                dgvNíveis.Rows[linha].Cells[4].Value = item.Ativo;
                linha++;
            }
        }

        private void btnConsultarNível_Click(object sender, EventArgs e)
        {
            
        }
    }
}
