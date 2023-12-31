﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    try
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
                    catch (Exception e)
                    {
                        MessageBox.Show("Nooo");
                    }
                }

                i++;
            }

            foreach (string linea in lineasProductos.Skip(1))
            {
                try
                {
                    string[] valores = linea.Split(',');

                    Producto producto = new Producto();
                    producto.Codigo = valores[0];
                    producto.Nombre = valores[1];
                    producto.Cantidad = Convert.ToInt64(valores[2]);
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
                    DTGVConsultaID.Rows.Add(producto.Codigo, producto.Nombre);
                }
                catch (Exception e)
                {
                    MessageBox.Show("aaah");
                }
            }
        }

        public bool VerificarCantidadDisponible()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad < producto.CantidadMinima)
                {
                    Console.WriteLine($"ALERTA: El producto {producto.Nombre} tiene un nivel de stock bajo. Se recomienda solicitar un pedido al proveedor.");
                    return true;
                }
            }
            return false;
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
            //if (VerificarCantidadDisponible() == true)
            //{
            //    this.Close();
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void restarProducto(string codigoProducto, double cantidadVendida)
        {
            foreach (Producto producto in productos)
            {
                if (codigoProducto == producto.Codigo)
                {
                    if (producto.Cantidad != 0)
                    {
                        producto.Cantidad = producto.Cantidad - cantidadVendida;

                        break;
                    }
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string buscador = textBox2.Text;
                double cantidad = Convert.ToDouble(cantidadTB.Text);
                double precioTotal = 0;

                foreach (Producto producto in productos)
                {
                    if (buscador == Convert.ToString(producto.Codigo))
                    {
                        double precioUnitario = producto.PrecioDeVenta;
                        double totalLinea = cantidad * precioUnitario;

                        factura.Rows.Add(producto.Codigo, producto.Nombre, cantidad, producto.UnidadDeMedida, precioUnitario, totalLinea, producto.IVA);

                        restarProducto(buscador, cantidad);
                        precioTotal = precioTotal + totalLinea;

                        break;
                    }
                }

                facturaTotal = facturaTotal + precioTotal * 1.16;
                facturaDolar = facturaDolar + facturaTotal / 34.9;
                LabelDolares.Text = $"Total en $: {facturaDolar.ToString("N2")}$";
                labelFactura.Text = $"{facturaTotal.ToString()}$";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introducir solo caracteres válidos");
                cantidadTB.Clear();
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

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            foreach(Cliente cliente in clientes)
            {
                if(textBoxCliente.Text == Convert.ToString(cliente.Cedula) && tipoDeDocumentoCB.Text == Convert.ToString(cliente.TipoDocumento))
                {
                    nombreTB.Text = cliente.Nombre;
                    apellidoTB.Text = cliente.Apellido;
                    direccionTB.Text = cliente.Direccion;
                    telefonoTB.Text = cliente.Telefono;
                    emailTB.Text = cliente.CorreoElectronico;
                    if(cliente.ContribuyenteEspecial)
                    {
                        Si.Checked = true;
                    }
                    else
                    {
                        No.Checked = true;
                    }
                }
            }
        }
    }
}
