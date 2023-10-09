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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarCliente).BeginInit();
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
            pboxAgregarCliente.Location = new Point(174, 101);
            pboxAgregarCliente.Name = "pboxAgregarCliente";
            pboxAgregarCliente.Size = new Size(38, 36);
            pboxAgregarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarCliente.TabIndex = 31;
            pboxAgregarCliente.TabStop = false;
            pboxAgregarCliente.Click += pboxAgregarCliente_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblCompras;
        private PictureBox pboxAgregarCliente;
    }
}