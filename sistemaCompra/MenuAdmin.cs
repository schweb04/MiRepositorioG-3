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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void pboxCtrlUsuarios_Click(object sender, EventArgs e)
        {
            
            CtrlUsuario ctrlUsuario = new CtrlUsuario();
            ctrlUsuario.ShowDialog();
            
        }

        private void pboxCtrlProductos_Click(object sender, EventArgs e)
        {
            CtrlProducto ctrlProducto = new CtrlProducto();
            ctrlProducto.ShowDialog();
        }

        private void pboxCtrlClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void pboxCtrlClientes_Click_1(object sender, EventArgs e)
        {
            CtrlCliente ctrlCliente = new CtrlCliente();
            ctrlCliente.ShowDialog();
        }

        private void MenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
