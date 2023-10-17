using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Cliente: Auxiliares
    {
        private string apellido = "";
        private string telefono; //Formato: 0000-0000000
        private string correoElectronico = "";
        public char tipoDeDocumento = 'd'; //d = Valor por defecto, V = Venezolano, E = Extranjero, J = Judicial
        private int cedula;
        private string direccion = "";
        private bool contribuyenteEspecial;

        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string CorreoElectronico { get {  return correoElectronico; } set {  correoElectronico = value; } }
        public char TipoDeDocumento { get { return tipoDeDocumento; } set { tipoDeDocumento = value; } }
        public int Cedula { get { return cedula; } set {  cedula = value; } }  
        public string Direccion { get {  return direccion; } set {  direccion = value; } }
        public bool ContribuyenteEspecial { get {  return contribuyenteEspecial; } set {  contribuyenteEspecial = value; } }


        public Cliente()
        {
            Nombre = "";
            Apellido = "";
            Telefono = "";
            CorreoElectronico = "";
            Cedula = 0;
            Direccion = "";
            TipoDeDocumento = 'a';
            ContribuyenteEspecial = false;

        }

        public Cliente(string _nombre ,string _apellido, string _telefono, string _correoElectronico, char _tipoDeDocumento, int _cedula, string _direccion, bool _contribuyenteEspecial)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            CorreoElectronico = _correoElectronico;
            TipoDeDocumento = _tipoDeDocumento;
            Cedula = _cedula;
            Direccion = _direccion;
            ContribuyenteEspecial = _contribuyenteEspecial;
        }
    }
}
