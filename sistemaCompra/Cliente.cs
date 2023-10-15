using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int telefono; //Formato: 0000-0000000
        private string correoElectronico = "";
        private int cedula;
        private string direccion = "";
        private char tipoDocumento;
        private bool contribuyenteEspecial;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public string CorreoElectronico { get { return correoElectronico; } set { correoElectronico = value; } }
        public int Cedula { get { return cedula; } set { cedula = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public char TipoDocumento { get { return tipoDocumento;  } set {tipoDocumento = value;} }
        public bool ContribuyenteEspecial { get { return contribuyenteEspecial; } set { contribuyenteEspecial = value; } }

        public Cliente()
        {
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            CorreoElectronico = "";
            Cedula = 0;
            Direccion = "";
            TipoDocumento = 'n';
            ContribuyenteEspecial = false;

        }

        public Cliente(string _nombre , string _apellido, int _telefono, string _correoElectronico, char _tipoDeDocumento, int _numeroDeDocumento, string _direccion, bool _contribuyenteEspecial)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            CorreoElectronico = _correoElectronico;
            Cedula = _numeroDeDocumento;
            Direccion = _direccion;
            TipoDocumento = _tipoDeDocumento;
            ContribuyenteEspecial = _contribuyenteEspecial;
        }
    }
}
