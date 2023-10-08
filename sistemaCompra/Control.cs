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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSuperUser menu = new MenuSuperUser();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
