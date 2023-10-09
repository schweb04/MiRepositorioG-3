namespace sistemaCompra
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            lblCodigo = new Label();
            txtCodigoProducto = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblNombre = new Label();
            txtNombreProducto = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblUnidad = new Label();
            txtUnidad = new TextBox();
            lblCostoUnitario = new Label();
            txtCosto = new TextBox();
            lblAgregarProducto = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(55, 64);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código ";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(110, 64);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(100, 23);
            txtCodigoProducto.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(722, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(693, 11);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(55, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(110, 105);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(151, 23);
            txtNombreProducto.TabIndex = 22;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(25, 153);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 23;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(86, 153);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(63, 23);
            txtCantidad.TabIndex = 24;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(177, 153);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(84, 15);
            lblUnidad.TabIndex = 25;
            lblUnidad.Text = "Ud. de Medida";
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(267, 153);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(84, 23);
            txtUnidad.TabIndex = 26;
            txtUnidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCostoUnitario
            // 
            lblCostoUnitario.AutoSize = true;
            lblCostoUnitario.Location = new Point(374, 153);
            lblCostoUnitario.Name = "lblCostoUnitario";
            lblCostoUnitario.Size = new Size(83, 15);
            lblCostoUnitario.TabIndex = 27;
            lblCostoUnitario.Text = "Costo Unitario";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(463, 153);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(69, 23);
            txtCosto.TabIndex = 28;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarProducto.ForeColor = Color.Black;
            lblAgregarProducto.Location = new Point(275, 11);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(248, 38);
            lblAgregarProducto.TabIndex = 29;
            lblAgregarProducto.Text = "Agregar Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(553, 153);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(88, 15);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "Precio de Venta";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(647, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(69, 23);
            txtPrecio.TabIndex = 31;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(586, 218);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 32;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(667, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 253);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblAgregarProducto);
            Controls.Add(txtCosto);
            Controls.Add(lblCostoUnitario);
            Controls.Add(txtUnidad);
            Controls.Add(lblUnidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigoProducto;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label lblNombre;
        private TextBox txtNombreProducto;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblUnidad;
        private TextBox txtUnidad;
        private Label lblCostoUnitario;
        private TextBox txtCosto;
        private Label lblAgregarProducto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}