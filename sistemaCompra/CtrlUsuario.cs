using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCompra
{
    public partial class CtrlUsuario : Form
    {
        public CtrlUsuario()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "usuarios.csv";
            string fullPath = Path.Combine(path, fileName);
            if (File.Exists(fullPath))
            {
                LlenarDataGridView();
            }
        }

        private void CtrlUsuario_Load(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }
        private void LlenarDataGridView()
        {
            foreach (Usuario usuario in Login.usuarios)
            {
                string?[] datos = new string[2];
                datos[0] = usuario.Nombre;
                if (usuario.TipoDeUsuario == 'C')
                {
                    datos[1] = "Cajero";
                }
                else if (usuario.TipoDeUsuario == 'A')
                {
                    datos[1] = "Administrador";
                }
                else if (usuario.TipoDeUsuario == 'S')
                {
                    datos[1] = "SuperUsuario";
                }
                dtgvListaUsuarios.Rows.Add(datos);
            }
        }
        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
            pboxAceptarEditar.Visible = false;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
            pboxAceptarAgregar.Visible = false;
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }

        private void pboxAceptarEditar_Click(object sender, EventArgs e)
        {
            /*//Inicializa un nuevo usuario para agregarlo al archivo, asignándole los valores escritos en las cajas de texto
            Usuario usuarioAAgregar = new(Convert.ToString(txtNombre.Text), Convert.ToString(txtPassword.Text));
            //Especifica la dirección dónde guardar el archivo
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "usuarios.csv";
            string fullPath = Path.Combine(path, fileName);
            //Formatea los datos en forma de valores separados por coma (CSV)
            String linea = String.Format("{0}; {1}; {2}", usuarioAAgregar.Nombre, usuarioAAgregar.Clave, usuarioAAgregar.TipoDeUsuario);
            //Inicializa la clase StreamWriter en el archivo y ruta indicados, especificando debe de anexar la información nueva y no
            //sobreescribir la anterior
            StreamWriter sW = new StreamWriter(fullPath, true, Encoding.ASCII);
            //Escribe los datos ya formateados al archivo
            sW.WriteLine(linea);
            //Cierra el archivo
            sW.Close();*/
            MessageBox.Show("Usuario Agregado");
        }

        private void dtgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pboxLista_Click(object sender, EventArgs e)
        {


        }
    }
}
