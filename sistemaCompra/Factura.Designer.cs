﻿namespace sistemaCompra
{
    partial class Factura
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantid = new DataGridViewTextBoxColumn();
            TOTAL = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 84);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 117);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 151);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 43);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Cliente";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 27);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 221);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 298);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 11;
            label7.Text = "Producto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(112, 344);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 347);
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
            label9.Location = new Point(243, 344);
            label9.Name = "label9";
            label9.Size = new Size(26, 28);
            label9.TabIndex = 14;
            label9.Text = "+";
            label9.Click += label9_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(112, 382);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(32, 27);
            textBox7.TabIndex = 16;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(37, 385);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(69, 20);
            Cantidad.TabIndex = 15;
            Cantidad.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, Cantid });
            dataGridView1.Location = new Point(327, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(428, 61);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Cantid
            // 
            Cantid.HeaderText = "Cantidad";
            Cantid.MinimumWidth = 6;
            Cantid.Name = "Cantid";
            Cantid.Width = 125;
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Location = new Point(327, 332);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(76, 20);
            TOTAL.TabIndex = 18;
            TOTAL.Text = "SUBTOTAL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(327, 368);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 19;
            label11.Text = "IVA 16%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(327, 402);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 20;
            label12.Text = "TOTAL";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 444);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(TOTAL);
            Controls.Add(dataGridView1);
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
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantid;
        private Label TOTAL;
        private Label label11;
        private Label label12;
    }
}