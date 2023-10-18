using System.Drawing.Text;
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
        public static List<Usuario> usuarios = new List<Usuario>();
        public Login()
        {
            InitializeComponent();
            CargarDatos();
        }

        public static void CargarDatos()
        {
            //Crea variables para asignarle los datos del archivo
            String? linea;
            String?[] valoresSeparadosPorComas;
            //Especifica la ruta y el nombre del archivo a consultar
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "usuarios.csv";
            string fullPath = Path.Combine(path, fileName);
            //Verifica si el archivo existe, ya que puede no ser el caso en la primera ejecución, por ejemplo
            if (File.Exists(fullPath))
            {
                //Inicializa una clase StreamReader
                StreamReader sr = new StreamReader(fullPath);
                //Asigna a "linea" la primera linea de texto del archivo
                linea = sr.ReadLine();
                //Inicializa un "loop" para leer el archivo hasta el final
                while (linea != null)
                {
                    //Asigna a "valorSeparadPorComas" la string en "linea" y la separa según vaya encontrando ";"
                    valoresSeparadosPorComas = linea.Split(';');
                    //Añade a la lista "usuarios" los datos almacenados en "valorseparadoporcomas" 
                    usuarios.Add(new(valoresSeparadosPorComas[0], valoresSeparadosPorComas[1], Convert.ToChar(valoresSeparadosPorComas[2])));
                    linea = sr.ReadLine();
                }
                //Cierra el archivo
                sr.Close();
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
            foreach(Usuario usuario in usuarios)
            {
                if (cajaUsuario.Text.ToLower() == usuario.Nombre && cajaClave.Text == usuario.Clave && usuario.TipoDeUsuario == 'S')
                {
                    this.Hide();
                    MenuSuperUser? menuSuperUser = new MenuSuperUser();
                    menuSuperUser.ShowDialog();
                    menuSuperUser = null;
                    this.Show();
                    clearCajas();
                    break;
                }

                else if (cajaUsuario.Text.ToLower() == usuario.Nombre && cajaClave.Text == usuario.Clave && usuario.TipoDeUsuario == 'A')
                {
                    this.Hide();
                    MenuAdministrador? menuAdmin = new MenuAdministrador();
                    menuAdmin.ShowDialog();
                    menuAdmin = null;
                    this.Show();
                    clearCajas();
                    break;
                }

                else if (cajaUsuario.Text.ToLower() == usuario.Nombre && cajaClave.Text == usuario.Clave && usuario.TipoDeUsuario == 'C')
                {
                    this.Hide();
                    Ventas? menuCajero = new Ventas();
                    menuCajero.ShowDialog();
                    menuCajero = null;
                    this.Show();
                    clearCajas();
                    break;
                }

                else if(usuario == usuarios[usuarios.Count - 1])
                {
                    MessageBox.Show("Nombre de usuario o clave incorrectos");
                }
            }
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

        private void pboxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
