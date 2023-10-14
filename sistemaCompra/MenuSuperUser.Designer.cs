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
            pboxReinicioUsuarios = new PictureBox();
            pboxAvatarSuperUser = new PictureBox();
            pboxSuperUser = new PictureBox();
            pboxReseteoDatos = new PictureBox();
            pboxReseteoFabrica = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxReinicioUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoFabrica).BeginInit();
            SuspendLayout();
            // 
            // pboxReinicioUsuarios
            // 
            pboxReinicioUsuarios.ErrorImage = (Image)resources.GetObject("pboxReinicioUsuarios.ErrorImage");
            pboxReinicioUsuarios.Image = Properties.Resources.InterfazSuperUsuario3;
            pboxReinicioUsuarios.Location = new Point(67, 231);
            pboxReinicioUsuarios.Margin = new Padding(3, 2, 3, 2);
            pboxReinicioUsuarios.Name = "pboxReinicioUsuarios";
            pboxReinicioUsuarios.Size = new Size(212, 32);
            pboxReinicioUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReinicioUsuarios.TabIndex = 14;
            pboxReinicioUsuarios.TabStop = false;
            pboxReinicioUsuarios.Click += pboxReinicioUsuarios_Click;
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
            // pboxReseteoFabrica
            // 
            pboxReseteoFabrica.ErrorImage = (Image)resources.GetObject("pboxReseteoFabrica.ErrorImage");
            pboxReseteoFabrica.Image = Properties.Resources.InterfazSuperUsuario5;
            pboxReseteoFabrica.Location = new Point(67, 279);
            pboxReseteoFabrica.Margin = new Padding(3, 2, 3, 2);
            pboxReseteoFabrica.Name = "pboxReseteoFabrica";
            pboxReseteoFabrica.Size = new Size(212, 32);
            pboxReseteoFabrica.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReseteoFabrica.TabIndex = 54;
            pboxReseteoFabrica.TabStop = false;
            // 
            // MenuSuperUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(353, 356);
            Controls.Add(pboxReseteoFabrica);
            Controls.Add(pboxReseteoDatos);
            Controls.Add(pboxSuperUser);
            Controls.Add(pboxAvatarSuperUser);
            Controls.Add(pboxReinicioUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSuperUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuSuperUser";
            FormClosing += MenuSuperUser_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pboxReinicioUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoFabrica).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxReinicioUsuarios;
        private PictureBox pboxAvatarSuperUser;
        private PictureBox pboxSuperUser;
        private PictureBox pboxReseteoDatos;
        private PictureBox pboxReseteoFabrica;
    }
}