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
        private int telefono; //Formato: 0000-0000000
        private string correoElectronico = "";
        public char tipoDeDocumento = 'd'; //d = Valor por defecto, V = Venezolano, E = Extranjero, J = Judicial
        private int numeroDeDocumento;
        private string tipoDeImpuesto = ""; //Exento, 16% o Retenciones
        private string direccion = "";
        private bool contribuyenteEspecial;

        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Telefono { get; set; }
        public string CorreoElectronico { get {  return correoElectronico; } set {  correoElectronico = value; } }
        public char TipoDeDocumento { get { return tipoDeDocumento; } set { tipoDeDocumento = value; } }
        public int NumeroDeDocumento { get { return numeroDeDocumento; } set {  numeroDeDocumento = value; } }
        public string TipoDeImpuesto { get { return tipoDeImpuesto; } set { tipoDeImpuesto= value; } }  
        public string Direccion { get {  return direccion; } set {  direccion = value; } }
        public bool ContribuyenteEspecial { get {  return contribuyenteEspecial; } set {  contribuyenteEspecial = value; } }

        public Cliente(string _nombre ,string _apellido, int _telefono, string _correoElectronico, char _tipoDeDocumento, int _numeroDeDocumento, string _tipoDeImpuesto, string _direccion, bool _contribuyenteEspecial)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            CorreoElectronico = _correoElectronico;
            TipoDeDocumento = _tipoDeDocumento;
            NumeroDeDocumento = _numeroDeDocumento;
            TipoDeImpuesto = _tipoDeImpuesto;
            Direccion = _direccion;
            ContribuyenteEspecial = _contribuyenteEspecial;
        }
    }
}
