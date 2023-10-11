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
            pboxCtrlClientes = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            pboxVolver2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxVolver2).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.ControlClientes11;
            pboxCtrlClientes.Location = new Point(62, 21);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(296, 30);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 46;
            pboxCtrlClientes.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlCliente21;
            pboxAgregar.Location = new Point(117, 79);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(183, 40);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 47;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.ControlCliente31;
            pboxEditar.Location = new Point(117, 133);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(183, 40);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 48;
            pboxEditar.TabStop = false;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlCliente41;
            pboxEliminar.Location = new Point(117, 187);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(183, 38);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 49;
            pboxEliminar.TabStop = false;
            // 
            // pboxVolver2
            // 
            pboxVolver2.Image = Properties.Resources.BotonSalirMenu;
            pboxVolver2.Location = new Point(12, 246);
            pboxVolver2.Margin = new Padding(3, 2, 3, 2);
            pboxVolver2.Name = "pboxVolver2";
            pboxVolver2.Size = new Size(167, 28);
            pboxVolver2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxVolver2.TabIndex = 51;
            pboxVolver2.TabStop = false;
            pboxVolver2.Click += pboxVolver2_Click;
            // 
            // CtrlCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 285);
            Controls.Add(pboxVolver2);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlCliente";
            Text = "CtrlCliente";
            Load += CtrlCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxVolver2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlClientes;
        private PictureBox pboxAgregar;
        private PictureBox pboxEditar;
        private PictureBox pboxEliminar;
        private PictureBox pboxVolver2;
    }
}