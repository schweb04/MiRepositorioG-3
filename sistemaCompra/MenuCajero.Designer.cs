﻿namespace sistemaCompra
{
    partial class MenuCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCajero));
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            pboxCajero = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajero).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.BotonCerrarSesion;
            pictureBox6.Location = new Point(12, 396);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(180, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(178, 121);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // bienvenido
            // 
            bienvenido.AutoSize = true;
            bienvenido.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenido.ForeColor = Color.Black;
            bienvenido.Location = new Point(187, 15);
            bienvenido.Name = "bienvenido";
            bienvenido.Size = new Size(127, 47);
            bienvenido.TabIndex = 14;
            bienvenido.Text = "Cajero";
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.Admin4;
            pboxCtrlProductos.Location = new Point(142, 209);
            pboxCtrlProductos.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(210, 53);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 22;
            pboxCtrlProductos.TabStop = false;
            pboxCtrlProductos.Click += pboxCtrlProductos_Click;
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.Admin5;
            pboxCtrlClientes.Location = new Point(142, 271);
            pboxCtrlClientes.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(210, 53);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 23;
            pboxCtrlClientes.TabStop = false;
            pboxCtrlClientes.Click += pboxCtrlClientes_Click;
            // 
            // pboxCajero
            // 
            pboxCajero.Image = Properties.Resources.Cajero1;
            pboxCajero.Location = new Point(65, 12);
            pboxCajero.Name = "pboxCajero";
            pboxCajero.Size = new Size(255, 35);
            pboxCajero.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCajero.TabIndex = 26;
            pboxCajero.TabStop = false;
            // 
            // MenuCajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 458);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(bienvenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuCajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MenuCajero_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxCtrlClientes;
        private PictureBox pboxCajero;
    }
}