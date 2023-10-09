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
            MenuCajero menu = new MenuCajero();
            menu.Show();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            //Adicionamos nuevo renglón
            int filas = dtgvTablaProductos.Rows.Add();

            //Colocamos la información
            dtgvTablaProductos.Rows[filas].Cells[0].Value = "#01/";
            dtgvTablaProductos.Rows[filas].Cells[1].Value = "Jabón";
            dtgvTablaProductos.Rows[filas].Cells[2].Value = "300";
            dtgvTablaProductos.Rows[filas].Cells[3].Value = "Kilos";
            dtgvTablaProductos.Rows[filas].Cells[4].Value = "2.00";
            dtgvTablaProductos.Rows[filas].Cells[5].Value = "2.5";

        }

        private void pboxAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
