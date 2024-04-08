using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class MenuPrincipal
    {
        Mesa mesa = new Mesa(); int idMesa;

        Factura factura = new Factura();

        Producto producto = new Producto();

        UI ui = new UI();

        public void EditarMenu()
        {

        }
        public void ImprimirMenu()
        {
            int opcion = 0;

            Console.Clear();
            ui.Menu();
            ui.ImprimirLinea(27, " _"); Console.WriteLine();
            ui.ImprimirColumna(1, "|"); Console.Write("                1. Seleccionar mesa                    "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                2. Ver carta                           "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                3. Editar carta                        "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                4. Asignar productos a la mesa         "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                5. Cambiar productos de la mesa        "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                6. Imprimir factura                    "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                7. Guardar factura                     "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                8. Salir                               "); ui.ImprimirColumna(1, "|");
            ui.ImprimirColumna(1, "|"); Console.Write("                                                       "); ui.ImprimirColumna(1, "|");
            ui.ImprimirLinea(27, " _"); Console.WriteLine(); Console.WriteLine();
            Console.Write("- - > "); opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1: mesa.Elegir(idMesa); break;
                case 2: /*Enviar a Clase*/ break;
                case 3: /*Enviar a Clase*/ break;
                case 4: /*Enviar a Clase*/ break;
                case 5: /*Enviar a Clase*/ break;
                case 6: /*Enviar a Clase*/ break;
                case 7: /*Enviar a Clase*/ break;
                case 8: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opción no existente, vuelva a ingresar una opción."); Console.ReadKey(); ImprimirMenu(); break;
            }
        }

        public void Carta()
        {

        }
    }
}
