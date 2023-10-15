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
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();
            List <Cliente> clientes = new List <Cliente>();
            string[] lineas = File.ReadAllLines("\"C:\\Users\\ojito\\OneDrive\\Documents\\pruebaCs.csv\"");

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(',');

            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgvProductosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
