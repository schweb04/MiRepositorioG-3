namespace sistemaCompra
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            pictureBox1 = new PictureBox();
            lblCompras = new Label();
            pboxAgregarCliente = new PictureBox();
            dtgvTablaProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvTablaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 292);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 37);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompras.ForeColor = Color.Black;
            lblCompras.Location = new Point(288, 9);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(134, 38);
            lblCompras.TabIndex = 30;
            lblCompras.Text = "Compras";
            // 
            // pboxAgregarCliente
            // 
            pboxAgregarCliente.Image = Properties.Resources.Sin_título1;
            pboxAgregarCliente.Location = new Point(200, 44);
            pboxAgregarCliente.Name = "pboxAgregarCliente";
            pboxAgregarCliente.Size = new Size(38, 36);
            pboxAgregarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarCliente.TabIndex = 31;
            pboxAgregarCliente.TabStop = false;
            pboxAgregarCliente.Click += pboxAgregarCliente_Click;
            // 
            // dtgvTablaProductos
            // 
            dtgvTablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTablaProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dtgvTablaProductos.Location = new Point(26, 95);
            dtgvTablaProductos.Name = "dtgvTablaProductos";
            dtgvTablaProductos.ReadOnly = true;
            dtgvTablaProductos.RowTemplate.Height = 25;
            dtgvTablaProductos.Size = new Size(648, 150);
            dtgvTablaProductos.TabIndex = 32;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ud. de Medida";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Costo Unitario";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio de Venta";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(664, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox5);
            Controls.Add(dtgvTablaProductos);
            Controls.Add(pboxAgregarCliente);
            Controls.Add(lblCompras);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvTablaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblCompras;
        private PictureBox pboxAgregarCliente;
        private DataGridView dtgvTablaProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pictureBox5;
    }
}