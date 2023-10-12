using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Auxiliares
    {
        private string codigo;
        private string nombre;
        private ushort tipoImpuesto;
        
        public string Codigo {  get { return codigo; } set { codigo = value; } }
        public string Nombre { get {  return nombre; } set {  nombre = value; } }
        public ushort TipoImpuesto { get {  return tipoImpuesto; } set {  tipoImpuesto = value; } }
    }
}
