namespace sistemaCompra
{
    partial class CtrlProducto
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
            pboxVolver = new PictureBox();
            pboxCtrlProductos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            SuspendLayout();
            // 
            // pboxVolver
            // 
            pboxVolver.Image = Properties.Resources.BotonSalirMenu;
            pboxVolver.Location = new Point(12, 238);
            pboxVolver.Margin = new Padding(3, 2, 3, 2);
            pboxVolver.Name = "pboxVolver";
            pboxVolver.Size = new Size(167, 28);
            pboxVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pboxVolver.TabIndex = 50;
            pboxVolver.TabStop = false;
            pboxVolver.Click += pboxVolver_Click;
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.ControlProductos11;
            pboxCtrlProductos.Location = new Point(38, 12);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(296, 30);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 51;
            pboxCtrlProductos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlProducto41;
            pboxAgregar.Location = new Point(94, 67);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(183, 43);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 52;
            pboxAgregar.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.ControlProducto31;
            pboxEditar.Location = new Point(94, 126);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(183, 38);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 53;
            pboxEditar.TabStop = false;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlProducto21;
            pboxEliminar.Location = new Point(94, 179);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(183, 38);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 54;
            pboxEliminar.TabStop = false;
            // 
            // CtrlProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 277);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlProducto";
            Text = "CtrlProducto";
            ((System.ComponentModel.ISupportInitialize)pboxVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxVolver;
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxAgregar;
        private PictureBox pboxEditar;
        private PictureBox pboxEliminar;
    }
}