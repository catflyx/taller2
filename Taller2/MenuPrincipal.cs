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

        public Mesa mesa = new Mesa();

        

        Factura factura = new Factura();

        private Factura[] facturas = new Factura[10];

        private int idMesa;
        
        

        UI ui = new UI();

        internal Factura[] Facturas { get => facturas; set => facturas = value; }

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
                case 1: idMesa = mesa.Elegir()-1; break; //Listo
                case 2: Carta(); break; //Listo
                case 3: //Listo
                    Console.Clear();
                    Console.WriteLine("Ingrese el id del producto que desea cambiar");
                    Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > ");
                    try { int.TryParse(Console.ReadLine(), out int idAnt);
                        Console.WriteLine(); Console.WriteLine("Ingrese 1 si desea editar el precio de producto; ingrese 2 si desea cambiarlo por otro producto");
                        Console.WriteLine(); Console.WriteLine();
                        Console.Write("- - > "); string op = Console.ReadLine();
                        if (op == "1")
                        {
                            Console.WriteLine(); Console.WriteLine("Ingrese el nuevo precio"); Console.WriteLine(); Console.WriteLine();
                            Console.Write("- - > ");
                            try
                            {
                                int.TryParse(Console.ReadLine(), out int nuevoPrecio);
                                Program.productosCarta[idAnt].Precio = nuevoPrecio;
                          
                            }
                            catch (Exception) { Console.WriteLine("Precio inválido"); break; } }
                            if (op == "2")
                            {
                                Console.WriteLine(); Console.WriteLine("Ingrese el nuevo nombre"); Console.WriteLine(); Console.WriteLine();
                            Console.Write("- - > "); try { string nuevoNombre = Console.ReadLine(); Program.productosCarta[idAnt].Nombre = nuevoNombre; } catch (NullReferenceException) { Console.WriteLine("Nombre inválido");break; }

                                Console.WriteLine(); Console.WriteLine("Ingrese el nuevo precio"); Console.WriteLine(); Console.WriteLine();
                            Console.Write("- - > "); try { int.TryParse(Console.ReadLine(), out int nuevoValor); Program.productosCarta[idAnt].Precio = nuevoValor; } catch (Exception) { Console.WriteLine("Precio inválido"); break; }

                                Console.WriteLine(); Console.WriteLine("Ingrese la nueva cantidad"); Console.WriteLine(); Console.WriteLine();
                            Console.Write("- - > "); try { int.TryParse(Console.ReadLine(), out int nuevaCantidad); Program.productosCarta[idAnt].Cantidad = nuevaCantidad; } catch (Exception) { Console.WriteLine("Cantidad inálida"); break; }

                            }
                            Console.WriteLine("Opción inválida"); break;
                        }catch (Exception) { Console.WriteLine("Id inválido"); break; }

                case 4: Program.listadoMesas[idMesa].AgregarProducto(idMesa); Console.WriteLine(); //Listo
                    Program.listadoMesas[idMesa].ImprimirPedido(); Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para salir");Console.WriteLine(); Console.Write("- - > "); Console.ReadKey(); break;
                    /*if (Console.ReadLine() == "e") { break; } else { Console.WriteLine("Esto fue lo que se ejecutó");break; }*/
                
                case 5: //Listo
                    bool rectificador=false; Console.Clear();
                    do
                    {
                        Console.WriteLine("Ingrese el id de la mesa, recuerde que es un número del 1 al 5"); Console.WriteLine(); Console.WriteLine();
                        Console.Write("- - > "); rectificador = int.TryParse(Console.ReadLine(), out idMesa);
                    } while (!rectificador && idMesa > 0 && idMesa < 6);
                    Program.listadoMesas[idMesa-1].ImprimirPedido(); Program.listadoMesas[idMesa - 1].EditarProducto(); Console.WriteLine();
                    Console.WriteLine("Nuevo pedido:"); Program.listadoMesas[idMesa-1].ImprimirPedido();
                    Console.WriteLine("Presione cualquier tecla para salir"); Console.WriteLine(); Console.Write("- - > "); Console.ReadKey(); break;
                    

                case 6:
                    bool rect = false; Console.Clear();
                    int idFactura = 0;
                    do
                    {
                        Console.WriteLine("Ingrese el id de la mesa, recuerde que es un número del 1 al 5"); Console.WriteLine(); Console.WriteLine();
                        Console.Write("- - > "); rect = int.TryParse(Console.ReadLine(), out idMesa);
                    } while (!rect && idMesa > 0 && idMesa < 6);
                    rect = false;
                    do
                    {
                        Console.WriteLine("Ingrese el id de la factura, recuerde que es un número del 0 al 9"); Console.WriteLine(); Console.WriteLine();
                        Console.Write("- - > "); rect = int.TryParse(Console.ReadLine(), out idFactura);
                    } while (!rect && idFactura >= 0 && idMesa <= 9);

                    Program.listadoMesas[idMesa - 1].GenerarFactura(idFactura, Program.facturas); Program.facturas[0].Imprimir(idMesa-1);
                    Console.WriteLine("Presione cualquier tecla para salir"); Console.WriteLine(); Console.Write("- - > "); Console.ReadKey(); break;
                case 7: // Datos a guardar en el archivo CSV
                    do
                    {
                        Console.WriteLine("Ingrese el id de la factura, recuerde que es un número del 0 al 9"); Console.WriteLine(); Console.WriteLine();
                        Console.Write("- - > "); rect = int.TryParse(Console.ReadLine(), out idFactura);
                    } while (!rect && idFactura >= 0 && idMesa <= 9);


                    // Ruta del archivo CSV
                    string rutaArchivo = $"factura{idFactura}.csv";

                    // Crear y escribir en el archivo CSV
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        if (Program.facturas[idFactura] != null)
                        {
                            if (Program.facturas[idFactura].Informacion != null)
                            {
                                try
                                {
                                    string[] cadenaInicial = new string[] { "Cantidad", "Descripcion", "Precio" };
                                    writer.WriteLine(string.Join(";", cadenaInicial));
                                    foreach (string[] fila in Program.facturas[idFactura].Informacion)
                                    {
                                        if (fila != null)
                                        {
                                            writer.WriteLine(string.Join(";", fila));
                                        }
                                        else { continue; }
                                    }
                                }
                                catch (NullReferenceException) { Console.WriteLine("Toda la información ha sido leída "); }
                            }
                            else { Console.WriteLine("Factura sin información"); }
                        }
                        else { Console.WriteLine("Factura no encontrada"); }
                    }

                    Console.WriteLine("Datos guardados en el archivo CSV: " + rutaArchivo);
                    string directorioActual = Directory.GetCurrentDirectory();

                    Console.WriteLine("Directorio actual: " + directorioActual);



                    break;
                case 8: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opción no existente, vuelva a ingresar una opción."); Console.ReadKey(); ImprimirMenu(); break;
            }
        }

        public void Carta()
        {
            Console.Clear();
            ui.Carta();
            ui.ImprimirLinea(27, " _"); Console.WriteLine();
            for (int i = 0; i < Program.productosCarta.GetLength(0); i++)
            {
                ui.ImprimirColumna(1, "l"); Console.Write("          ~ "); Console.Write(i); Console.Write(". ");Console.Write( Program.productosCarta[i].Nombre + "  -  " + Program.productosCarta[i].Precio);
                Console.WriteLine();
            }
            ui.ImprimirLinea(27, " _"); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla cuando haya terminado de revisar la carta");
            Console.Write("- - > "); Console.ReadKey(); ImprimirMenu();
        }

       /* public void EditarCarta()
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
               // mesa.BuscarProducto(nomProducto, id); //EL buscador no funciona

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
        }*/
    }
}
