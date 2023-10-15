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
            pnlDesplegar.Visible = false;
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }

        private void cboxTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
