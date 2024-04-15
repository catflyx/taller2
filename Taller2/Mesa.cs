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

        private int idProducto;

        private int cantidad;

        private int contador = 0;

        public Mesa(int identificador) {
            this.id = identificador;
        }
        public Mesa() { }
        
        public Producto[] canasta = new Producto[16];

        public int Id { get => id; set => id = value; }
        public int Elegir(int mesa)
        {
            MenuPrincipal principal = new MenuPrincipal();

            Console.Clear();
            Console.WriteLine(); Console.WriteLine("MESA ACTUAL: " + id);
            Console.WriteLine("Elija una mesa. Ingrese un número del 1 al 5");
            Console.WriteLine();

            Console.Write("- - > "); mesa = Convert.ToInt32(Console.ReadLine());
            return mesa;
        }
        public void AgregarProducto(int mesa)
        {
            MenuPrincipal principal = new MenuPrincipal();
            id = mesa; string opcion = "si";
            contador = 0;
            
            
            while (opcion == "si")
            {
                Console.Clear();
                Console.WriteLine("- - - - - | MESA " + (id) + " | - - - - -");



                Console.WriteLine();
                Console.WriteLine("Ingrese el id del producto");
                Console.WriteLine();

                Console.Write("- - > "); idProducto = Convert.ToInt32(Console.ReadLine()); //temporal
               
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad del producto");
                Console.WriteLine();
                

                Console.Write("- - > "); cantidad = Convert.ToInt32(Console.ReadLine()); //temporal

                Program.listadoMesas[mesa-1].canasta[contador]= new Producto(idProducto, cantidad);
                

                Console.WriteLine();
                Console.WriteLine("¿Desea pedir algo más?");
                Console.WriteLine();

               /* Console.WriteLine(Program.listadoMesas[0].canasta[0].Cantidad);
                Console.WriteLine("Hola");*/

                Console.Write("- - > "); opcion = Console.ReadLine();
                contador += 1;           

                
                

            } 

            

            
        }

        public void ImprimirPedido()
        {
            for (int j = 0; j < Program.listadoMesas[0].canasta.Length; j++)
            {
                try
                {
                    Console.Write(Program.listadoMesas[0].canasta[j].Ident);
                    Console.Write("   ");
                    Console.WriteLine(Program.listadoMesas[0].canasta[j].Cantidad);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Pedido completado");
                    // 
                }

            }
        }
        public void EditarProducto()
        {
            int numMesa;
            bool rectificador;
            int numP;
            int numPNuevo;
            int cantidadNueva;
            
            do
            {
                Console.WriteLine("Ingrese el id de la mesa, recuerde que es un número del 1 al 5");
                rectificador = int.TryParse(Console.ReadLine(), out numMesa);
            }while(!rectificador && numMesa>0 && numMesa<6);
            
            
            
            do
            {
                Console.WriteLine("Ingrese el id del producto que desea cambiar, recuerde que es un número del 1 al 16");
                rectificador = int.TryParse(Console.ReadLine(), out numP);
            } while (!rectificador && numP>0 && numP<17);

            do
            {
                Console.WriteLine("Ingrese el id del producto que desea llevar, recuerde que es un número del 1 al 16");
                rectificador = int.TryParse(Console.ReadLine(), out numPNuevo);
            } while (!rectificador && numPNuevo > 0 && numPNuevo < 17);

            do
            {
                Console.WriteLine("Ingrese la cantidad");
                rectificador = int.TryParse(Console.ReadLine(), out cantidadNueva);
            } while (!rectificador && cantidadNueva > 0 && cantidadNueva < 17);

            rectificador = false;

            for (int k =0; k< Program.listadoMesas.Length; k++)
            {
                
                    if (Program.listadoMesas[k].canasta != null && Program.listadoMesas[k].Id == numMesa) {
                    try
                    {
                        for (int j = 0; j < Program.listadoMesas[k].canasta.Length; j++)
                        {
                            if (Program.listadoMesas[k].canasta[j] != null && Program.listadoMesas[k].canasta[j].Ident == numP)
                            {
                                Program.listadoMesas[k].canasta[j].Ident = numPNuevo;
                                Program.listadoMesas[k].canasta[j].Cantidad = cantidadNueva;
                                rectificador = true;
                                break;
                            }
                            else { continue; }
                        }

                        if (!rectificador) { Console.WriteLine("Producto no encontrado en su pedido"); }
                        else { Console.WriteLine("Pedido actualizado"); }
                    }
                    catch (Exception ex) { Console.WriteLine("Ya se revisó todo su pedido"); }

                } }
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
    