using System.Windows.Forms.VisualStyles;

namespace sistemaCompra
{
    public partial class Login : Form
    {

        /*
         * Ya se controló la excepción del nombre de usuario, no importa si ingresa el nombre
         * en minúsculas, mayúsculas o combinadas
         * 
         * Se necesita controlar la excepción de espacios, los espacios son inválidos tanto en el
         * nombre de usuario como en la contraseña
         * 
         * Se necesita controlar la excepción del tamaño del nombre de usuario y contraseña,
         * no pueden ser ni tan cortos ni tan largos, 
         * Nombre de usuario: mínimo 6 caracteres, máximo 10 caracteres
         * Contraseña: mínimo 8 caracteres, máximo 12 caracteres
         * 
         * el usuario jose01 es superusuario, clave j1234567
         * el usuario pedro02 es administrador, clave p1234567
         * el usuario luis03 es cajero, clave l1234567
         */

        public Login()
        {
            InitializeComponent();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarPass.Checked)
            {
                cajaClave.UseSystemPasswordChar = false;
            }
            else
            {
                cajaClave.UseSystemPasswordChar = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (cajaUsuario.TextLength < 6 || cajaUsuario.TextLength > 10)
            {
                MessageBox.Show("El nombre de usuario debe estar comprendido entre 6 y 10 caracteres");
                

            }

            if (cajaClave.TextLength < 8 || cajaClave.TextLength > 12)
            {
                MessageBox.Show("La clave debe estar comprendida entre 8 y 12 caracteres");
              

            }

            else
            {
                verificarUsuario();
            }


        }

        private void verificarUsuario()
        {
            if (cajaUsuario.Text.ToLower() == "jose01" && cajaClave.Text == "j1234567")
            {
                ShowMenuSuperUser();
            }

            else if (cajaUsuario.Text.ToLower() == "pedro02" && cajaClave.Text == "p1234567")
            {
                this.Hide();
                MenuAdministrador menuAdmin = new MenuAdministrador();
                menuAdmin.ShowDialog();
                menuAdmin = null;
                this.Show();
                clearCajas();
            }

            else if (cajaUsuario.Text.ToLower() == "luis03" && cajaClave.Text == "l1234567")
            {
                this.Hide();
                Ventas ventas = new Ventas();
                ventas.ShowDialog();
                ventas = null;
                this.Show();
                clearCajas();
            }

            else
            {
                MessageBox.Show("Usuario o clave incorrecto");
                
            }
        }

        private void ShowMenuSuperUser()
        {
            this.Hide();
            MenuSuperUser menuSuperUser = new MenuSuperUser();
            menuSuperUser.ShowDialog();
            menuSuperUser = null;
            this.Show();
            clearCajas();
        }

        private void clearCajas()
        {
            cajaClave.Clear();
            cajaUsuario.Clear();
        }

        private void cajaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (cajaUsuario.Text.Contains(" "))
            {
                MessageBox.Show("El nombre de usuario no debe tener espacios");
                cajaUsuario.Clear();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
