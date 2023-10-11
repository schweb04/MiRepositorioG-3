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
    public enum OrigenMenu
    {
        Cajero,
        Admin
    }

    public partial class CtrlCliente : Form
    {


        private OrigenMenu origen;


        public CtrlCliente(OrigenMenu origen)
        {
            InitializeComponent();
            this.origen = origen;
        }

        private void CtrlCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            switch (origen)
            {
                case OrigenMenu.Cajero:
                   
                    MenuCajero formMenuCajero = new MenuCajero();
                    formMenuCajero.Show();
                    break;

                case OrigenMenu.Admin:
                    
                    MenuAdmin formMenuAdmin = new MenuAdmin();
                    formMenuAdmin.Show();
                    break;
            }

            this.Close();
        }
    }
}
