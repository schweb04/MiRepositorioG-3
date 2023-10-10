namespace sistemaCompra
{
    partial class CtrlCliente
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
            pictureBox4 = new PictureBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            pictureBox5 = new PictureBox();
            btnAgregar = new Button();
            lblCtrlClientes = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.BotonMinimizar;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(318, 12);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(127, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(127, 122);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.BotonCerrar;
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(355, 9);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(127, 74);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCtrlClientes
            // 
            lblCtrlClientes.AutoSize = true;
            lblCtrlClientes.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCtrlClientes.ForeColor = Color.Black;
            lblCtrlClientes.Location = new Point(12, 9);
            lblCtrlClientes.Name = "lblCtrlClientes";
            lblCtrlClientes.Size = new Size(267, 38);
            lblCtrlClientes.TabIndex = 24;
            lblCtrlClientes.Text = "Control de Clientes";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 230);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // CtrlCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 273);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox4);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(pictureBox5);
            Controls.Add(btnAgregar);
            Controls.Add(lblCtrlClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CtrlCliente";
            Text = "CtrlCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Button btnEliminar;
        private Button btnEditar;
        private PictureBox pictureBox5;
        private Button btnAgregar;
        private Label lblCtrlClientes;
        private Button btnVolver;
    }
}