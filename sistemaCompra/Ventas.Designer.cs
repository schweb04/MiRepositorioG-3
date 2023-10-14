namespace sistemaCompra
{
    partial class Ventas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cedulaTB = new TextBox();
            nombreTB = new TextBox();
            emailTB = new TextBox();
            direccionTB = new TextBox();
            label5 = new Label();
            telefonoTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            codigoTB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cantidadTB = new TextBox();
            Cantidad = new Label();
            TOTAL = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            dtgvProductosSeleccionados = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmUnidad = new DataGridViewTextBoxColumn();
            clmCosto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 48);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 51);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 93);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // cedulaTB
            // 
            cedulaTB.Location = new Point(252, 43);
            cedulaTB.Name = "cedulaTB";
            cedulaTB.Size = new Size(125, 27);
            cedulaTB.TabIndex = 4;
            // 
            // nombreTB
            // 
            nombreTB.Location = new Point(484, 46);
            nombreTB.Name = "nombreTB";
            nombreTB.Size = new Size(125, 27);
            nombreTB.TabIndex = 5;
            nombreTB.TextChanged += textBox2_TextChanged;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(733, 48);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(246, 27);
            emailTB.TabIndex = 6;
            // 
            // direccionTB
            // 
            direccionTB.Location = new Point(252, 86);
            direccionTB.Name = "direccionTB";
            direccionTB.Size = new Size(180, 27);
            direccionTB.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 46);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Cliente";
            label5.Click += label5_Click;
            // 
            // telefonoTB
            // 
            telefonoTB.Location = new Point(545, 86);
            telefonoTB.Name = "telefonoTB";
            telefonoTB.Size = new Size(180, 27);
            telefonoTB.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 94);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(80, 140);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 11;
            label7.Text = "Producto";
            // 
            // codigoTB
            // 
            codigoTB.Location = new Point(236, 140);
            codigoTB.Name = "codigoTB";
            codigoTB.Size = new Size(125, 27);
            codigoTB.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(172, 143);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 12;
            label8.Text = "Codigo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 192, 0);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(367, 140);
            label9.Name = "label9";
            label9.Size = new Size(26, 28);
            label9.TabIndex = 14;
            label9.Text = "+";
            label9.Click += label9_Click;
            // 
            // cantidadTB
            // 
            cantidadTB.Location = new Point(236, 177);
            cantidadTB.Name = "cantidadTB";
            cantidadTB.Size = new Size(31, 27);
            cantidadTB.TabIndex = 16;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(161, 181);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(69, 20);
            Cantidad.TabIndex = 15;
            Cantidad.Text = "Cantidad";
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Location = new Point(80, 231);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(76, 20);
            TOTAL.TabIndex = 18;
            TOTAL.Text = "SUBTOTAL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 267);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 19;
            label11.Text = "IVA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(80, 302);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 20;
            label12.Text = "TOTAL";
            // 
            // button1
            // 
            button1.Location = new Point(80, 375);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 31);
            button1.TabIndex = 21;
            button1.Text = "Generar Factura";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtgvProductosSeleccionados
            // 
            dtgvProductosSeleccionados.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Navy;
            dataGridViewCellStyle3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 180, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvProductosSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmNombre, clmCantidad, clmUnidad, clmCosto });
            dtgvProductosSeleccionados.EnableHeadersVisualStyles = false;
            dtgvProductosSeleccionados.GridColor = Color.FromArgb(0, 0, 64);
            dtgvProductosSeleccionados.Location = new Point(406, 140);
            dtgvProductosSeleccionados.Margin = new Padding(3, 4, 3, 4);
            dtgvProductosSeleccionados.Name = "dtgvProductosSeleccionados";
            dtgvProductosSeleccionados.ReadOnly = true;
            dtgvProductosSeleccionados.RowHeadersWidth = 51;
            dtgvProductosSeleccionados.RowTemplate.Height = 25;
            dtgvProductosSeleccionados.Size = new Size(633, 327);
            dtgvProductosSeleccionados.TabIndex = 22;
            dtgvProductosSeleccionados.CellContentClick += dtgvProductosSeleccionados_CellContentClick;
            // 
            // clmCodigo
            // 
            clmCodigo.HeaderText = "Código";
            clmCodigo.MinimumWidth = 6;
            clmCodigo.Name = "clmCodigo";
            clmCodigo.ReadOnly = true;
            clmCodigo.Width = 80;
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
            clmUnidad.HeaderText = "Costo Unitario";
            clmUnidad.MinimumWidth = 6;
            clmUnidad.Name = "clmUnidad";
            clmUnidad.ReadOnly = true;
            clmUnidad.Width = 125;
            // 
            // clmCosto
            // 
            clmCosto.HeaderText = "Costo Total";
            clmCosto.MinimumWidth = 6;
            clmCosto.Name = "clmCosto";
            clmCosto.ReadOnly = true;
            clmCosto.Width = 125;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 517);
            Controls.Add(dtgvProductosSeleccionados);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(TOTAL);
            Controls.Add(cantidadTB);
            Controls.Add(Cantidad);
            Controls.Add(label9);
            Controls.Add(codigoTB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(telefonoTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(direccionTB);
            Controls.Add(emailTB);
            Controls.Add(nombreTB);
            Controls.Add(cedulaTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductosSeleccionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cedulaTB;
        private TextBox nombreTB;
        private TextBox emailTB;
        private TextBox direccionTB;
        private Label label5;
        private TextBox telefonoTB;
        private Label label6;
        private Label label7;
        private TextBox codigoTB;
        private Label label8;
        private Label label9;
        private TextBox cantidadTB;
        private Label Cantidad;
        private Label TOTAL;
        private Label label11;
        private Label label12;
        private Button button1;
        private DataGridView dtgvProductosSeleccionados;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmUnidad;
        private DataGridViewTextBoxColumn clmCosto;
    }
}