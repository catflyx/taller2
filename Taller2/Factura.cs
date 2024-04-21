using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Factura
    {
        UI ui = new UI(); Mesa mesa = new Mesa();

        private float IVA = 19f; private float subtotal; private DateTime fecha; 

        public void Imprimir(int mesa)
        {
            mesa = mesa+1;
            Console.Clear(); ui.Factura(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("Mesa: Mesa " + mesa);
            Console.WriteLine("Atendido por una consola");
            ui.ImprimirLinea(40, "-"); Console.WriteLine("Uds  Descripción                Total"); ui.ImprimirLinea(40, "-");
            Program.listadoMesas[mesa - 1].FacturaPedido(subtotal); ui.ImprimirLinea(10, "_ . "); Console.WriteLine();
            Console.WriteLine("                                 $ " + subtotal);
            Console.WriteLine("                              IVA: " + IVA + "%"); Console.WriteLine();
            Console.WriteLine("Precio total:                      " + (subtotal/1.19)); Console.WriteLine(); ui.ImprimirLinea(40,"-"); Console.WriteLine();
            Console.WriteLine("                 Katheryn -                 ");
            Console.WriteLine("              Simara Villasmil              ");
            Console.WriteLine("               Dana Gutierrez               "); Console.WriteLine(); Console.ReadKey();
        }

        
    }
}
