using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Mesa
    {
        Inventario inventario = new Inventario(); MenuPrincipal principal = new MenuPrincipal();

        private int id = 0;
        Producto[] canasta;

        public int Elegir(int mesa)
        {
            MenuPrincipal principal = new MenuPrincipal();

            Console.Clear();
            Console.WriteLine(); Console.WriteLine("MESA ACTUAL: " + id);
            Console.WriteLine("Elija una mesa");
            Console.WriteLine();

            Console.Write("- - > "); mesa = Convert.ToInt32(Console.ReadLine());
            return mesa; id = mesa;
        }
        public void AgregarProducto(int mesa)
        {
            MenuPrincipal principal = new MenuPrincipal();
            id = mesa; string opcion = "si";
            
            while (opcion == "si")
            {
                Console.Clear();
                Console.WriteLine("- - - - - | MESA " + (id) + " | - - - - -");
                Console.WriteLine();
                Console.WriteLine("¿Qué producto quiere pedir?");
                Console.WriteLine();

                Console.Write("- - > "); Console.ReadKey(); //temporal

                Console.WriteLine();
                Console.WriteLine("¿Cuántos de este producto desea pedir?");
                Console.WriteLine();

                Console.Write("- - > "); Console.ReadKey(); //temporal

                Console.WriteLine();
                Console.WriteLine("¿Desea pedir algo más?");
                Console.WriteLine();

                Console.Write("- - > "); opcion = Console.ReadLine();

            } 
        }
        public void EditarProducto()
        {
            
        }

        public int BuscarProducto(string nombre, int id)
        {
            for (int i = 0; i < inventario.productosCarta.GetLength(0); i++)
            {
                //Esto aún no sé como hacerle
                /*if (inventario.productosCarta[i] = ???)
                {
                    id = ???;
                    //id = i;
                }*/
            }
            return id;
        }
    }
}
