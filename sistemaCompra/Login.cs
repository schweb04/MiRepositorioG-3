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
         * el usuario jose es superusuario, clave j1234
         * el usuario pedro es administrador, clave p1234
         * el usuario luis es cajero, clave l1234
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
                cajaClave.Clear();
                cajaUsuario.Clear();
            }

            if (cajaClave.TextLength < 8 || cajaClave.TextLength > 12)
            {
                MessageBox.Show("La clave debe estar comprendida entre 8 y 12 caracteres");
                cajaClave.Clear();
                cajaUsuario.Clear();
               
            }

            if (cajaUsuario.Text.ToLower() == "jose" && cajaClave.Text == "j1234")
            {
                MenuSuperUser menuSuperUser = new MenuSuperUser();
                menuSuperUser.Show();
                this.Hide();
            }

            else if (cajaUsuario.Text.ToLower() == "pedro" && cajaClave.Text == "p1234")
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Hide();
            }

            else if (cajaUsuario.Text.ToLower() == "luis" && cajaClave.Text == "l1234")
            {
                MenuCajero menuCajero = new MenuCajero();
                menuCajero.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o clave incorrecto");
                cajaClave.Clear();
                cajaUsuario.Clear();
            }

        }

        private void cajaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (cajaUsuario.Text.Contains(" "))
            {
                MessageBox.Show("El nombre de usuario no debe tener espacios");
                cajaUsuario.Clear();
            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void invalido_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cajaClave_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
