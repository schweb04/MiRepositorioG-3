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
            pictureBox5 = new PictureBox();
            lblAgregarUsuario = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtPassword = new TextBox();
            pboxCancelar = new PictureBox();
            pboxAceptar = new PictureBox();
            pboxNewPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNewPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.BotonCerrar;
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(308, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblAgregarUsuario
            // 
            lblAgregarUsuario.AutoSize = true;
            lblAgregarUsuario.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarUsuario.ForeColor = Color.Black;
            lblAgregarUsuario.Location = new Point(57, 9);
            lblAgregarUsuario.Name = "lblAgregarUsuario";
            lblAgregarUsuario.Size = new Size(228, 38);
            lblAgregarUsuario.TabIndex = 31;
            lblAgregarUsuario.Text = "Agregar Usuario";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(24, 90);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 15);
            lblNombreUsuario.TabIndex = 37;
            lblNombreUsuario.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(81, 86);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(126, 23);
            txtNombreUsuario.TabIndex = 38;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 40;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar;
            pboxCancelar.Location = new Point(239, 248);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(110, 39);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 42;
            pboxCancelar.TabStop = false;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar;
            pboxAceptar.Location = new Point(126, 248);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(107, 39);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 41;
            pboxAceptar.TabStop = false;
            // 
            // pboxNewPassword
            // 
            pboxNewPassword.Image = Properties.Resources.Interfaz3;
            pboxNewPassword.ImeMode = ImeMode.NoControl;
            pboxNewPassword.Location = new Point(62, 151);
            pboxNewPassword.Name = "pboxNewPassword";
            pboxNewPassword.Size = new Size(223, 78);
            pboxNewPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pboxNewPassword.TabIndex = 43;
            pboxNewPassword.TabStop = false;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 299);
            Controls.Add(pboxCancelar);
            Controls.Add(pboxAceptar);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblAgregarUsuario);
            Controls.Add(pictureBox5);
            Controls.Add(pboxNewPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNewPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label lblAgregarUsuario;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtPassword;
        private Label lblTipoUsuario;
        private PictureBox pboxCancelar;
        private PictureBox pboxAceptar;
        private PictureBox pboxNewPassword;
    }
}