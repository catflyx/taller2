namespace Taller2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Producto[] productosCarta = new Producto[16];

            productosCarta[0] = new Producto("Crema de champinones", 21000, 10);
            productosCarta[1] = new Producto("Patacon con carne", 24000, 10);
            productosCarta[2] = new Producto("Porcion de platanitos", 7000, 15);
            productosCarta[3] = new Producto("Lasana Bolognesa", 25000, 20);
            productosCarta[4] = new Producto("Lasana pollo y champinones", 27000, 20);
            productosCarta[5] = new Producto("Lomo de cerdo", 28500, 35);
            productosCarta[6] = new Producto("Churrasco", 40000, 15);
            productosCarta[7] = new Producto("Milanesa de pollo", 35000, 15);
            productosCarta[8] = new Producto("Copa con helado", 9000, 13);
            productosCarta[9] = new Producto("Brownie con helado", 12000, 10);
            productosCarta[10] = new Producto("Postre tres leches", 11000, 14);
            productosCarta[11] = new Producto("Limonada natural", 9000, 9);
            productosCarta[12] = new Producto("Jugo de mora", 8000, 15);
            productosCarta[13] = new Producto("Coca cola", 5000, 20);
            productosCarta[14] = new Producto("Cafe", 4500, 20);
            productosCarta[15] = new Producto("Aromatica", 4500, 10);

            for (int i = 0; i == productosCarta.Length; i++)
            {
                productosCarta[i].id = i + 1;
            }

            Inventario inventario= new Inventario();
            inventario.GuardarCarta(productosCarta);

            MenuPrincipal principal = new MenuPrincipal();
            principal.carta = inventario;
            int num = 0;
            while (true)
            { 
                principal.ImprimirMenu();
            }
        }
    }
}