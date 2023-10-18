namespace sistemaCompra
{
    partial class MenuSuperUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSuperUser));
            pboxReseteoUsuarios = new PictureBox();
            pboxAvatarSuperUsuario = new PictureBox();
            pboxSuperUsuario = new PictureBox();
            pboxReseteoDatos = new PictureBox();
            pboxReseteoFabrica = new PictureBox();
            pnlMostrarMensaje = new Panel();
            txtMensaje = new TextBox();
            pboxAceptar = new PictureBox();
            pboxCancelar = new PictureBox();
            pboxCajaMensaje = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoFabrica).BeginInit();
            pnlMostrarMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajaMensaje).BeginInit();
            SuspendLayout();
            // 
            // pboxReseteoUsuarios
            // 
            pboxReseteoUsuarios.ErrorImage = (Image)resources.GetObject("pboxReseteoUsuarios.ErrorImage");
            pboxReseteoUsuarios.Image = Properties.Resources.InterfazSuperUsuario3;
            pboxReseteoUsuarios.Location = new Point(12, 189);
            pboxReseteoUsuarios.Margin = new Padding(3, 2, 3, 2);
            pboxReseteoUsuarios.Name = "pboxReseteoUsuarios";
            pboxReseteoUsuarios.Size = new Size(195, 30);
            pboxReseteoUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReseteoUsuarios.TabIndex = 14;
            pboxReseteoUsuarios.TabStop = false;
            pboxReseteoUsuarios.Click += pboxReseteoUsuarios_Click;
            // 
            // pboxAvatarSuperUsuario
            // 
            pboxAvatarSuperUsuario.AccessibleRole = AccessibleRole.None;
            pboxAvatarSuperUsuario.Image = Properties.Resources.InterfazSuperUsuario2;
            pboxAvatarSuperUsuario.ImeMode = ImeMode.NoControl;
            pboxAvatarSuperUsuario.Location = new Point(65, 54);
            pboxAvatarSuperUsuario.Name = "pboxAvatarSuperUsuario";
            pboxAvatarSuperUsuario.Size = new Size(97, 118);
            pboxAvatarSuperUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAvatarSuperUsuario.TabIndex = 20;
            pboxAvatarSuperUsuario.TabStop = false;
            // 
            // pboxSuperUsuario
            // 
            pboxSuperUsuario.Image = Properties.Resources.InterfazSuperUsuario1;
            pboxSuperUsuario.Location = new Point(158, 12);
            pboxSuperUsuario.Name = "pboxSuperUsuario";
            pboxSuperUsuario.Size = new Size(236, 36);
            pboxSuperUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSuperUsuario.TabIndex = 21;
            pboxSuperUsuario.TabStop = false;
            // 
            // pboxReseteoDatos
            // 
            pboxReseteoDatos.ErrorImage = (Image)resources.GetObject("pboxReseteoDatos.ErrorImage");
            pboxReseteoDatos.Image = Properties.Resources.InterfazSuperUsuario4;
            pboxReseteoDatos.Location = new Point(12, 242);
            pboxReseteoDatos.Margin = new Padding(3, 2, 3, 2);
            pboxReseteoDatos.Name = "pboxReseteoDatos";
            pboxReseteoDatos.Size = new Size(195, 30);
            pboxReseteoDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReseteoDatos.TabIndex = 22;
            pboxReseteoDatos.TabStop = false;
            pboxReseteoDatos.Click += pboxReseteoDatos_Click;
            // 
            // pboxReseteoFabrica
            // 
            pboxReseteoFabrica.ErrorImage = (Image)resources.GetObject("pboxReseteoFabrica.ErrorImage");
            pboxReseteoFabrica.Image = Properties.Resources.InterfazSuperUsuario5;
            pboxReseteoFabrica.Location = new Point(12, 294);
            pboxReseteoFabrica.Margin = new Padding(3, 2, 3, 2);
            pboxReseteoFabrica.Name = "pboxReseteoFabrica";
            pboxReseteoFabrica.Size = new Size(195, 30);
            pboxReseteoFabrica.SizeMode = PictureBoxSizeMode.Zoom;
            pboxReseteoFabrica.TabIndex = 23;
            pboxReseteoFabrica.TabStop = false;
            pboxReseteoFabrica.Click += pboxReseteoFabrica_Click;
            // 
            // pnlMostrarMensaje
            // 
            pnlMostrarMensaje.Controls.Add(txtMensaje);
            pnlMostrarMensaje.Controls.Add(pboxAceptar);
            pnlMostrarMensaje.Controls.Add(pboxCancelar);
            pnlMostrarMensaje.Controls.Add(pboxCajaMensaje);
            pnlMostrarMensaje.Location = new Point(231, 99);
            pnlMostrarMensaje.Name = "pnlMostrarMensaje";
            pnlMostrarMensaje.Size = new Size(275, 173);
            pnlMostrarMensaje.TabIndex = 24;
            // 
            // txtMensaje
            // 
            txtMensaje.BorderStyle = BorderStyle.None;
            txtMensaje.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMensaje.Location = new Point(28, 38);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.ReadOnly = true;
            txtMensaje.Size = new Size(217, 71);
            txtMensaje.TabIndex = 25;
            // 
            // pboxAceptar
            // 
            pboxAceptar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptar.Location = new Point(28, 132);
            pboxAceptar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptar.Name = "pboxAceptar";
            pboxAceptar.Size = new Size(100, 27);
            pboxAceptar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptar.TabIndex = 65;
            pboxAceptar.TabStop = false;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(145, 132);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(100, 27);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 64;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxCajaMensaje
            // 
            pboxCajaMensaje.Image = Properties.Resources.ControlDesplegar;
            pboxCajaMensaje.Location = new Point(3, 2);
            pboxCajaMensaje.Margin = new Padding(3, 2, 3, 2);
            pboxCajaMensaje.Name = "pboxCajaMensaje";
            pboxCajaMensaje.Size = new Size(269, 169);
            pboxCajaMensaje.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCajaMensaje.TabIndex = 55;
            pboxCajaMensaje.TabStop = false;
            // 
            // MenuSuperUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(538, 335);
            Controls.Add(pnlMostrarMensaje);
            Controls.Add(pboxReseteoUsuarios);
            Controls.Add(pboxReseteoFabrica);
            Controls.Add(pboxReseteoDatos);
            Controls.Add(pboxSuperUsuario);
            Controls.Add(pboxAvatarSuperUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSuperUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuSuperUser";
            FormClosing += MenuSuperUser_FormClosing;
            Load += MenuSuperUser_Load;
            ((System.ComponentModel.ISupportInitialize)pboxReseteoUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAvatarSuperUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSuperUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxReseteoFabrica).EndInit();
            pnlMostrarMensaje.ResumeLayout(false);
            pnlMostrarMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCajaMensaje).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxReseteoUsuarios;
        private PictureBox pboxAvatarSuperUsuario;
        private PictureBox pboxSuperUsuario;
        private PictureBox pboxReseteoDatos;
        private PictureBox pboxReseteoFabrica;
        private Panel pnlMostrarMensaje;
        private PictureBox pboxCajaMensaje;
        private PictureBox pboxAceptar;
        private PictureBox pboxCancelar;
        private TextBox txtMensaje;
    }
}