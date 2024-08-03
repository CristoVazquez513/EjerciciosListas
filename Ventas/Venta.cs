namespace Ventas
{
    internal class Venta
    {
        private List<Producto> _productos;
        public Venta()
        {
            _productos = new List<Producto>();
        }
        public decimal Total { get { return CalcularTotal(); } }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (Producto producto in _productos)
            {
                total += producto.Importe;
            }
            return total;
        }

        public void AgregarProducto(int cantidad, string descripcion, decimal precioUnitario)
        {
            Producto producto = new Producto();
            producto.Cantidad = cantidad;
            producto.Descripcion = descripcion;
            producto.PrecioUnitario = precioUnitario;

            _productos.Add(producto);
        }
        public void ImprimirConceptos() 
        {
            foreach (Producto producto in _productos) 
            {
                Console.WriteLine(producto.ToString());
            }
            Console.WriteLine($"Total de la venta: {Total}");
        }
    }
}
