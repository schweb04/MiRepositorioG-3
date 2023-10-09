using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Productos: Auxiliares
    {
        private double Cantidad;
        private string UnidadDeMedida = ""; //Kilogramos, paquetes, etc
        private double CostoUnitario;
        private double PrecioDeVenta;
    }
}
