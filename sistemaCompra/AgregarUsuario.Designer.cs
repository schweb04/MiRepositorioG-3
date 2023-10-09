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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            pictureBox5 = new PictureBox();
            lblAgregarUsuario = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(423, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblAgregarUsuario
            // 
            lblAgregarUsuario.AutoSize = true;
            lblAgregarUsuario.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarUsuario.ForeColor = Color.Black;
            lblAgregarUsuario.Location = new Point(119, 9);
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
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 134);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 39;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(97, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(126, 23);
            txtPassword.TabIndex = 40;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(372, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(291, 178);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 48;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 213);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblAgregarUsuario);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label lblAgregarUsuario;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblTipoUsuario;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}