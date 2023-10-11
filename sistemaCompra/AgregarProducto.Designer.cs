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
            txtCodigoProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCantidad = new TextBox();
            txtUnidad = new TextBox();
            txtCosto = new TextBox();
            txtPrecio = new TextBox();
            pboxAceptar = new PictureBox();
            pboxCancelar = new PictureBox();
            pboxCodigoProducto = new PictureBox();
            pboxAgregarPr = new PictureBox();
            pboxNombreProducto = new PictureBox();
            pboxCantidad = new PictureBox();
            pboxUnidad = new PictureBox();
            pboxCosto = new PictureBox();
            pboxPrecio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCodigoProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarPr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNombreProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxUnidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPrecio).BeginInit();
            SuspendLayout();
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProducto.Location = new Point(109, 99);
            txtCodigoProducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(172, 27);
            txtCodigoProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(377, 99);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(196, 27);
            txtNombreProducto.TabIndex = 22;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(121, 180);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(159, 27);
            txtCantidad.TabIndex = 24;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(277, 259);
            txtUnidad.Margin = new Padding(3, 4, 3, 4);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(158, 27);
            txtUnidad.TabIndex = 26;
            txtUnidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(445, 180);
            txtCosto.Margin = new Padding(3, 4, 3, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(142, 27);
            txtCosto.TabIndex = 28;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(749, 180);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(162, 27);
            txtPrecio.TabIndex = 31;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar;
            pboxAceptar.Location = new Point(655, 328);
            pboxAceptar.Margin = new Padding(3, 4, 3, 4);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(122, 52);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 34;
            pboxAceptar.TabStop = false;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar;
            pboxCancelar.Location = new Point(784, 328);
            pboxCancelar.Margin = new Padding(3, 4, 3, 4);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(126, 52);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 35;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxCodigoProducto
            // 
            pboxCodigoProducto.Image = Properties.Resources.ClienteNuevo2;
            pboxCodigoProducto.Location = new Point(29, 99);
            pboxCodigoProducto.Margin = new Padding(3, 4, 3, 4);
            pboxCodigoProducto.Name = "pboxCodigoProducto";
            pboxCodigoProducto.Size = new Size(253, 60);
            pboxCodigoProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCodigoProducto.TabIndex = 36;
            pboxCodigoProducto.TabStop = false;
            // 
            // pboxAgregarPr
            // 
            pboxAgregarPr.Image = Properties.Resources.ProductoNuevo1;
            pboxAgregarPr.Location = new Point(289, 15);
            pboxAgregarPr.Margin = new Padding(3, 4, 3, 4);
            pboxAgregarPr.Name = "pboxAgregarPr";
            pboxAgregarPr.Size = new Size(336, 61);
            pboxAgregarPr.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarPr.TabIndex = 37;
            pboxAgregarPr.TabStop = false;
            // 
            // pboxNombreProducto
            // 
            pboxNombreProducto.Image = Properties.Resources.ClienteNuevo3;
            pboxNombreProducto.Location = new Point(305, 99);
            pboxNombreProducto.Margin = new Padding(3, 4, 3, 4);
            pboxNombreProducto.Name = "pboxNombreProducto";
            pboxNombreProducto.Size = new Size(269, 60);
            pboxNombreProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNombreProducto.TabIndex = 38;
            pboxNombreProducto.TabStop = false;
            // 
            // pboxCantidad
            // 
            pboxCantidad.Image = Properties.Resources.ProductoNuevo2;
            pboxCantidad.Location = new Point(29, 180);
            pboxCantidad.Margin = new Padding(3, 4, 3, 4);
            pboxCantidad.Name = "pboxCantidad";
            pboxCantidad.Size = new Size(253, 60);
            pboxCantidad.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCantidad.TabIndex = 39;
            pboxCantidad.TabStop = false;
            // 
            // pboxUnidad
            // 
            pboxUnidad.Image = Properties.Resources.ProductoNuevo3;
            pboxUnidad.Location = new Point(166, 259);
            pboxUnidad.Margin = new Padding(3, 4, 3, 4);
            pboxUnidad.Name = "pboxUnidad";
            pboxUnidad.Size = new Size(270, 57);
            pboxUnidad.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUnidad.TabIndex = 40;
            pboxUnidad.TabStop = false;
            // 
            // pboxCosto
            // 
            pboxCosto.Image = Properties.Resources.ProductoNuevo4;
            pboxCosto.Location = new Point(305, 180);
            pboxCosto.Margin = new Padding(3, 4, 3, 4);
            pboxCosto.Name = "pboxCosto";
            pboxCosto.Size = new Size(282, 55);
            pboxCosto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCosto.TabIndex = 41;
            pboxCosto.TabStop = false;
            // 
            // pboxPrecio
            // 
            pboxPrecio.Image = Properties.Resources.ProductoNuevo5;
            pboxPrecio.Location = new Point(610, 180);
            pboxPrecio.Margin = new Padding(3, 4, 3, 4);
            pboxPrecio.Name = "pboxPrecio";
            pboxPrecio.Size = new Size(301, 55);
            pboxPrecio.SizeMode = PictureBoxSizeMode.Zoom;
            pboxPrecio.TabIndex = 42;
            pboxPrecio.TabStop = false;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 396);
            Controls.Add(pboxAgregarPr);
            Controls.Add(pboxCancelar);
            Controls.Add(pboxAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCosto);
            Controls.Add(txtUnidad);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigoProducto);
            Controls.Add(pboxCodigoProducto);
            Controls.Add(pboxNombreProducto);
            Controls.Add(pboxCantidad);
            Controls.Add(pboxUnidad);
            Controls.Add(pboxCosto);
            Controls.Add(pboxPrecio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCodigoProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarPr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNombreProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxUnidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCodigoProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCantidad;
        private TextBox txtUnidad;
        private TextBox txtCosto;
        private TextBox txtPrecio;
        private PictureBox pboxAceptar;
        private PictureBox pboxCancelar;
        private PictureBox pboxCodigoProducto;
        private PictureBox pboxAgregarPr;
        private PictureBox pboxNombreProducto;
        private PictureBox pboxCantidad;
        private PictureBox pboxUnidad;
        private PictureBox pboxCosto;
        private PictureBox pboxPrecio;
    }
}