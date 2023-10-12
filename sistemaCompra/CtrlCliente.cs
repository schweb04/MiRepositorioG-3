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
    public partial class CtrlCliente : Form
    {




        public CtrlCliente()
        {
            InitializeComponent();
        }

        private void CtrlCliente_Load(object sender, EventArgs e)
        {

        }


        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
        }

        private void pboxVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
