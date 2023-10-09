using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        this.Hide();
        login.Show();
    }

    private void MenuCajero_Load(object sender, EventArgs e)
    {

    }

    private void bienvenido_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void pboxAgregarProducto_Click(object sender, EventArgs e)
    {
        AgregarProducto agregarProducto = new AgregarProducto();
        agregarProducto.ShowDialog();
    }
}
