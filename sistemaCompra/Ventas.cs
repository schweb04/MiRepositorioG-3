using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sistemaCompra
{
    public partial class Ventas : Form
    {
        private List<Cliente> clientes;

        public Ventas()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            string[] lineas = File.ReadAllLines("C:\\Users\\ojito\\OneDrive\\Documents\\pruebaCs.csv");
            int i = 0;

             
            foreach (string linea in lineas.Skip(1))
            {

                string[] valores = linea.Split(',');

                if (valores[0] != "")
                {

                    Cliente cliente = new Cliente();
                    cliente.Cedula = Convert.ToInt32(valores[0]);
                    cliente.Nombre = valores[1];
                    cliente.Apellido = valores[2];
                    cliente.Direccion = valores[3];
                    cliente.Telefono = valores[4];
                    cliente.CorreoElectronico = valores[5];
                    cliente.TipoDocumento = Convert.ToChar(valores[6]);
                    cliente.ContribuyenteEspecial = Convert.ToBoolean(valores[7]);
                    clientes.Add(cliente);
                    }

                i++;
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
            string buscador = clienteCedulaTB.Text;

            try
            {
                foreach (Cliente cliente in clientes)
                {
                    if (buscador == Convert.ToString(cliente.Cedula))
                    {
                        textBoxPrueba.Text = $"{cliente.Nombre}";
                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                textBoxPrueba.Text = "error";
            }

            }

        private void textBoxPrueba_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
