namespace sistemaCompra
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label user;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usuario = new PictureBox();
            pictureBox2 = new PictureBox();
            kword = new Label();
            cajaUsuario = new TextBox();
            cajaClave = new TextBox();
            mostrarPass = new CheckBox();
            invalido = new Label();
            ingresar = new PictureBox();
            pictureBox3 = new PictureBox();
            user = new Label();
            ((System.ComponentModel.ISupportInitialize)usuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // user
            // 
            resources.ApplyResources(user, "user");
            user.Name = "user";
            // 
            // usuario
            // 
            usuario.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(usuario, "usuario");
            usuario.Name = "usuario";
            usuario.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // kword
            // 
            resources.ApplyResources(kword, "kword");
            kword.Name = "kword";
            kword.Click += label2_Click;
            // 
            // cajaUsuario
            // 
            resources.ApplyResources(cajaUsuario, "cajaUsuario");
            cajaUsuario.Name = "cajaUsuario";
            cajaUsuario.TextChanged += cajaUsuario_TextChanged;
            // 
            // cajaClave
            // 
            cajaClave.BackColor = SystemColors.HighlightText;
            resources.ApplyResources(cajaClave, "cajaClave");
            cajaClave.Name = "cajaClave";
            cajaClave.UseSystemPasswordChar = true;
            // 
            // mostrarPass
            // 
            resources.ApplyResources(mostrarPass, "mostrarPass");
            mostrarPass.Name = "mostrarPass";
            mostrarPass.UseVisualStyleBackColor = true;
            mostrarPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // invalido
            // 
            resources.ApplyResources(invalido, "invalido");
            invalido.ForeColor = Color.Red;
            invalido.Name = "invalido";
            invalido.Click += invalido_Click;
            // 
            // ingresar
            // 
            resources.ApplyResources(ingresar, "ingresar");
            ingresar.Name = "ingresar";
            ingresar.TabStop = false;
            ingresar.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(pictureBox3);
            Controls.Add(ingresar);
            Controls.Add(invalido);
            Controls.Add(mostrarPass);
            Controls.Add(cajaClave);
            Controls.Add(cajaUsuario);
            Controls.Add(kword);
            Controls.Add(user);
            Controls.Add(pictureBox2);
            Controls.Add(usuario);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)usuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox usuario;
        private PictureBox pictureBox2;
        private Label user;
        private Label kword;
        private TextBox cajaUsuario;
        private TextBox cajaClave;
        private CheckBox mostrarPass;
        private Label invalido;
        private PictureBox ingresar;
        private PictureBox pictureBox3;
    }
}