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
            pboxCtrlUsuarios = new PictureBox();
            pboxAdmin = new PictureBox();
            pboxAvatarAdmin = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.Admin3;
            pboxCtrlUsuarios.Location = new Point(76, 257);
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
            pboxAdmin.Location = new Point(34, 25);
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
            pboxAvatarAdmin.Location = new Point(110, 80);
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
            pboxCtrlProductos.Location = new Point(76, 321);
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
            pboxCtrlClientes.Location = new Point(76, 383);
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
            ClientSize = new Size(373, 485);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxAvatarAdmin);
            Controls.Add(pboxAdmin);
            Controls.Add(pboxCtrlUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdmin";
            FormClosing += MenuAdmin_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxAdmin;
        private PictureBox pboxAvatarAdmin;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxCtrlClientes;
    }
}