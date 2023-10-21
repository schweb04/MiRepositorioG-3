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


        /*Hola Manuel;*/

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
            pboxAceptarEditar.Visible = false;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
            pboxAceptarAgregar.Visible = false;
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }


    }
}
