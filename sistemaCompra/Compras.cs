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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSuperUser menu = new MenuSuperUser();
            menu.Show();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
