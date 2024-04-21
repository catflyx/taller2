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
        private int id;

        private int[][] pedido = new int[10][];



        private int idProducto;

        private int cantidad;

        private int contador = 0;

        public Mesa(int identificador)
        {
            this.id = identificador;
        }
        public Mesa() { }

        public Producto[] canasta = new Producto[16];

        public int Id { get => id; set => id = value; }
        public int[][] Pedido { get => pedido; set => pedido = value; }

        public int Elegir()
        {
            int mesa;
            MenuPrincipal principal = new MenuPrincipal();

            Console.Clear();
            Console.WriteLine("Elija una mesa. Ingrese un número del 1 al 5");
            Console.WriteLine();

            Console.Write("- - > "); mesa = Convert.ToInt32(Console.ReadLine());
            return mesa;
        }
        public void AgregarProducto(int mesa)
        {
            int cant;
            int idP;
            int prodC;
            string opcion = "si";
            bool operacion = true;
            int contador = 0; // Inicializamos el contador de productos

            Console.Clear();
            Console.WriteLine("- - - - - | MESA " + (mesa + 1) + " | - - - - -"); Console.WriteLine();
            // Solicitar la cantidad de productos que se van a agregar
            do
            {
                Console.WriteLine("Ingrese la cantidad de productos que desea agregar a la mesa"); Console.WriteLine(); Console.WriteLine();
                Console.Write("- - > ");

            } while (!int.TryParse(Console.ReadLine(), out cant));

            for (int i = 0; i < cant; i++)
            {
                do
                {
                    Console.WriteLine(); Console.WriteLine($"Ingrese el ID del producto " + (i + 1)); Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > ");

                } while (!int.TryParse(Console.ReadLine(), out idP));
                do
                {
                    Console.WriteLine(); Console.WriteLine("¿Cuántos pedidos de este producto quiere?"); Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > ");

                } while (!int.TryParse(Console.ReadLine(), out prodC));

                // Agregar el producto al pedido de la mesa
                if (contador < Program.listadoMesas[mesa].Pedido.Length)
                {
                    Program.listadoMesas[mesa].Pedido[contador] = new int[] { idP, prodC };
                    contador++; // Incrementar el contador de productos
                }
                else
                {
                    Console.WriteLine("No se puede agregar más productos. Pedido completo."); Console.ReadKey();
                    break; // Salir del ciclo si el pedido está completo
                } Console.WriteLine();
            }

        }

        public void ImprimirPedido()
        { Console.WriteLine();
            if (Pedido != null)
            {
                foreach (var p in Pedido)
                {
                    if (p != null)
                    {
                        foreach (var item in p)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine(); Console.WriteLine("------¬");
                    }

                }

            }
            else { Console.WriteLine("Pedido no encontrado"); } Console.WriteLine();
        }
        public void EditarProducto()
        {
            
            bool rectificador;
            int numP;
            int numPNuevo;
            int cantidadNueva;
            bool rect=false;

                if (Pedido != null )
                {
                do
                {
                    Console.WriteLine(); Console.WriteLine("Ingrese el id del producto que desea cambiar, recuerde que es un número del 0 al 15"); Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > "); rect = int.TryParse(Console.ReadLine(), out numP);
                } while (!rect && numP > 0 && numP < 16);

                do
                {
                    Console.WriteLine(); Console.WriteLine("Ingrese el id del producto con el que desea reemplazar el anterior, recuerde que es un número del 0 al 15"); Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > "); rectificador = int.TryParse(Console.ReadLine(), out numPNuevo);
                } while (!rect && numPNuevo > 0 && numPNuevo < 16);

                do
                {
                    Console.WriteLine(); Console.WriteLine("Ingrese la cantidad"); Console.WriteLine(); Console.WriteLine();
                    Console.Write("- - > "); rectificador = int.TryParse(Console.ReadLine(), out cantidadNueva);
                } while (!rect);

                rect = false;

                try
                    {
                        for (int j = 0; j < Pedido.Length; j++)
                        {
                        if (Pedido[j] != null)
                        {
                            if (Pedido[j][0] == numP)
                            {
                                Pedido[j][0] = numPNuevo;
                                Pedido[j][1] = cantidadNueva;
                                Console.WriteLine(); Console.WriteLine("* ~ Pedido actualizado ~ *");
                                rect = true;
                                break;
                            }
                        }
                        else { continue; }
                        }

                        if (!rect) { Console.WriteLine(); Console.WriteLine(" XX Producto no encontrado en su pedido XX"); }
                        
                    } catch (Exception ex) { Console.WriteLine(); Console.WriteLine("Ya se revisó todo su pedido"); }

                }
            
        }

        }
    }

        

        /* public int BuscarProducto(string nombre, int id)
         {
             for (int i = 0; i < inventario.productosCarta.GetLength(0); i++)
             {
                 //Esto aún no sé como hacerle
                 /*if (inventario.productosCarta[i] = ???)
                 {
                     id = ???;
                     //id = i;
                 }
             }
             return id;
         }*/
    