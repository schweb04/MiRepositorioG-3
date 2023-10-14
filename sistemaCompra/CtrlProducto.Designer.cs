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
            lblPrecio = new Label();
            lblCosto = new Label();
            lblUnidad = new Label();
            lblIVA = new Label();
            lblCantidad = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptar = new PictureBox();
            pboxNo = new PictureBox();
            pboxSi = new PictureBox();
            pboxBarra6 = new PictureBox();
            pboxBarra5 = new PictureBox();
            pboxBarra4 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            txtUnidad = new TextBox();
            txtCosto = new TextBox();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.ControlProductos;
            pboxCtrlProductos.Location = new Point(136, 12);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(296, 30);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 51;
            pboxCtrlProductos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(22, 68);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(40, 38);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 52;
            pboxAgregar.TabStop = false;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(6, 4);
            pboxDatos.Margin = new Padding(3, 2, 3, 2);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(362, 230);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(txtPrecio);
            pnlDesplegar.Controls.Add(txtCosto);
            pnlDesplegar.Controls.Add(txtUnidad);
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
            pnlDesplegar.Controls.Add(pboxAceptar);
            pnlDesplegar.Controls.Add(pboxNo);
            pnlDesplegar.Controls.Add(pboxSi);
            pnlDesplegar.Controls.Add(pboxBarra6);
            pnlDesplegar.Controls.Add(pboxBarra5);
            pnlDesplegar.Controls.Add(pboxBarra4);
            pnlDesplegar.Controls.Add(pboxBarra3);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(224, 68);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(371, 241);
            pnlDesplegar.TabIndex = 55;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(238, 98);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(112, 13);
            lblPrecio.TabIndex = 69;
            lblPrecio.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(127, 98);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(105, 13);
            lblCosto.TabIndex = 68;
            lblCosto.Text = "Costo Unitario";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidad.Location = new Point(36, 98);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(77, 13);
            lblUnidad.TabIndex = 67;
            lblUnidad.Text = "Ud. Medida";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIVA.Location = new Point(26, 183);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(28, 13);
            lblIVA.TabIndex = 66;
            lblIVA.Text = "IVA";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidad.Location = new Point(256, 16);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(63, 13);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(159, 16);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 13);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCodigo.Location = new Point(51, 16);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 13);
            lblCodigo.TabIndex = 56;
            lblCodigo.Text = "Código";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(265, 183);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(79, 32);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptar.Location = new Point(180, 183);
            pboxAceptar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(79, 32);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 56;
            pboxAceptar.TabStop = false;
            // 
            // pboxNo
            // 
            pboxNo.Image = Properties.Resources.BotonCheckbox2;
            pboxNo.Location = new Point(121, 183);
            pboxNo.Margin = new Padding(3, 2, 3, 2);
            pboxNo.Name = "pboxNo";
            pboxNo.Size = new Size(53, 24);
            pboxNo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNo.TabIndex = 62;
            pboxNo.TabStop = false;
            // 
            // pboxSi
            // 
            pboxSi.Image = Properties.Resources.BotonCheckbox1;
            pboxSi.Location = new Point(60, 183);
            pboxSi.Margin = new Padding(3, 2, 3, 2);
            pboxSi.Name = "pboxSi";
            pboxSi.Size = new Size(53, 24);
            pboxSi.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSi.TabIndex = 56;
            pboxSi.TabStop = false;
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(238, 140);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(100, 27);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra5
            // 
            pboxBarra5.Image = Properties.Resources.ControlDato2;
            pboxBarra5.Location = new Point(132, 140);
            pboxBarra5.Name = "pboxBarra5";
            pboxBarra5.Size = new Size(100, 27);
            pboxBarra5.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra5.TabIndex = 60;
            pboxBarra5.TabStop = false;
            // 
            // pboxBarra4
            // 
            pboxBarra4.Image = Properties.Resources.ControlDato2;
            pboxBarra4.Location = new Point(26, 140);
            pboxBarra4.Name = "pboxBarra4";
            pboxBarra4.Size = new Size(100, 27);
            pboxBarra4.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra4.TabIndex = 59;
            pboxBarra4.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(238, 59);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(100, 27);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(132, 59);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(100, 27);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(26, 59);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(100, 27);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(84, 68);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(40, 38);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 56;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(146, 68);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(40, 38);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 57;
            pboxEliminar.TabStop = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(26, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 58;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 70;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(238, 41);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 71;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(26, 123);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 72;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(132, 123);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 73;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(238, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 74;
            // 
            // CtrlProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 313);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlProducto";
            Text = "CtrlProducto";
            Load += CtrlProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxAgregar;
        private PictureBox pboxDatos;
        private Panel pnlDesplegar;
        private PictureBox pboxBarra;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra4;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra5;
        private PictureBox pboxBarra6;
        private PictureBox pboxSi;
        private PictureBox pboxAceptar;
        private PictureBox pboxNo;
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
        private TextBox txtUnidad;
        private TextBox txtCantidad;
    }
}