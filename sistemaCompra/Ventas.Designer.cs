﻿namespace sistemaCompra
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
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
            clmPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvProductosSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 63);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 113);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 141);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 61);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 86);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 111);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 136);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 32);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Cliente";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 160);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 23);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 166);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 224);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 11;
            label7.Text = "Producto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(98, 258);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 260);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 12;
            label8.Text = "Codigo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 192, 0);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(213, 258);
            label9.Name = "label9";
            label9.Size = new Size(21, 21);
            label9.TabIndex = 14;
            label9.Text = "+";
            label9.Click += label9_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(98, 286);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(28, 23);
            textBox7.TabIndex = 16;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(32, 289);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(55, 15);
            Cantidad.TabIndex = 15;
            Cantidad.Text = "Cantidad";
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Location = new Point(286, 249);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(59, 15);
            TOTAL.TabIndex = 18;
            TOTAL.Text = "SUBTOTAL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(286, 276);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 19;
            label11.Text = "IVA 16%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(286, 302);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 20;
            label12.Text = "TOTAL";
            // 
            // button1
            // 
            button1.Location = new Point(397, 287);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 21;
            button1.Text = "Generar Factura";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtgvProductosSeleccionados
            // 
            dtgvProductosSeleccionados.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(90, 180, 0);
            dataGridViewCellStyle2.Font = new Font("OCR A Extended", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 180, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvProductosSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clmNombre, clmCantidad, clmUnidad, clmCosto, clmPrecio });
            dtgvProductosSeleccionados.EnableHeadersVisualStyles = false;
            dtgvProductosSeleccionados.GridColor = Color.FromArgb(168, 223, 0);
            dtgvProductosSeleccionados.Location = new Point(370, 63);
            dtgvProductosSeleccionados.Name = "dtgvProductosSeleccionados";
            dtgvProductosSeleccionados.ReadOnly = true;
            dtgvProductosSeleccionados.RowHeadersWidth = 51;
            dtgvProductosSeleccionados.RowTemplate.Height = 25;
            dtgvProductosSeleccionados.Size = new Size(418, 96);
            dtgvProductosSeleccionados.TabIndex = 22;
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
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 333);
            Controls.Add(dtgvProductosSeleccionados);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(TOTAL);
            Controls.Add(textBox7);
            Controls.Add(Cantidad);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dtgvProductosSeleccionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
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
        private DataGridViewTextBoxColumn clmPrecio;
    }
}