namespace Ventas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Venta venta = new Venta();
            venta.AgregarProducto(cantidad: 2,descripcion: "Doritos",precioUnitario: 21.50m);
            venta.AgregarProducto(cantidad: 2,descripcion: "cocacola",precioUnitario: 18);
            venta.AgregarProducto(cantidad: 3,descripcion: "Mexicanos con limon",precioUnitario: 50);
          
            venta.ImprimirConceptos();


        }
    }
}
