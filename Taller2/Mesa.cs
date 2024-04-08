using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Mesa
    {
        Producto producto = new Producto(); 

        private int id; 
        Producto[] canasta;

        public int Elegir(int id)
        {
            MenuPrincipal principal = new MenuPrincipal();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Eliga una mesa");
            Console.WriteLine();

            Console.Write("- - > "); id = Convert.ToInt32(Console.ReadLine());
            principal.ImprimirMenu(); return id;
        }
        public void AgregarProducto(int id)
        {

        }
        public void EditarProducto()
        {

        }
    }
}
