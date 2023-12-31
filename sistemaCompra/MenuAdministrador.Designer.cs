﻿namespace sistemaCompra
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
            importarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            exportarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            importarProductosToolStripMenuItem = new ToolStripMenuItem();
            exportarProductosToolStripMenuItem = new ToolStripMenuItem();
            importarClientesToolStripMenuItem = new ToolStripMenuItem();
            exportarClientesToolStripMenuItem = new ToolStripMenuItem();
            tasaDelDólarToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            mnuMenuAdministrador.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenuAdministrador
            // 
            mnuMenuAdministrador.BackColor = Color.FromArgb(189, 195, 199);
            mnuMenuAdministrador.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, productosToolStripMenuItem, clientesToolStripMenuItem, tasaDelDólarToolStripMenuItem, acercaDeToolStripMenuItem });
            mnuMenuAdministrador.Location = new Point(0, 0);
            mnuMenuAdministrador.Name = "mnuMenuAdministrador";
            mnuMenuAdministrador.Size = new Size(683, 24);
            mnuMenuAdministrador.TabIndex = 0;
            mnuMenuAdministrador.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(189, 195, 199);
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeUsuariosToolStripMenuItem, importarUsuariosToolStripMenuItem, exportarUsuariosToolStripMenuItem });
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
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeProductosToolStripMenuItem, importarProductosToolStripMenuItem, exportarProductosToolStripMenuItem });
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
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeClientesToolStripMenuItem, importarClientesToolStripMenuItem, exportarClientesToolStripMenuItem });
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
            // importarUsuariosToolStripMenuItem
            // 
            importarUsuariosToolStripMenuItem.Image = Properties.Resources.IconoExportar;
            importarUsuariosToolStripMenuItem.Name = "importarUsuariosToolStripMenuItem";
            importarUsuariosToolStripMenuItem.Size = new Size(207, 22);
            importarUsuariosToolStripMenuItem.Text = "Importar Usuarios";
            // 
            // exportarUsuariosToolStripMenuItem
            // 
            exportarUsuariosToolStripMenuItem.Image = Properties.Resources.IconoImportar;
            exportarUsuariosToolStripMenuItem.Name = "exportarUsuariosToolStripMenuItem";
            exportarUsuariosToolStripMenuItem.Size = new Size(207, 22);
            exportarUsuariosToolStripMenuItem.Text = "Exportar Usuarios";
            // 
            // importarProductosToolStripMenuItem
            // 
            importarProductosToolStripMenuItem.Image = Properties.Resources.IconoExportar1;
            importarProductosToolStripMenuItem.Name = "importarProductosToolStripMenuItem";
            importarProductosToolStripMenuItem.Size = new Size(214, 22);
            importarProductosToolStripMenuItem.Text = "Importar Productos";
            // 
            // exportarProductosToolStripMenuItem
            // 
            exportarProductosToolStripMenuItem.Image = Properties.Resources.IconoImportar;
            exportarProductosToolStripMenuItem.Name = "exportarProductosToolStripMenuItem";
            exportarProductosToolStripMenuItem.Size = new Size(214, 22);
            exportarProductosToolStripMenuItem.Text = "Exportar Productos";
            // 
            // importarClientesToolStripMenuItem
            // 
            importarClientesToolStripMenuItem.Image = Properties.Resources.IconoExportar;
            importarClientesToolStripMenuItem.Name = "importarClientesToolStripMenuItem";
            importarClientesToolStripMenuItem.Size = new Size(207, 22);
            importarClientesToolStripMenuItem.Text = "Importar Clientes";
            // 
            // exportarClientesToolStripMenuItem
            // 
            exportarClientesToolStripMenuItem.Image = Properties.Resources.IconoImportar;
            exportarClientesToolStripMenuItem.Name = "exportarClientesToolStripMenuItem";
            exportarClientesToolStripMenuItem.Size = new Size(207, 22);
            exportarClientesToolStripMenuItem.Text = "Exportar Clientes";
            // 
            // tasaDelDólarToolStripMenuItem
            // 
            tasaDelDólarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox2 });
            tasaDelDólarToolStripMenuItem.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            tasaDelDólarToolStripMenuItem.Name = "tasaDelDólarToolStripMenuItem";
            tasaDelDólarToolStripMenuItem.Size = new Size(117, 20);
            tasaDelDólarToolStripMenuItem.Text = "Tasa del dólar";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
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
        private ToolStripMenuItem importarUsuariosToolStripMenuItem;
        private ToolStripMenuItem exportarUsuariosToolStripMenuItem;
        private ToolStripMenuItem importarProductosToolStripMenuItem;
        private ToolStripMenuItem exportarProductosToolStripMenuItem;
        private ToolStripMenuItem importarClientesToolStripMenuItem;
        private ToolStripMenuItem exportarClientesToolStripMenuItem;
        private ToolStripMenuItem tasaDelDólarToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox2;
    }
}