using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Productos: Auxiliares
    {
        private double cantidad;
        private string unidadDeMedida = ""; //Kilogramos, paquetes, etc
        private double costoUnitario;
        private double precioDeVenta;   

        public double Cantidad {  get { return cantidad; } set { cantidad = value; } }
        public string UnidadDeMedida { get {  return unidadDeMedida; } set {  unidadDeMedida = value; } }
        public double CostoUnitario { get {  return costoUnitario; } set {  costoUnitario = value; } }
        public double PrecioDeVenta {  get { return precioDeVenta; } set {  precioDeVenta = value; } }

        public Productos(double _cantidad, string _unidadDeMedida, double _costoUnitario, double _precioDeVenta)
        {
            Cantidad = _cantidad;
            UnidadDeMedida = _unidadDeMedida;
            CostoUnitario = _costoUnitario;
            PrecioDeVenta = _precioDeVenta;
        }
    }
}
