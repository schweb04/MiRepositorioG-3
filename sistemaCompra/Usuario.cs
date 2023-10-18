using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    public class Usuario
    {
        private string? nombre;
        private string? clave;
        private char tipoDeUsuario = 'C'; // S = Superusuario | A = Administrador | C = Cajero

        public string? Nombre {  get { return nombre; } set {  nombre = value; } }
        public string? Clave { get {  return clave; } set {  clave = value; } }
        public char TipoDeUsuario { get {  return tipoDeUsuario; } set {  tipoDeUsuario = value; } }

        public Usuario(string? _nombre, string? _clave, char _tipoDeUsuario = 'C')
        {
            Nombre = _nombre;
            Clave = _clave;
            TipoDeUsuario = _tipoDeUsuario;
            Nombre = _nombre;
            Clave = _clave;
            TipoDeUsuario = _tipoDeUsuario;
        }
    }
}
