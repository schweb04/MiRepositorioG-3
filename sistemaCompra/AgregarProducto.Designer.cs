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
            txtCodigoProducto = new TextBox();
            pictureBox5 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            txtCodigoProducto.Location = new Point(95, 74);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(151, 23);
            txtCodigoProducto.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(772, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(330, 74);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(172, 23);
            txtNombreProducto.TabIndex = 22;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(106, 135);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(140, 23);
            txtCantidad.TabIndex = 24;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(242, 194);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(139, 23);
            txtUnidad.TabIndex = 26;
            txtUnidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(389, 135);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(125, 23);
            txtCosto.TabIndex = 28;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(673, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(123, 23);
            txtPrecio.TabIndex = 31;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar;
            pboxAceptar.Location = new Point(573, 246);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(107, 39);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 34;
            pboxAceptar.TabStop = false;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar;
            pboxCancelar.Location = new Point(686, 246);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(110, 39);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 35;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxCodigoProducto
            // 
            pboxCodigoProducto.Image = Properties.Resources.Agregar2;
            pboxCodigoProducto.Location = new Point(25, 74);
            pboxCodigoProducto.Name = "pboxCodigoProducto";
            pboxCodigoProducto.Size = new Size(221, 45);
            pboxCodigoProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCodigoProducto.TabIndex = 36;
            pboxCodigoProducto.TabStop = false;
            // 
            // pboxAgregarPr
            // 
            pboxAgregarPr.Image = Properties.Resources.Agregar1;
            pboxAgregarPr.Location = new Point(253, 11);
            pboxAgregarPr.Name = "pboxAgregarPr";
            pboxAgregarPr.Size = new Size(294, 46);
            pboxAgregarPr.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarPr.TabIndex = 37;
            pboxAgregarPr.TabStop = false;
            // 
            // pboxNombreProducto
            // 
            pboxNombreProducto.Image = Properties.Resources.Agregar3;
            pboxNombreProducto.Location = new Point(267, 74);
            pboxNombreProducto.Name = "pboxNombreProducto";
            pboxNombreProducto.Size = new Size(235, 45);
            pboxNombreProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNombreProducto.TabIndex = 38;
            pboxNombreProducto.TabStop = false;
            // 
            // pboxCantidad
            // 
            pboxCantidad.Image = Properties.Resources.Agregar4;
            pboxCantidad.Location = new Point(25, 135);
            pboxCantidad.Name = "pboxCantidad";
            pboxCantidad.Size = new Size(221, 45);
            pboxCantidad.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCantidad.TabIndex = 39;
            pboxCantidad.TabStop = false;
            // 
            // pboxUnidad
            // 
            pboxUnidad.Image = Properties.Resources.Agregar5;
            pboxUnidad.Location = new Point(145, 194);
            pboxUnidad.Name = "pboxUnidad";
            pboxUnidad.Size = new Size(236, 43);
            pboxUnidad.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUnidad.TabIndex = 40;
            pboxUnidad.TabStop = false;
            // 
            // pboxCosto
            // 
            pboxCosto.Image = Properties.Resources.Agregar6;
            pboxCosto.Location = new Point(267, 135);
            pboxCosto.Name = "pboxCosto";
            pboxCosto.Size = new Size(247, 41);
            pboxCosto.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCosto.TabIndex = 41;
            pboxCosto.TabStop = false;
            // 
            // pboxPrecio
            // 
            pboxPrecio.Image = Properties.Resources.Agregar7;
            pboxPrecio.Location = new Point(534, 135);
            pboxPrecio.Name = "pboxPrecio";
            pboxPrecio.Size = new Size(262, 41);
            pboxPrecio.SizeMode = PictureBoxSizeMode.Zoom;
            pboxPrecio.TabIndex = 42;
            pboxPrecio.TabStop = false;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 297);
            Controls.Add(pboxAgregarPr);
            Controls.Add(pboxCancelar);
            Controls.Add(pboxAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCosto);
            Controls.Add(txtUnidad);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreProducto);
            Controls.Add(pictureBox5);
            Controls.Add(txtCodigoProducto);
            Controls.Add(pboxCodigoProducto);
            Controls.Add(pboxNombreProducto);
            Controls.Add(pboxCantidad);
            Controls.Add(pboxUnidad);
            Controls.Add(pboxCosto);
            Controls.Add(pboxPrecio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox5;
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