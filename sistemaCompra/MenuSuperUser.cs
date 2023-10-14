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
    public partial class MenuSuperUser : Form
    {
        public MenuSuperUser()
        {
            InitializeComponent();
        }


        private void pboxCtrlUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void MenuSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Deseas reiniciar los usuarios? No podras recuperar datos que no hayas respaldado", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Lista de usuarios reiniciada, agrega nuevos usuarios para acceder al sistema");
            }
        }

        private void pboxCtrlUsuarios_Click_1(object sender, EventArgs e)
        {
            CtrlUsuario ctrlUsuario = new CtrlUsuario();
            ctrlUsuario.ShowDialog();
        }
    }
}
