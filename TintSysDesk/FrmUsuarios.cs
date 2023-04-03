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
            comboBoxNivel.DataSource = Nivel.Listar();
            comboBoxNivel.DisplayMember = "Id";
            comboBoxNivel.DisplayMember = "Nome";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(
                txtNome.Text, txtEmail.Text, txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(comboBoxNivel.SelectedValue))
                );
            user.Inserir();
            txtId.Text = user.Id.ToString();
            
        }
    }
}
