using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaCompra
{
    public partial class Ventas : Form
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private double facturaTotal = 0;
        private double facturaDolar = 0;
        public Ventas()
        {
            InitializeComponent();

            clientes = new List<Cliente>();
            productos = new List<Producto>();

            string pathClientes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");
            string[] lineasClientes = File.ReadAllLines(pathClientes);

            string pathProductos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
            string[] lineasProductos = File.ReadAllLines(pathProductos);

            int i = 0;

            foreach (string linea in lineasClientes.Skip(1))
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

            foreach (string linea in lineasProductos.Skip(1))
            {

                string[] valores = linea.Split(',');

                Producto producto = new Producto();
                producto.Codigo = valores[0];
                producto.Nombre = valores[1];
                producto.Cantidad = Convert.ToInt32(valores[2]);
                producto.CantidadMinima = Convert.ToInt32(valores[3]);
                producto.UnidadDeMedida = valores[4];
                producto.CostoUnitario = Convert.ToInt64(valores[5]);
                producto.PrecioDeVenta = Convert.ToInt64(valores[6]);

                if (valores[7] == "SI")
                {
                    producto.IVA = true;
                }

                else if (valores[7] == "NO")
                {
                    producto.IVA = false;
                }

                productos.Add(producto);
            }
        }


        public void VerificarCantidadDisponible()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad <= producto.CantidadMinima)
                {
                    MessageBox.Show($"ALERTA: El producto {producto.Nombre} tiene un nivel de stock bajo. Se solicitará un pedido al proveedor.");
                    double cantidadFaltante = producto.CantidadMinima - producto.Cantidad;
                    producto.Cantidad += cantidadFaltante;
                    MessageBox.Show($"Pedido realizado al Proveedor para el producto {producto.Nombre}.Cantidad:{cantidadFaltante}.");
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string buscador = textBoxCliente.Text;

            foreach (Cliente cliente in clientes)
            {
                if (buscador == Convert.ToString(cliente.Cedula))
                {
                    nombreTB.Text = cliente.Nombre;
                    apellidoTB.Text = cliente.Apellido;
                    telefonoTB.Text = cliente.Telefono;
                    emailTB.Text = cliente.CorreoElectronico;
                    direccionTB.Text = cliente.Direccion;
                    tipoDeDocumentoCB.Text = cliente.TipoDocumento.ToString();

                    if (cliente.ContribuyenteEspecial)
                    {
                        Si.Checked = true;
                    }
                    else
                    {
                        No.Checked = true;
                    }

                    break;
                }
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //VerificarCantidadDisponible();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string buscador = textBox2.Text;
                double cantidad = 0;
                if (!double.TryParse(cantidadTB.Text, out cantidad))
                {
                    MessageBox.Show("Introducir solo caracteres válidos");
                    cantidadTB.Clear();
                    return;
                }

                double precioTotal = 0;
                bool productoEncontrado = false;

                foreach (Producto producto in productos)
                {
                    if (buscador == Convert.ToString(producto.Codigo))
                    {
                        double precioUnitario = producto.PrecioDeVenta;
                        double totalLinea = cantidad * precioUnitario;
                        string iva = "16%";

                        if (producto.IVA)
                        {
                            iva = "16%";
                        }

                        else
                        {
                            iva = "0%";
                        }

                        factura.Rows.Add(producto.Codigo, producto.Nombre, cantidad, producto.UnidadDeMedida, precioUnitario, totalLinea, iva);

                        precioTotal = precioTotal + totalLinea;
                        productoEncontrado = true;
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    MessageBox.Show("Producto no encontrado");
                }


                facturaTotal = facturaTotal + precioTotal * 1.16;
                facturaDolar = facturaTotal / 34.9;
                LabelDolares.Text = $"Total en $: {facturaDolar.ToString("N2")}$";
                labelFactura.Text = $"{facturaTotal.ToString()}$";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && factura.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex < factura.Rows.Count && !factura.Rows[e.RowIndex].IsNewRow)
            {
                factura.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cantidadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvProductosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LabelDolares_Click(object sender, EventArgs e)
        {

        }
    }
}
