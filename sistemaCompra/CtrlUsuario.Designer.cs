namespace sistemaCompra
{
    partial class CtrlUsuario
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
            pboxCtrlUsuarios = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            pboxVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxVolver).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.ControlUsuario1;
            pboxCtrlUsuarios.Location = new Point(61, 20);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(296, 30);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 45;
            pboxCtrlUsuarios.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlUsuario2;
            pboxAgregar.Location = new Point(124, 76);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(183, 40);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 46;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.ControlUsuario3;
            pboxEditar.Location = new Point(124, 132);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(183, 40);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 47;
            pboxEditar.TabStop = false;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlUsuario4;
            pboxEliminar.Location = new Point(124, 188);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(183, 38);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 48;
            pboxEliminar.TabStop = false;
            // 
            // pboxVolver
            // 
            pboxVolver.Image = Properties.Resources.BotonSalirMenu;
            pboxVolver.Location = new Point(12, 253);
            pboxVolver.Margin = new Padding(3, 2, 3, 2);
            pboxVolver.Name = "pboxVolver";
            pboxVolver.Size = new Size(171, 28);
            pboxVolver.SizeMode = PictureBoxSizeMode.Zoom;
            pboxVolver.TabIndex = 49;
            pboxVolver.TabStop = false;
            pboxVolver.Click += pboxVolver_Click;
            // 
            // CtrlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 292);
            Controls.Add(pboxVolver);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlUsuario";
            Text = "CtrlUsuario";
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxVolver).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxAgregar;
        private PictureBox pboxEditar;
        private PictureBox pboxEliminar;
        private PictureBox pboxVolver;
    }
}