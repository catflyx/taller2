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

        private float IVA = 19f; private int subtotal; private DateTime fecha;
        private string[][] informacion = new string[10][];

        public string[][] Informacion { get => informacion; set => informacion = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }

        public void Imprimir(int mesa)
        {
            mesa = mesa+1;
            Console.Clear(); ui.Factura(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("Mesa: Mesa " + mesa);
            Console.WriteLine("Atendido por una consola");
            ui.ImprimirLinea(40, "-"); Console.WriteLine("Uds          Descripción          Total"); ui.ImprimirLinea(40, "-");
            ImprimirInfo(); ui.ImprimirLinea(10, "_ . "); Console.WriteLine();
            Console.WriteLine("                                 $ " + Subtotal);
            Console.WriteLine("                              IVA: " + IVA + "%"); 
            Console.WriteLine("                          IVA 19%: " + 1.19); Console.WriteLine();
            Console.WriteLine("Precio total:                      " + (Subtotal/1.19)); Console.WriteLine(); ui.ImprimirLinea(40,"-"); Console.WriteLine();
            Console.WriteLine("                 Katheryn -                 ");
            Console.WriteLine("              Simara Villasmil              ");
            Console.WriteLine("               Dana Gutierrez               "); Console.WriteLine(); Console.ReadKey();
        }

        public void ImprimirInfo() {
            if (Informacion != null)
            {
                for (int i = 0; i < Informacion.Length; i++)
                {
                    // Imprimimos cada subarreglo
                    if (Informacion[i] != null)
                    {
                        for (int j = 0; j < Informacion[i].Length; j++)
                        {
                            Console.Write(Informacion[i][j]);
                            if (j < Informacion[i].Length - 1)
                            {
                                Console.Write("          ");
                            }
                            
                        }
                    }
                    else { continue; }
                    Console.WriteLine();
                }
            }
            else { Console.WriteLine(); Console.WriteLine("XX No se pudo generar la factura XX"); }
        }
        
    }
}
