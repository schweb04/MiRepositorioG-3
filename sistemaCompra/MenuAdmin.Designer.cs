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
            pictureBox6 = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            pboxAdmin = new PictureBox();
            pboxAvatarAdmin = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.BotonCerrarSesion;
            pictureBox6.Location = new Point(10, 337);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(183, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.Admin3;
            pboxCtrlUsuarios.Location = new Point(186, 184);
            pboxCtrlUsuarios.Margin = new Padding(3, 2, 3, 2);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(183, 43);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 18;
            pboxCtrlUsuarios.TabStop = false;
            pboxCtrlUsuarios.Click += pboxCtrlUsuarios_Click;
            // 
            // pboxAdmin
            // 
            pboxAdmin.Image = (Image)resources.GetObject("pboxAdmin.Image");
            pboxAdmin.Location = new Point(150, 10);
            pboxAdmin.Name = "pboxAdmin";
            pboxAdmin.Size = new Size(255, 35);
            pboxAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAdmin.TabIndex = 25;
            pboxAdmin.TabStop = false;
            // 
            // pboxAvatarAdmin
            // 
            pboxAvatarAdmin.Image = Properties.Resources.Admin2;
            pboxAvatarAdmin.Location = new Point(216, 51);
            pboxAvatarAdmin.Name = "pboxAvatarAdmin";
            pboxAvatarAdmin.Size = new Size(120, 131);
            pboxAvatarAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAvatarAdmin.TabIndex = 26;
            pboxAvatarAdmin.TabStop = false;
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.Admin4;
            pboxCtrlProductos.Location = new Point(186, 232);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(184, 40);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 27;
            pboxCtrlProductos.TabStop = false;
            pboxCtrlProductos.Click += pboxCtrlProductos_Click;
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.Admin5;
            pboxCtrlClientes.Location = new Point(186, 278);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(184, 40);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 28;
            pboxCtrlClientes.TabStop = false;
            pboxCtrlClientes.Click += pboxCtrlClientes_Click_1;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 394);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxAvatarAdmin);
            Controls.Add(pboxAdmin);
            Controls.Add(pictureBox6);
            Controls.Add(pboxCtrlUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdmin";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox6;
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxAdmin;
        private PictureBox pboxAvatarAdmin;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxCtrlClientes;
    }
}