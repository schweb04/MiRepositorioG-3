namespace sistemaCompra
{
    partial class MenuAdministrador
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
            mnuMenuAdministrador = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            controlDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            controlDeProductosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            controlDeClientesToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pnlMenuAdministrador = new Panel();
            toolStripTextBox1 = new ToolStripTextBox();
            mnuMenuAdministrador.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenuAdministrador
            // 
            mnuMenuAdministrador.BackColor = Color.FromArgb(189, 195, 199);
            mnuMenuAdministrador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, productosToolStripMenuItem, clientesToolStripMenuItem, acercaDeToolStripMenuItem });
            mnuMenuAdministrador.Location = new Point(0, 0);
            mnuMenuAdministrador.Name = "mnuMenuAdministrador";
            mnuMenuAdministrador.Size = new Size(683, 24);
            mnuMenuAdministrador.TabIndex = 0;
            mnuMenuAdministrador.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(189, 195, 199);
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            usuariosToolStripMenuItem.Image = Properties.Resources.IconoUsuario;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(91, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.ToolTipText = "Opciones de Usuario";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            controlDeUsuariosToolStripMenuItem.Image = Properties.Resources.IconoControlUsuario;
            controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            controlDeUsuariosToolStripMenuItem.Size = new Size(207, 22);
            controlDeUsuariosToolStripMenuItem.Text = "Control de Usuarios";
            controlDeUsuariosToolStripMenuItem.ToolTipText = "Ver lista de usuarios, agregar usuarios, editar usuarios, y eliminar usuarios ";
            controlDeUsuariosToolStripMenuItem.Click += controlDeUsuariosToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeProductosToolStripMenuItem });
            productosToolStripMenuItem.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            productosToolStripMenuItem.Image = Properties.Resources.IconoProducto;
            productosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(98, 20);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.ToolTipText = "Opciones de Producto";
            // 
            // controlDeProductosToolStripMenuItem
            // 
            controlDeProductosToolStripMenuItem.Image = Properties.Resources.IconoControlProducto;
            controlDeProductosToolStripMenuItem.Name = "controlDeProductosToolStripMenuItem";
            controlDeProductosToolStripMenuItem.Size = new Size(214, 22);
            controlDeProductosToolStripMenuItem.Text = "Control de Productos";
            controlDeProductosToolStripMenuItem.ToolTipText = "Ver lista de productos, agregar productos, editar productos, y eliminar productos ";
            controlDeProductosToolStripMenuItem.Click += controlDeProductosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeClientesToolStripMenuItem });
            clientesToolStripMenuItem.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            clientesToolStripMenuItem.Image = Properties.Resources.IconoCliente;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(91, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.ToolTipText = "Opciones de Cliente";
            // 
            // controlDeClientesToolStripMenuItem
            // 
            controlDeClientesToolStripMenuItem.Image = Properties.Resources.IconoControlCliente;
            controlDeClientesToolStripMenuItem.Name = "controlDeClientesToolStripMenuItem";
            controlDeClientesToolStripMenuItem.Size = new Size(207, 22);
            controlDeClientesToolStripMenuItem.Text = "Control de Clientes";
            controlDeClientesToolStripMenuItem.ToolTipText = "Ver lista de clientes, agregar clientes, editar clientes, y eliminar clientes ";
            controlDeClientesToolStripMenuItem.Click += controlDeClientesToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(103, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.ToolTipText = "Dale click para saber que se encuentra en esta ventana...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // pnlMenuAdministrador
            // 
            pnlMenuAdministrador.Dock = DockStyle.Fill;
            pnlMenuAdministrador.Location = new Point(0, 24);
            pnlMenuAdministrador.Name = "pnlMenuAdministrador";
            pnlMenuAdministrador.Size = new Size(683, 413);
            pnlMenuAdministrador.TabIndex = 1;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 437);
            Controls.Add(pnlMenuAdministrador);
            Controls.Add(mnuMenuAdministrador);
            Name = "MenuAdministrador";
            Text = "MenuAdministrador";
            mnuMenuAdministrador.ResumeLayout(false);
            mnuMenuAdministrador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenuAdministrador;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem controlDeProductosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem controlDeClientesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel pnlMenuAdministrador;
        private ToolStripTextBox toolStripTextBox1;
    }
}