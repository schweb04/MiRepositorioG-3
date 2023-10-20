using System.Windows.Forms.VisualStyles;

namespace sistemaCompra
{
    public partial class Login : Form
    {
        private List<Usuario> usuarios;

        /*
         * el usuario jose01 es superusuario, clave j1234
         * el usuario pedro02 es administrador, clave p1234
         * el usuario luis03 es cajero, clave l1234
         * si quieren registrar otro usuario, modifiquen el csv
         */

        public Login()
        {
            InitializeComponent();

            usuarios = new List<Usuario>();
            string pathUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");
            string[] lineasUsuarios = File.ReadAllLines(pathUsuarios);

            foreach (string linea in lineasUsuarios.Skip(1))
            {
                string[] valores = linea.Split(',');

                Usuario usuario = new Usuario();
                usuario.Username = valores[0];
                usuario.Password = valores[1];
                usuario.TipoDeUsuario = valores[2];
                usuarios.Add(usuario);

            }
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

            if (cajaUsuario.TextLength < 4)
            {
                MessageBox.Show("El nombre de usuario debe tener mas de 4 caracteres");


            }

            if (cajaClave.TextLength < 4)
            {
                MessageBox.Show("La clave debe tener mas de 4 caracteres");
            }

            else
            {
                verificarUsuario();
            }


        }

        private void verificarUsuario()
        {

            string username = cajaUsuario.Text;
            string password = cajaClave.Text;

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Username == username && usuario.Password == password)
                {
                    switch (usuario.TipoDeUsuario)
                    {
                        case "Superuser":
                            ShowMenuSuperUser();
                            break;

                        case "Admin":
                            ShowMenuAdmin();
                            break;

                        case "Cajero":
                            ShowVentas();
                            break;

                    }
                    break;
                }
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

        private void ShowVentas()
        {
            this.Hide();
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
            ventas = null;
            this.Show();
            clearCajas();
        }

        private void ShowMenuAdmin()
        {
            this.Hide();
            MenuAdministrador menuAdmin = new MenuAdministrador();
            menuAdmin.ShowDialog();
            menuAdmin = null;
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

        private void cajaClave_TextChanged(object sender, EventArgs e)
        {
            if (cajaClave.Text.Contains(" "))
            {
                MessageBox.Show("La clave no debe tener espacios");
                cajaClave.Clear();
            }
        }
    }
}
