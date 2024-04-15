using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class MenuPrincipal
    {
        private string nomProducto;

        public Mesa mesa = new Mesa(); int Mesaid = 0;

        public Mesa[] listadoMesas = new Mesa[5];

        Factura factura = new Factura();

        public Inventario carta = new Inventario();
        
        

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
                case 1: mesa.Elegir(Mesaid); break; //El id no se está guardando
                case 2: Carta(); break; //Listo
                case 3: EditarCarta(); break; //El buscador no sirve
                case 4: mesa.AgregarProducto(Mesaid); break; //Maso y el id no se está guardando
                case 5: /*Enviar a Clase*/ break;
                case 6: /*Enviar a Clase*/ break;
                case 7: /*Enviar a Clase*/ break;
                case 8: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opción no existente, vuelva a ingresar una opción."); Console.ReadKey(); ImprimirMenu(); break;
            }
        }

        public void Carta()
        {
            Console.Clear();
            ui.Carta();
            ui.ImprimirLinea(27, " _"); Console.WriteLine();
            for (int i = 0; i < carta.productosCarta.GetLength(0); i++)
            {
                ui.ImprimirColumna(1, "l"); Console.Write("          ~ "); Console.Write(i+1); Console.Write(". ");Console.Write( carta.productosCarta[i].Nombre);
                Console.WriteLine();
            }
            ui.ImprimirLinea(27, " _"); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla cuando haya terminado de revisar la carta");
            Console.Write("- - > "); Console.ReadKey(); ImprimirMenu();
        }

        public void EditarCarta()
        {
            Producto[] productosCarta = new Producto[16];

            int id = 0; string opcion;
            string newN; float newP; int newC;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese cual producto de la carta desea cambiar");
                Console.WriteLine();
                Console.Write("- - > "); nomProducto = Console.ReadLine();
                mesa.BuscarProducto(nomProducto, id); //EL buscador no funciona

                Console.WriteLine();
                Console.WriteLine("¿Desea cambiar <" + productosCarta[id] + ">?");
                Console.Write("- - > "); opcion = Console.ReadLine();

            } while (opcion == "no"); Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Ingrese los nuevos datos");
            Console.WriteLine(); Console.WriteLine("Nuevo nombre: ");
            Console.Write("- - > "); newN = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Nuevo precio: ");
            Console.Write("- - > "); newP = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Nueva cantidad: ");
            Console.Write("- - > "); newC = Convert.ToInt32(Console.ReadLine());
            productosCarta[id] = new Producto(newN, newP, newC);

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine("*  Producto editado exitosamente  *");
            Console.ReadKey(); ImprimirMenu();
        }
    }
}
