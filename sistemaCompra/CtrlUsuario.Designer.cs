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
            pboxEliminar = new PictureBox();
            pboxEditar = new PictureBox();
            pnlDesplegar = new Panel();
            pboxAceptarEditar = new PictureBox();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            lblNombre = new Label();
            lblPassword = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptarAgregar = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxDatos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            pboxLista = new PictureBox();
            dtgvListaUsuarios = new DataGridView();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(160, 79);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(46, 51);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 62;
            pboxEliminar.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(90, 77);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(46, 51);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 61;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(txtNombre);
            pnlDesplegar.Controls.Add(txtPassword);
            pnlDesplegar.Controls.Add(lblNombre);
            pnlDesplegar.Controls.Add(lblPassword);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Controls.Add(pboxAceptarAgregar);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(249, 79);
            pnlDesplegar.Margin = new Padding(3, 4, 3, 4);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(425, 332);
            pnlDesplegar.TabIndex = 60;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(86, 259);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(115, 36);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 70;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 173);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(165, 27);
            txtPassword.TabIndex = 58;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(183, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.Location = new Point(165, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 17);
            lblPassword.TabIndex = 56;
            lblPassword.Text = "Contraseña";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(225, 259);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(114, 36);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            // 
            // pboxAceptarAgregar
            // 
            pboxAceptarAgregar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarAgregar.Location = new Point(86, 259);
            pboxAceptarAgregar.Name = "pboxAceptarAgregar";
            pboxAceptarAgregar.Size = new Size(112, 36);
            pboxAceptarAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarAgregar.TabIndex = 56;
            pboxAceptarAgregar.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(134, 89);
            pboxBarra2.Margin = new Padding(3, 4, 3, 4);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(152, 40);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(127, 197);
            pboxBarra.Margin = new Padding(3, 4, 3, 4);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(166, 40);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(7, 5);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(414, 317);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(24, 77);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(46, 51);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 59;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.ControlUsuarios;
            pboxCtrlUsuarios.Location = new Point(150, 15);
            pboxCtrlUsuarios.Margin = new Padding(3, 4, 3, 4);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(338, 40);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 58;
            pboxCtrlUsuarios.TabStop = false;
            // 
            // pboxLista
            // 
            pboxLista.Image = Properties.Resources.ControlTabla123;
            pboxLista.Location = new Point(14, 140);
            pboxLista.Margin = new Padding(3, 4, 3, 4);
            pboxLista.Name = "pboxLista";
            pboxLista.Size = new Size(199, 271);
            pboxLista.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLista.TabIndex = 63;
            pboxLista.TabStop = false;
            pboxLista.Click += pboxLista_Click;
            // 
            // dtgvListaUsuarios
            // 
            dtgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { ColumnUsuario, ColumnTipo });
            dtgvListaUsuarios.Location = new Point(34, 211);
            dtgvListaUsuarios.Margin = new Padding(3, 4, 3, 4);
            dtgvListaUsuarios.Name = "dtgvListaUsuarios";
            dtgvListaUsuarios.RowHeadersWidth = 51;
            dtgvListaUsuarios.RowTemplate.Height = 25;
            dtgvListaUsuarios.Size = new Size(161, 179);
            dtgvListaUsuarios.TabIndex = 65;
            dtgvListaUsuarios.CellContentClick += dtgvListaUsuarios_CellContentClick;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.Width = 125;
            // 
            // ColumnTipo
            // 
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.MinimumWidth = 6;
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.Width = 125;
            // 
            // CtrlUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 424);
            Controls.Add(dtgvListaUsuarios);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlUsuarios);
            Controls.Add(pboxLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CtrlUsuario";
            Text = "CtrlUsuario";
            Load += CtrlUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pboxEliminar;
        private PictureBox pboxEditar;
        private Panel pnlDesplegar;
        private PictureBox pboxAceptarEditar;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Label lblNombre;
        private Label lblPassword;
        private PictureBox pboxCancelar;
        private PictureBox pboxAceptarAgregar;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra;
        private PictureBox pboxDatos;
        private PictureBox pboxAgregar;
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxLista;
        private DataGridView dtgvListaUsuarios;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private DataGridViewTextBoxColumn ColumnTipo;
    }
}