using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Cliente: Auxiliares
    {
        private string Apellido = "";
        private int Telefono; //Formato: 0000-0000000
        private string Correo = "";
        public bool TipoDeDocumento; //0 = Cédula de Identidad. 1 = RIF
        private int NumeroDeDocumento;
        private string TipoDeImpuesto = ""; //Exento, 16% o Retenciones
        public string Direccion = "";
    }
}
