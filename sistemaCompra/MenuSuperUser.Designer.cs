namespace sistemaCompra
{
    partial class MenuSuperUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSuperUser));
            pictureBox3 = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            pboxAvatarSuperUser = new PictureBox();
            pboxSuperUser = new PictureBox();
            pboxReseteoDatos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = Properties.Resources.InterfazSuperUsuario3;
            pictureBox3.Location = new Point(67, 231);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.Admin3;
            pboxCtrlUsuarios.Location = new Point(106, 305);
            pboxCtrlUsuarios.Margin = new Padding(3, 2, 3, 2);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(183, 31);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 19;
            pboxCtrlUsuarios.TabStop = false;
            pboxCtrlUsuarios.Click += pboxCtrlUsuarios_Click_1;
            // 
            // pboxAvatarSuperUser
            // 
            pboxAvatarSuperUser.AccessibleRole = AccessibleRole.None;
            pboxAvatarSuperUser.Image = Properties.Resources.InterfazSuperUsuario2;
            pboxAvatarSuperUser.ImeMode = ImeMode.NoControl;
            pboxAvatarSuperUser.Location = new Point(116, 48);
            pboxAvatarSuperUser.Name = "pboxAvatarSuperUser";
            pboxAvatarSuperUser.Size = new Size(110, 121);
            pboxAvatarSuperUser.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAvatarSuperUser.TabIndex = 20;
            pboxAvatarSuperUser.TabStop = false;
            // 
            // pboxSuperUser
            // 
            pboxSuperUser.Image = Properties.Resources.InterfazSuperUsuario1;
            pboxSuperUser.Location = new Point(59, 12);
            pboxSuperUser.Name = "pboxSuperUser";
            pboxSuperUser.Size = new Size(220, 30);
            pboxSuperUser.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSuperUser.TabIndex = 52;
            pboxSuperUser.TabStop = false;
            // 
            // pboxReseteoDatos
            // 
            pboxReseteoDatos.ErrorImage = (Image)resources.GetObject("pboxReseteoDatos.ErrorImage");
            pboxReseteoDatos.Image = (Image)resources.GetObject("pboxReseteoDatos.Image");
            pboxReseteoDatos.Location = new Point(67, 183);
            pboxReseteoDatos.Margin = new Padding(3, 2, 3, 2);
            pboxReseteoDatos.Name = "pboxReseteoDatos";
            pboxReseteoDatos.Size = new Size(212, 32);
            pboxReseteoDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReseteoDatos.TabIndex = 53;
            pboxReseteoDatos.TabStop = false;
            // 
            // MenuSuperUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(353, 356);
            Controls.Add(pboxReseteoDatos);
            Controls.Add(pboxSuperUser);
            Controls.Add(pboxAvatarSuperUser);
            Controls.Add(pboxCtrlUsuarios);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSuperUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuSuperUser";
            FormClosing += MenuSuperUser_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxAvatarSuperUser;
        private PictureBox pboxSuperUser;
        private PictureBox pboxReseteoDatos;
    }
}