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
        Producto producto = new Producto(); 

        private int id = 0; private string nomProducto;
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
            Console.WriteLine();
            Console.WriteLine("Ingrese cual producto desea cambiar");
            Console.WriteLine();
            Console.Write("- - > "); nomProducto = Console.ReadLine();
            BuscarProducto(nomProducto, producto.id);

            Console.WriteLine();
            Console.WriteLine("Ingrese cual producto desea cambiar");
            Console.WriteLine();
            Console.Write("- - > "); nomProducto = Console.ReadLine();
        }

        public int BuscarProducto(string nombre, int id)
        {
            for (int i = 0; i < canasta.GetLength(0); i++)
            {
                //Esto aún no sé como hacerle
                /*if (canasta[i] = nombre)
                {
                    id = i;
                }*/
            }
            return id;
        }
    }
}
