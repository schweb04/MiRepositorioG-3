using System.Runtime.Serialization;

namespace sistemaCompra
{
    [Serializable]
    internal class passwordException : Exception
    {
        public passwordException()
        {
            MessageBox.Show("Invalido");
        }
    }
}