using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Producto: Auxiliares
    {
        private double cantidad;
        private string unidadDeMedida = ""; //Kilogramos, paquetes, etc
        private double costoUnitario;
        private double precioDeVenta;
        private bool iva;

        public double Cantidad {  get { return cantidad; } set { cantidad = value; } }
        public string UnidadDeMedida { get {  return unidadDeMedida; } set {  unidadDeMedida = value; } }
        public double CostoUnitario { get {  return costoUnitario; } set {  costoUnitario = value; } }
        public double PrecioDeVenta {  get { return precioDeVenta; } set {  precioDeVenta = value; } }
        public bool IVA { get { return iva; } set { iva = value; } }

        public Producto(double _cantidad, string _unidadDeMedida, double _costoUnitario, double _precioDeVenta, bool _iva)
        {
            Cantidad = _cantidad;
            UnidadDeMedida = _unidadDeMedida;
            CostoUnitario = _costoUnitario;
            PrecioDeVenta = _precioDeVenta;
            IVA = _iva;
        }
    }
}
