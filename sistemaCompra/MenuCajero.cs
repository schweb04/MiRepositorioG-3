using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace sistemaCompra;

public partial class MenuCajero : Form
{
    public MenuCajero()
    {
        InitializeComponent();
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
        Login login = new Login();
        login.Show();
        this.Hide();
    }

    private void MenuCajero_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        Inventario inventario = new Inventario();
        inventario.ShowDialog();
    }

    private void pboxCtrlClientes_Click(object sender, EventArgs e)
    {
        CtrlCliente ctrCliente = new CtrlCliente(OrigenMenu.Cajero);
        ctrCliente.Show();
        this.Hide();
    }

    private void pboxCtrlProductos_Click(object sender, EventArgs e)
    {
        //CtrlProducto ctrlProducto(OrigenMenu.Cajero);
        //ctrlProducto.Show();
        //this.Hide();
    }
}
