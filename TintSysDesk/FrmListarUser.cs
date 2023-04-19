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
    public partial class FrmListarUser : Form
    {
        public FrmListarUser()
        {
            InitializeComponent();
        }

        private void FrmListarUser_Load(object sender, EventArgs e)
        {
            List<Usuarios> list = Usuarios.Listar();
            int l = 0;
            dgvListar.Rows.Clear();
            foreach (Usuarios us in list)
            {
                dgvListar.Rows.Add();
                dgvListar.Rows[l].Cells[0].Value = us.Id;
                dgvListar.Rows[l].Cells[1].Value = us.Nome;
                dgvListar.Rows[l].Cells[2].Value = us.Email;
                dgvListar.Rows[l].Cells[3].Value = us.Senha;
                dgvListar.Rows[l].Cells[4].Value = us.Nivel.Idd;
                dgvListar.Rows[l].Cells[5].Value = us.Ativo;
                l++;
            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
