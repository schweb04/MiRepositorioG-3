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
    public partial class CtrlProducto : Form
    {
        public CtrlProducto()
        {
            InitializeComponent();
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
        }

        private void CtrlProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
