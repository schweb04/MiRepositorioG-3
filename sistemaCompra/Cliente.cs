using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Cliente: Auxiliares
    {
        private string Apellido = "";
        private int Telefono; //Formato: 0000-0000000
        private string Correo = "";
        public char TipoDeDocumento = 'd'; //d = Valor por defecto, V = Venezolano, E = Extranjero, J = Judicial
        private int NumeroDeDocumento;
        private string TipoDeImpuesto = ""; //Exento, 16% o Retenciones
        private string Direccion = "";
        private bool ContibuyenteEspecial;
    }
}
