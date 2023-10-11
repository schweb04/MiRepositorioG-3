using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCompra
{
    public partial class CtrlUsuario : Form
    {
        public CtrlUsuario()
        {
            InitializeComponent();
        }

        private void pboxVolver_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            this.Hide();
            menuAdmin.Show();
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
        }
    }
}
