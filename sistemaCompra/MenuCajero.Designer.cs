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
            pictureBox3 = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            pboxCajero = new PictureBox();
            pboxUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuario).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(178, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            pboxCajero.Location = new Point(0, 0);
            pboxCajero.Name = "pboxCajero";
            pboxCajero.Size = new Size(100, 50);
            pboxCajero.TabIndex = 0;
            pboxCajero.TabStop = false;
            // 
            // pboxUsuario
            // 
            pboxUsuario.Location = new Point(106, 16);
            pboxUsuario.Margin = new Padding(3, 4, 3, 4);
            pboxUsuario.Name = "pboxUsuario";
            pboxUsuario.Size = new Size(291, 47);
            pboxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUsuario.TabIndex = 27;
            pboxUsuario.TabStop = false;
            // 
            // MenuCajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 459);
            Controls.Add(pboxUsuario);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuCajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuCajero";
            FormClosing += MenuCajero_FormClosing;
            Load += MenuCajero_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxCtrlClientes;
        private PictureBox pboxCajero;
        private PictureBox pboxUsuario;
    }
}