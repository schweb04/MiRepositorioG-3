using Microsoft.VisualBasic.ApplicationServices;
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
        private Cliente clienteSeleccionado;

        public Ventas()
        {
            InitializeComponent();

            clientes = new List<Cliente>();
            productos = new List<Producto>();
            Cliente clienteSeleccionado = new Cliente();

            string pathClientes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");
            string[] lineasClientes = File.ReadAllLines(pathClientes);

            string pathProductos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
            string[] lineasProductos = File.ReadAllLines(pathProductos);


            foreach (string linea in lineasClientes.Skip(1))
            {

                string[] valores = linea.Split(',');

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

            foreach (string linea in lineasProductos.Skip(1))
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


            }
        }





        public void VerificarCantidadDisponible()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad < producto.CantidadMinima)
                {
                    MessageBox.Show($"ALERTA: La cantidad disponible del producto {producto.Nombre} es menor a su cantidad mínima especificada.");
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

                    clienteSeleccionado = cliente;
                    break;
                }
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            VerificarCantidadDisponible();
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
                    producto.Cantidad = producto.Cantidad - cantidadVendida;
                    break;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            string buscador = textBox2.Text;
            double cantidad = Convert.ToDouble(cantidadTB.Text);


            foreach (Producto producto in productos)
            {
                if (buscador == Convert.ToString(producto.Codigo))
                {
                    if (producto.Cantidad == 0)
                    {
                        MessageBox.Show($"El producto {producto.Nombre} no está disponible.");
                        break;
                    }

                    else if (producto.Cantidad < cantidad)
                    {
                        MessageBox.Show($"La cantidad solicitada del producto {producto.Nombre} es mayor a la disponible.");
                        break;
                    }

                    else
                    {
                        double precioUnitario = producto.PrecioDeVenta;
                        double totalLinea;
                        string IVA;

                        if (producto.IVA && clienteSeleccionado.ContribuyenteEspecial)
                        {
                            IVA = "16%";
                            totalLinea = cantidad * precioUnitario * 1.16;
                        }

                        else
                        {
                            IVA = "0%";
                            totalLinea = cantidad * precioUnitario;
                        }

                        factura.Rows.Add(producto.Codigo, producto.Nombre, cantidad, producto.UnidadDeMedida, precioUnitario, totalLinea, IVA);
                        restarProducto(buscador, cantidad);
                        break;
                    }

                }

            }

            refrescarPrecio();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && factura.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex < factura.Rows.Count && !factura.Rows[e.RowIndex].IsNewRow)
            {
                string codigo = factura.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                double cantidad = Convert.ToDouble(factura.Rows[e.RowIndex].Cells["Quantity"].Value);
                reStock(codigo, cantidad);
                factura.Rows.RemoveAt(e.RowIndex);
                refrescarPrecio();
            }
        }

        private void reStock(string codigo, double cantidad)
        {
            foreach (Producto producto in productos)
            {
                if (codigo == producto.Codigo)
                {
                    producto.Cantidad = producto.Cantidad + cantidad;
                    break;
                }
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

        private void Ventas_Load_1(object sender, EventArgs e)
        {
            refrescarPrecio();
        }

        private void refrescarPrecio()
        {
            double precioTotal = 0;
            foreach (DataGridViewRow fila in factura.Rows)
            {

                // Asegúrate de que no estás procesando la fila de encabezado
                if (!fila.IsNewRow)
                {
                    // Nombre de la columna de precios, reemplázalo con el nombre real de tu columna

                    // Asegúrate de que la columna existe en la fila
                    if (fila.Cells["Total"].Value != null)
                    {
                        // Obtener el valor de la celda en la columna de precios
                        double precio = Convert.ToInt64(fila.Cells["Total"].Value);

                        // Sumar al precio total
                        precioTotal += precio;
                    }
                }
            }

            subtotal.Text = $"Subtotal: {precioTotal.ToString()} Bs.D";
        }
    }
}

