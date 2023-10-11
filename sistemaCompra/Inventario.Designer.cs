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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dtgvProductos = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmUnidad = new DataGridViewTextBoxColumn();
            clmCosto = new DataGridViewTextBoxColumn();
            clmPrecio = new DataGridViewTextBoxColumn();
            pboxInvent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
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
            // dtgvProductos
            // 
            dtgvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(90, 180, 0);
            dataGridViewCellStyle1.Font = new Font("OCR A Extended", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 180, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmNombre, clmCantidad, clmUnidad, clmCosto, clmPrecio });
            dtgvProductos.EnableHeadersVisualStyles = false;
            dtgvProductos.GridColor = Color.FromArgb(168, 223, 0);
            dtgvProductos.Location = new Point(31, 181);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.ReadOnly = true;
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.RowTemplate.Height = 25;
            dtgvProductos.Size = new Size(692, 96);
            dtgvProductos.TabIndex = 3;
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
            pboxInvent.Location = new Point(257, 12);
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
            ClientSize = new Size(743, 338);
            Controls.Add(pboxInvent);
            Controls.Add(dtgvProductos);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxInvent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dtgvProductos;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmUnidad;
        private DataGridViewTextBoxColumn clmCosto;
        private DataGridViewTextBoxColumn clmPrecio;
        private PictureBox pboxInvent;
    }
}