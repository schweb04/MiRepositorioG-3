namespace sistemaCompra
{
    partial class Inventario
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dtgvProductosInventario = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmUnidad = new DataGridViewTextBoxColumn();
            clmCosto = new DataGridViewTextBoxColumn();
            clmPrecio = new DataGridViewTextBoxColumn();
            pboxInvent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxInvent).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BotonSalirMenu1;
            pictureBox1.Location = new Point(10, 292);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dtgvProductosInventario
            // 
            dtgvProductosInventario.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(90, 180, 0);
            dataGridViewCellStyle2.Font = new Font("OCR A Extended", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 180, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvProductosInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvProductosInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductosInventario.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmNombre, clmCantidad, clmUnidad, clmCosto, clmPrecio });
            dtgvProductosInventario.EnableHeadersVisualStyles = false;
            dtgvProductosInventario.GridColor = Color.FromArgb(168, 223, 0);
            dtgvProductosInventario.Location = new Point(12, 84);
            dtgvProductosInventario.Name = "dtgvProductosInventario";
            dtgvProductosInventario.ReadOnly = true;
            dtgvProductosInventario.RowHeadersWidth = 51;
            dtgvProductosInventario.RowTemplate.Height = 25;
            dtgvProductosInventario.Size = new Size(804, 96);
            dtgvProductosInventario.TabIndex = 3;
            // 
            // clmCodigo
            // 
            clmCodigo.HeaderText = "Código";
            clmCodigo.MinimumWidth = 6;
            clmCodigo.Name = "clmCodigo";
            clmCodigo.ReadOnly = true;
            clmCodigo.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmCantidad
            // 
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.MinimumWidth = 6;
            clmCantidad.Name = "clmCantidad";
            clmCantidad.ReadOnly = true;
            clmCantidad.Width = 125;
            // 
            // clmUnidad
            // 
            clmUnidad.HeaderText = "Ud. de Medida";
            clmUnidad.MinimumWidth = 6;
            clmUnidad.Name = "clmUnidad";
            clmUnidad.ReadOnly = true;
            clmUnidad.Width = 125;
            // 
            // clmCosto
            // 
            clmCosto.HeaderText = "Costo Unitario";
            clmCosto.MinimumWidth = 6;
            clmCosto.Name = "clmCosto";
            clmCosto.ReadOnly = true;
            clmCosto.Width = 125;
            // 
            // clmPrecio
            // 
            clmPrecio.HeaderText = "Precio de Venta";
            clmPrecio.MinimumWidth = 6;
            clmPrecio.Name = "clmPrecio";
            clmPrecio.ReadOnly = true;
            clmPrecio.Width = 125;
            // 
            // pboxInvent
            // 
            pboxInvent.Image = Properties.Resources.Invetario121;
            pboxInvent.Location = new Point(316, 12);
            pboxInvent.Name = "pboxInvent";
            pboxInvent.Size = new Size(240, 47);
            pboxInvent.SizeMode = PictureBoxSizeMode.Zoom;
            pboxInvent.TabIndex = 4;
            pboxInvent.TabStop = false;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 338);
            Controls.Add(pboxInvent);
            Controls.Add(dtgvProductosInventario);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxInvent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dtgvProductosInventario;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmUnidad;
        private DataGridViewTextBoxColumn clmCosto;
        private DataGridViewTextBoxColumn clmPrecio;
        private PictureBox pboxInvent;
    }
}