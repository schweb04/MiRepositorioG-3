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

        private void MenuSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MenuSuperUser_Load(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = false;
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = false;
        }

        private void pboxReseteoUsuarios_Click(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetear las contraseñas de los cajeros? Si lo haces tendrás que reestablecer las contraseñas.";
        }

        private void pboxReseteoDatos_Click(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetear los datos? Si lo haces tendrás que volver a ingresar los datos de productos, clientes y usuarios.";
        }

        private void pboxReseteoFabrica_Click(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetear hasta la versión de fábrica? Se perderán todos los datos.";
        }
    }
}
