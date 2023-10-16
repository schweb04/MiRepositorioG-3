namespace sistemaCompra
{
    partial class CtrlProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pboxCtrlProductos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxDatos = new PictureBox();
            pnlDesplegar = new Panel();
            pboxAceptarEditar = new PictureBox();
            cboxSiYNo = new ComboBox();
            cboxUdMedidas = new ComboBox();
            txtPrecio = new TextBox();
            txtCosto = new TextBox();
            txtCantidad = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblPrecio = new Label();
            lblCosto = new Label();
            lblUnidad = new Label();
            lblIVA = new Label();
            lblCantidad = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptarAgregar = new PictureBox();
            pboxBarra6 = new PictureBox();
            pboxBarra5 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            pboxLista = new PictureBox();
            dtgvListaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.ControlProductos;
            pboxCtrlProductos.Location = new Point(155, 16);
            pboxCtrlProductos.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(338, 40);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 51;
            pboxCtrlProductos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(24, 80);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(46, 51);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 52;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(7, 5);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(414, 317);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(cboxSiYNo);
            pnlDesplegar.Controls.Add(cboxUdMedidas);
            pnlDesplegar.Controls.Add(txtPrecio);
            pnlDesplegar.Controls.Add(txtCosto);
            pnlDesplegar.Controls.Add(txtCantidad);
            pnlDesplegar.Controls.Add(txtNombre);
            pnlDesplegar.Controls.Add(txtCodigo);
            pnlDesplegar.Controls.Add(lblPrecio);
            pnlDesplegar.Controls.Add(lblCosto);
            pnlDesplegar.Controls.Add(lblUnidad);
            pnlDesplegar.Controls.Add(lblIVA);
            pnlDesplegar.Controls.Add(lblCantidad);
            pnlDesplegar.Controls.Add(lblNombre);
            pnlDesplegar.Controls.Add(lblCodigo);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Controls.Add(pboxAceptarAgregar);
            pnlDesplegar.Controls.Add(pboxBarra6);
            pnlDesplegar.Controls.Add(pboxBarra5);
            pnlDesplegar.Controls.Add(pboxBarra3);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(255, 80);
            pnlDesplegar.Margin = new Padding(3, 4, 3, 4);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(425, 332);
            pnlDesplegar.TabIndex = 55;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(206, 256);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(90, 43);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // cboxSiYNo
            // 
            cboxSiYNo.FormattingEnabled = true;
            cboxSiYNo.Items.AddRange(new object[] { "SI", "NO" });
            cboxSiYNo.Location = new Point(80, 256);
            cboxSiYNo.Margin = new Padding(3, 4, 3, 4);
            cboxSiYNo.Name = "cboxSiYNo";
            cboxSiYNo.Size = new Size(63, 28);
            cboxSiYNo.TabIndex = 64;
            // 
            // cboxUdMedidas
            // 
            cboxUdMedidas.FormattingEnabled = true;
            cboxUdMedidas.Items.AddRange(new object[] { "Kilogramo (Kg)", "Litro (L)", "Unidad (Ud.)" });
            cboxUdMedidas.Location = new Point(41, 176);
            cboxUdMedidas.Margin = new Padding(3, 4, 3, 4);
            cboxUdMedidas.Name = "cboxUdMedidas";
            cboxUdMedidas.Size = new Size(102, 28);
            cboxUdMedidas.TabIndex = 58;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(272, 176);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 74;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(151, 176);
            txtCosto.Margin = new Padding(3, 4, 3, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(114, 27);
            txtCosto.TabIndex = 73;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(272, 68);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 71;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 68);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 70;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(41, 68);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 27);
            txtCodigo.TabIndex = 58;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(272, 155);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(143, 17);
            lblPrecio.TabIndex = 69;
            lblPrecio.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(145, 155);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(134, 17);
            lblCosto.TabIndex = 68;
            lblCosto.Text = "Costo Unitario";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidad.Location = new Point(41, 155);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(98, 17);
            lblUnidad.TabIndex = 67;
            lblUnidad.Text = "Ud. Medida";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIVA.Location = new Point(41, 256);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(35, 17);
            lblIVA.TabIndex = 66;
            lblIVA.Text = "IVA";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidad.Location = new Point(293, 44);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(80, 17);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(183, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCodigo.Location = new Point(63, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(62, 17);
            lblCodigo.TabIndex = 56;
            lblCodigo.Text = "Código";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(303, 256);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(90, 43);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxAceptarAgregar
            // 
            pboxAceptarAgregar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarAgregar.Location = new Point(206, 256);
            pboxAceptarAgregar.Name = "pboxAceptarAgregar";
            pboxAceptarAgregar.Size = new Size(90, 43);
            pboxAceptarAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarAgregar.TabIndex = 56;
            pboxAceptarAgregar.TabStop = false;
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(272, 203);
            pboxBarra6.Margin = new Padding(3, 4, 3, 4);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(114, 36);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra5
            // 
            pboxBarra5.Image = Properties.Resources.ControlDato2;
            pboxBarra5.Location = new Point(151, 203);
            pboxBarra5.Margin = new Padding(3, 4, 3, 4);
            pboxBarra5.Name = "pboxBarra5";
            pboxBarra5.Size = new Size(114, 36);
            pboxBarra5.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra5.TabIndex = 60;
            pboxBarra5.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(272, 93);
            pboxBarra3.Margin = new Padding(3, 4, 3, 4);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(114, 36);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(151, 93);
            pboxBarra2.Margin = new Padding(3, 4, 3, 4);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(114, 36);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(41, 93);
            pboxBarra.Margin = new Padding(3, 4, 3, 4);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(103, 36);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(96, 80);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(46, 51);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 56;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(167, 80);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(46, 51);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 57;
            pboxEliminar.TabStop = false;
            // 
            // pboxLista
            // 
            pboxLista.Location = new Point(14, 137);
            pboxLista.Margin = new Padding(3, 4, 3, 4);
            pboxLista.Name = "pboxLista";
            pboxLista.Size = new Size(199, 271);
            pboxLista.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLista.TabIndex = 58;
            pboxLista.TabStop = false;
            // 
            // dtgvListaProductos
            // 
            dtgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaProductos.Location = new Point(34, 207);
            dtgvListaProductos.Margin = new Padding(3, 4, 3, 4);
            dtgvListaProductos.Name = "dtgvListaProductos";
            dtgvListaProductos.RowHeadersWidth = 51;
            dtgvListaProductos.RowTemplate.Height = 25;
            dtgvListaProductos.Size = new Size(161, 184);
            dtgvListaProductos.TabIndex = 65;
            // 
            // CtrlProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 424);
            Controls.Add(dtgvListaProductos);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CtrlProducto";
            Text = "CtrlProducto";
            Load += CtrlProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxAgregar;
        private PictureBox pboxDatos;
        private Panel pnlDesplegar;
        private PictureBox pboxBarra;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra5;
        private PictureBox pboxBarra6;
        private PictureBox pboxAceptarAgregar;
        private PictureBox pboxCancelar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCantidad;
        private Label lblUnidad;
        private Label lblIVA;
        private Label lblCosto;
        private Label lblPrecio;
        private PictureBox pboxEditar;
        private PictureBox pboxEliminar;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtCosto;
        private TextBox txtCantidad;
        private ComboBox cboxUdMedidas;
        private ComboBox cboxSiYNo;
        private PictureBox pboxAceptarEditar;
        private PictureBox pboxLista;
        private DataGridView dtgvListaProductos;
    }
}