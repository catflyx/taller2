using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Inventario
    {
        public Producto[] productosCarta = new Producto[16];

        public void GuardarCarta(Producto[] productos)
        {
            this.productosCarta = productos;
        }


        public void AgregarProductos()
        {
            for (int i = 0; i < productosCarta.Length; i++)
            {
                int valor;
                int cantidad = 0;
                Console.WriteLine("Ingrese el nombre del producto");
                string name = Console.ReadLine();

                bool cant;
                bool price;


                do
                {
                    Console.WriteLine($"Ingrese un número entero positivo como precio del producto");
                    cant = int.TryParse(Console.ReadLine(), out valor);

                } while (!cant);

                do
                {
                    Console.WriteLine($"Ingrese un número entero positivo como la cantidad del producto en inventario");
                    price = int.TryParse(Console.ReadLine(), out cantidad);
                } while (!price);

                productosCarta[i] = new Producto();

            }
        }
        public void Restar(int id)
        {

        }

        public void Administrar()
        {

        }
    }
}
