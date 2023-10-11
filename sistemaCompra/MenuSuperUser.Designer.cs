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
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pboxSuperUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUsuario).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.BotonCerrarSesion;
            pictureBox6.Location = new Point(12, 318);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(180, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(108, 164);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 40);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pboxSuperUsuario
            // 
            pboxSuperUsuario.Image = Properties.Resources.SuperUsuario11;
            pboxSuperUsuario.Location = new Point(108, 12);
            pboxSuperUsuario.Name = "pboxSuperUsuario";
            pboxSuperUsuario.Size = new Size(255, 35);
            pboxSuperUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSuperUsuario.TabIndex = 26;
            pboxSuperUsuario.TabStop = false;
            // 
            // MenuSuperUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(464, 356);
            Controls.Add(pboxSuperUsuario);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSuperUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuSuperUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pboxSuperUsuario;
    }
}