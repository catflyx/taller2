using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class UI
    {
        public void ImprimirLinea(int ancho, string caracter)
        {
            string espacio = " ";

            Console.Write("°");
            for (int i = 0; i < ancho; i++)
            {
                espacio += caracter;
            }
            Console.WriteLine(espacio); Console.Write("°");
        }
        public void ImprimirColumna(int alto, string caracter)
        {
            string espacio = "";

            for (int i = 0; i < alto; i++)
            {
                espacio += caracter;
            }
            Console.WriteLine(espacio);
        }

        public void Menu()
        {
            //Imágen de esas echas con texto
            Console.WriteLine(" __  __  _____  _____  __ __");
            Console.WriteLine("/  \\/  \\/   __\\/  _  \\/  |  \\");
            Console.WriteLine("|  \\/  ||   __||  |  ||  |  |");
            Console.WriteLine("\\__ \\__/\\_____/\\__|__/\\_____/");
        }

        public void Carta()
        {
            Console.WriteLine(" _____  _____  _____  ____  _____");
            Console.WriteLine("/     \\/  _  \\/  _  \\/    \\/  _  \\");
            Console.WriteLine("|  |--||  _  ||  _  <\\-  -/|  _  |");
            Console.WriteLine("\\_____/\\__|__/\\__|\\_/ |__| \\__|__/");

        }

    }
}
