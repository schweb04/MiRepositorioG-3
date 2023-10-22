using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Examen.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaCompra
{
    public partial class Ventas : Form
    {
        private List<string> metodosDePago = new List<string>();

        private decimal subtotal = 100; //cambiar segun la logica de programacion
        private decimal dolarBCV = 2.00m; //cambiar segun la tasa del sistema
        private const decimal taxIGTF = 1.03m;
        private const decimal revIGTF = 0.9434m; //revierte el IGTF 
        private const decimal error = 0.01m; //Termino de error en las cuentas

        public object N2 { get; private set; }
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
                //VerificarPocaCantidad();
            }
        }


        public void VerificarPocaCantidad()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad <= producto.CantidadMinima)
                {
                    MessageBox.Show($"ALERTA: La cantidad disponible del producto '{producto.Nombre}' es menor a la cantidad mínima especificada del mismo.");
                }
            }
        }

        public bool VerificarCantidadVacia()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad == 0)
                {
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
            VerificarPocaCantidad();
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

                        //if ((producto.Cantidad == 0) || (producto.Cantidad < Convert.ToDouble(cantidadTB.Text)))
                        if (producto.Cantidad == 0)
                        {
                            MessageBox.Show("No hay unidades disponibles.");
                        }
                        else
                        {
                            double precioUnitario = producto.PrecioDeVenta;
                            double totalLinea = cantidad * precioUnitario;

                            factura.Rows.Add(producto.Codigo, producto.Nombre, cantidad, producto.UnidadDeMedida, precioUnitario, totalLinea, producto.IVA);

                            precioTotal = precioTotal + totalLinea;
                            productoEncontrado = true;
                        }
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

        //Boton Factura 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnBorrarMetodoPago.Visible = true;
            groupBox1.Visible = true;
            listMetdPagSelec.Visible = true;

        }
        
        private void btnBorrarMetodoPago_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un elemento en el ListBox
            if (listMetdPagSelec.SelectedIndex != -1)
            {
                // Obtiene el índice del elemento seleccionado
                int indiceSeleccionado = listMetdPagSelec.SelectedIndex;

                // Obtener el elemento seleccionado en el ListBox
                string elementoSeleccionado = metodosDePago[indiceSeleccionado].ToString();

                // Separar el monto y la moneda
                string[] partes = elementoSeleccionado.Split(' ');
                decimal monto = decimal.Parse(partes[1]);
                string moneda = partes[2];

                // Elimina el elemento de la lista
                metodosDePago.RemoveAt(indiceSeleccionado);

                // Elimina el elemento del ListBox
                listMetdPagSelec.Items.RemoveAt(indiceSeleccionado);

                // Actualizar el subtotal teniendo en cuenta la moneda
                if (moneda == "$")
                {
                    subtotal += (monto * dolarBCV) / taxIGTF;
                }
                else if (moneda == "Bs")
                {
                    subtotal += monto;
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el método de pago seleccionado.");
                }

            }
        }
        private void btnCerrarMetdPago_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listMetdPagSelec.Visible = false;
            btnBorrarMetodoPago.Visible = false;
        }

        private void ActualizarListBoxMetodosDePago()
        {
            // Limpia el ListBox para evitar duplicados.
            listMetdPagSelec.Items.Clear();

            // Agrega todos los métodos de pago a la lista.
            foreach (string metodoDePago in metodosDePago)
            {
                listMetdPagSelec.Items.Add(metodoDePago);
            }
        }
         private void btnEfectivoBs_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en Bs: (Subtotal: {subtotal:N2} Bs)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtEfectBs = new System.Windows.Forms.TextBox();
            txtEfectBs.Size = new Size(150, 50);
            txtEfectBs.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtEfectBs.Left, txtEfectBs.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtEfectBs.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= subtotal && montoIngresado != 0)
                    {
                        subtotal -= montoIngresado;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} Bs", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "EfectivoBs";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} Bs");

                        // Limpia el TextBox después de aceptar el valor.
                        txtEfectBs.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {subtotal:N2} Bs. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtEfectBs);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();

        }
        private void btnEfectivoDolares_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en $: (Subtotal: {((subtotal * taxIGTF) / dolarBCV):N2} $)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtEfectDolar = new System.Windows.Forms.TextBox();
            txtEfectDolar.Size = new Size(150, 50);
            txtEfectDolar.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtEfectDolar.Left, txtEfectDolar.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtEfectDolar.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= ((subtotal * taxIGTF / dolarBCV)+error) && montoIngresado != 0)
                    {
                        subtotal = ((subtotal / dolarBCV) * taxIGTF) - montoIngresado;
                        subtotal *= dolarBCV*revIGTF;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} $", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "Efectivo$";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} $");

                        // Limpia el TextBox después de aceptar el valor.
                        txtEfectDolar.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {((subtotal * taxIGTF) / dolarBCV):N2}  $. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtEfectDolar);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();


        }
        private void btnTarjetaDebCred_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en Bs: (Subtotal: {subtotal:N2} Bs)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtTarjeta = new System.Windows.Forms.TextBox();
            txtTarjeta.Size = new Size(150, 50);
            txtTarjeta.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtTarjeta.Left, txtTarjeta.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtTarjeta.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= subtotal && montoIngresado != 0)
                    {
                        subtotal -= montoIngresado;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} Bs", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "Tarjeta";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} Bs");

                        // Limpia el TextBox después de aceptar el valor.
                        txtTarjeta.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {subtotal:N2} Bs. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtTarjeta);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();

        }
        private void btnTarjAlimCestaT_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en Bs: (Subtotal: {subtotal:N2} Bs)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtCestaticket = new System.Windows.Forms.TextBox();
            txtCestaticket.Size = new Size(150, 50);
            txtCestaticket.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtCestaticket.Left, txtCestaticket.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtCestaticket.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= subtotal && montoIngresado != 0)
                    {
                        subtotal -= montoIngresado;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} Bs", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "Cestaticket";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} Bs");

                        // Limpia el TextBox después de aceptar el valor.
                        txtCestaticket.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {subtotal:N2} Bs. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtCestaticket);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();


        }
        private void btnPagoMov_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en Bs: (Subtotal: {subtotal:N2} Bs)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtTransferencia = new System.Windows.Forms.TextBox();
            txtTransferencia.Size = new Size(150, 50);
            txtTransferencia.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtTransferencia.Left, txtTransferencia.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtTransferencia.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= subtotal && montoIngresado != 0)
                    {
                        subtotal -= montoIngresado;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} Bs", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "Transferencia";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} Bs");

                        // Limpia el TextBox después de aceptar el valor.
                        txtTransferencia.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {subtotal:N2} Bs. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtTransferencia);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();

        }
        private void btnZelle_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana emergente
            Form ventanaEmergente = new Form();
            ventanaEmergente.StartPosition = FormStartPosition.CenterScreen;

            // Crear un nuevo Label para el mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = $"Ingrese el monto en $: (Subtotal: {((subtotal * taxIGTF) / dolarBCV):N2} $)";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 10);

            // Crear un nuevo TextBox para el precio ingresado
            System.Windows.Forms.TextBox txtZelle = new System.Windows.Forms.TextBox();
            txtZelle.Size = new Size(150, 50);
            txtZelle.Location = new Point(10, lblMensaje.Bottom + 10);

            // Crear un botón para aceptar el valor ingresado
            System.Windows.Forms.Button btnAceptar = new System.Windows.Forms.Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(txtZelle.Left, txtZelle.Bottom + 10);
            btnAceptar.Click += (senderBtn, eBtn) =>
            {
                string precioIngresado = txtZelle.Text;

                // Validaciones

                // Reemplazar "." por "," en la entrada
                precioIngresado = precioIngresado.Replace('.', ',');

                // Convierte la cadena a un valor decimal
                if (decimal.TryParse(precioIngresado, out decimal montoIngresado))
                {
                    // Tomar el valor absoluto
                    montoIngresado = Math.Abs(montoIngresado);

                    // Redondear a 2 decimales
                    montoIngresado = Math.Round(montoIngresado, 2);

                    // Verificar que el monto no sea mayor que el subtotal
                    if (montoIngresado <= ((subtotal * taxIGTF / dolarBCV) + error) && montoIngresado != 0)
                    {
                        subtotal = (subtotal / dolarBCV * taxIGTF) - montoIngresado;
                        subtotal *= dolarBCV * revIGTF;

                        MessageBox.Show($"El Subtotal Restante es: {subtotal:N2} Bs\nPrecio válido: {montoIngresado:N2} $", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Agrega el método de pago y monto ingresado a la lista.
                        string metodoDePago = "Zelle$";
                        metodosDePago.Add($"{metodoDePago} {montoIngresado:N2} $");

                        // Limpia el TextBox después de aceptar el valor.
                        txtZelle.Text = string.Empty;

                        // Muestra la lista actualizada en el control ListBox.
                        ActualizarListBoxMetodosDePago();
                        subtotal /= taxIGTF;
                    }
                    else
                    {
                        MessageBox.Show($"El monto ingresado no se le puede descontar al Subtotal: {((subtotal * taxIGTF) / dolarBCV):N2}  Bs. Favor ingresar un valor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El precio ingresado no cumple con los requisitos.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ventanaEmergente.Close(); // Cierra la ventana emergente después de aceptar.
            };

            // Agregar los controles a la ventana emergente
            ventanaEmergente.Controls.Add(lblMensaje);
            ventanaEmergente.Controls.Add(txtZelle);
            ventanaEmergente.Controls.Add(btnAceptar);

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();


        }
        


        
    }
}
