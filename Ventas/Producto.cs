namespace Ventas
{
    internal class Producto
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Importe 
        {
            get 
            { 
                return Cantidad * PrecioUnitario; 
            } 
        }

        public override string ToString()
        {
            return $"Cantidad: {Cantidad} {Descripcion} Precio:{PrecioUnitario} Importe:{Importe}";
        }
    }
}
