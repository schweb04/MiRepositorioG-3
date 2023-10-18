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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void AgregarFormulario(Form ejemplo)
        {
            if (this.pnlMenuAdministrador.Controls.Count > 0)
                this.pnlMenuAdministrador.Controls.RemoveAt(0);
            ejemplo.TopLevel = false;
            ejemplo.Dock = DockStyle.Fill;
            this.pnlMenuAdministrador.Controls.Add(ejemplo);
            this.pnlMenuAdministrador.Tag = ejemplo;
            ejemplo.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta ventana se encuentran las distintas opciones \ny funcionalidades a las que tiene acceso el Administrador.");
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlUsuario>().FirstOrDefault();
            CtrlUsuario ctrlUsuario = form ?? new CtrlUsuario();
            AgregarFormulario(ctrlUsuario);
        }

        private void controlDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlProducto>().FirstOrDefault();
            CtrlProducto ctrlProducto = form ?? new CtrlProducto();
            AgregarFormulario(ctrlProducto);
        }

        private void controlDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlCliente>().FirstOrDefault();
            CtrlCliente ctrlCliente = form ?? new CtrlCliente();
            AgregarFormulario(ctrlCliente);
        }
    }
}
