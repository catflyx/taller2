using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class MenuPrincipal
    {
        Mesa mesa = new Mesa(); int Mesaid = 0;

        Factura factura = new Factura();

        Producto producto = new Producto();

        Inventario inventario = new Inventario();

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
                case 1: mesa.Elegir(Mesaid); break; //Maso
                case 2: Carta(inventario.producto); break; //Listo
                case 3: /*Enviar a Clase*/ break;
                case 4: mesa.AgregarProducto(Mesaid); break; //Maso
                case 5: /*Enviar a Clase*/ break;
                case 6: /*Enviar a Clase*/ break;
                case 7: /*Enviar a Clase*/ break;
                case 8: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opción no existente, vuelva a ingresar una opción."); Console.ReadKey(); ImprimirMenu(); break;
            }
        }

        public void Carta(Producto[] productos)
        {
            Console.Clear();
            //ui.Carta();
            ui.ImprimirLinea(27, " _"); Console.WriteLine();
            for (int i = 0; i < productos.GetLength(0); i++)
            {
                ui.ImprimirColumna(1, "l"); Console.Write("          ~ "); Console.Write(productos[i]);
                Console.WriteLine();
            }
            ui.ImprimirLinea(27, " _"); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla cuando haya terminado de revisar la carta");
            Console.Write("- - > "); Console.ReadKey(); ImprimirMenu();
        }
    }
}
