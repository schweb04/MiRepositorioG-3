namespace sistemaCompra
{
    partial class AgregarUsuario
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
            txtPassword = new TextBox();
            pboxAceptar = new PictureBox();
            pboxAgregarUsuarios = new PictureBox();
            pboxNombreUsuario = new PictureBox();
            txtNombreUsuario = new TextBox();
            pboxNewPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNombreUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNewPassword).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 318);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 40;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar;
            pboxAceptar.Location = new Point(158, 400);
            pboxAceptar.Margin = new Padding(3, 4, 3, 4);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(122, 32);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 41;
            pboxAceptar.TabStop = false;
            // 
            // pboxAgregarUsuarios
            // 
            pboxAgregarUsuarios.Image = Properties.Resources.Usuario2;
            pboxAgregarUsuarios.Location = new Point(47, 66);
            pboxAgregarUsuarios.Margin = new Padding(3, 4, 3, 4);
            pboxAgregarUsuarios.Name = "pboxAgregarUsuarios";
            pboxAgregarUsuarios.Size = new Size(312, 45);
            pboxAgregarUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarUsuarios.TabIndex = 46;
            pboxAgregarUsuarios.TabStop = false;
            // 
            // pboxNombreUsuario
            // 
            pboxNombreUsuario.Image = Properties.Resources.Usuario1;
            pboxNombreUsuario.ImeMode = ImeMode.NoControl;
            pboxNombreUsuario.Location = new Point(129, 150);
            pboxNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            pboxNombreUsuario.Name = "pboxNombreUsuario";
            pboxNombreUsuario.Size = new Size(175, 104);
            pboxNombreUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNombreUsuario.TabIndex = 47;
            pboxNombreUsuario.TabStop = false;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(129, 209);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(175, 27);
            txtNombreUsuario.TabIndex = 38;
            // 
            // pboxNewPassword
            // 
            pboxNewPassword.Image = Properties.Resources.InterfazNuevo31;
            pboxNewPassword.ImeMode = ImeMode.NoControl;
            pboxNewPassword.Location = new Point(129, 262);
            pboxNewPassword.Margin = new Padding(3, 4, 3, 4);
            pboxNewPassword.Name = "pboxNewPassword";
            pboxNewPassword.Size = new Size(175, 104);
            pboxNewPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNewPassword.TabIndex = 43;
            pboxNewPassword.TabStop = false;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 507);
            Controls.Add(pboxAgregarUsuarios);
            Controls.Add(pboxAceptar);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(pboxNewPassword);
            Controls.Add(pboxNombreUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNombreUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNewPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label lblTipoUsuario;
        private PictureBox pboxAceptar;
        private PictureBox pboxAgregarUsuarios;
        private PictureBox pboxNombreUsuario;
        private TextBox txtNombreUsuario;
        private PictureBox pboxNewPassword;
    }
}