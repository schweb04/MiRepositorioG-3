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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        /*
         Hay que cambiar el diseño de los botones Aceptar y Cancelar
        Así como la fuente de los labels de cada atributo de Producto
        Y si se puede (yo creo que si), el diseño de los textboxes
         */

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
