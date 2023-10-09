namespace sistemaCompra
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            pictureBox5 = new PictureBox();
            lblAgregarCliente = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            txtCodigoCliente = new TextBox();
            lblCodigoCliente = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblIdentificación = new Label();
            txtIdentificacion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(713, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblAgregarCliente
            // 
            lblAgregarCliente.AutoSize = true;
            lblAgregarCliente.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarCliente.ForeColor = Color.Black;
            lblAgregarCliente.Location = new Point(256, 11);
            lblAgregarCliente.Name = "lblAgregarCliente";
            lblAgregarCliente.Size = new Size(221, 38);
            lblAgregarCliente.TabIndex = 30;
            lblAgregarCliente.Text = "Agregar Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(662, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(581, 239);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 46;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(396, 153);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 64);
            txtDireccion.TabIndex = 45;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(333, 156);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 44;
            lblDireccion.Text = "Dirección";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(148, 194);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(165, 23);
            txtCorreo.TabIndex = 41;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(32, 197);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 40;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(90, 156);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(101, 23);
            txtTelefono.TabIndex = 39;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(32, 159);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 38;
            lblTelefono.Text = "Teléfono";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(79, 103);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(126, 23);
            txtNombreCliente.TabIndex = 37;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(22, 103);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(51, 15);
            lblNombreCliente.TabIndex = 36;
            lblNombreCliente.Text = "Nombre";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(105, 62);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(100, 23);
            txtCodigoCliente.TabIndex = 35;
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(50, 62);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(49, 15);
            lblCodigoCliente.TabIndex = 34;
            lblCodigoCliente.Text = "Código ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(236, 103);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 48;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(293, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 23);
            txtApellido.TabIndex = 49;
            // 
            // lblIdentificación
            // 
            lblIdentificación.AutoSize = true;
            lblIdentificación.Location = new Point(448, 103);
            lblIdentificación.Name = "lblIdentificación";
            lblIdentificación.Size = new Size(139, 15);
            lblIdentificación.TabIndex = 50;
            lblIdentificación.Text = "Documento de Identidad";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(593, 103);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(128, 23);
            txtIdentificacion.TabIndex = 51;
            // 
            // AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 274);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblIdentificación);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtCodigoCliente);
            Controls.Add(lblCodigoCliente);
            Controls.Add(lblAgregarCliente);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarCliente";
            Text = "AgregarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label lblAgregarCliente;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private TextBox txtCodigoCliente;
        private Label lblCodigoCliente;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblIdentificación;
        private TextBox txtIdentificacion;
    }
}