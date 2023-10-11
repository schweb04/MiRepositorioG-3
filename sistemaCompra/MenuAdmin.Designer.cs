namespace sistemaCompra
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            pboxAdmin = new PictureBox();
            pboxAvatarAdmin = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(209, 486);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(224, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(220, 431);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.BotonCerrarSesion;
            pictureBox6.Location = new Point(12, 550);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(209, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.Admin3;
            pboxCtrlUsuarios.Location = new Point(213, 246);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(209, 57);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 18;
            pboxCtrlUsuarios.TabStop = false;
            pboxCtrlUsuarios.Click += pboxCtrlUsuarios_Click;
            // 
            // pboxAdmin
            // 
            pboxAdmin.Image = (Image)resources.GetObject("pboxAdmin.Image");
            pboxAdmin.Location = new Point(172, 13);
            pboxAdmin.Margin = new Padding(3, 4, 3, 4);
            pboxAdmin.Name = "pboxAdmin";
            pboxAdmin.Size = new Size(291, 47);
            pboxAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAdmin.TabIndex = 25;
            pboxAdmin.TabStop = false;
            // 
            // pboxAvatarAdmin
            // 
            pboxAvatarAdmin.Image = Properties.Resources.Admin2;
            pboxAvatarAdmin.Location = new Point(247, 68);
            pboxAvatarAdmin.Margin = new Padding(3, 4, 3, 4);
            pboxAvatarAdmin.Name = "pboxAvatarAdmin";
            pboxAvatarAdmin.Size = new Size(137, 175);
            pboxAvatarAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAvatarAdmin.TabIndex = 26;
            pboxAvatarAdmin.TabStop = false;
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.Admin4;
            pboxCtrlProductos.Location = new Point(212, 310);
            pboxCtrlProductos.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(210, 53);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 27;
            pboxCtrlProductos.TabStop = false;
            pboxCtrlProductos.Click += pboxCtrlProductos_Click;
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.Admin5;
            pboxCtrlClientes.Location = new Point(213, 371);
            pboxCtrlClientes.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(210, 53);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 28;
            pboxCtrlClientes.TabStop = false;
            pboxCtrlClientes.Click += pboxCtrlClientes_Click_1;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 628);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxAvatarAdmin);
            Controls.Add(pboxAdmin);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pboxCtrlUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu ADMIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxAdmin;
        private PictureBox pboxAvatarAdmin;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxCtrlClientes;
    }
}