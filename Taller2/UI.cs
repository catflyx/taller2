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

        public void Mesa()
        {
            Console.WriteLine(" __  __  _____  _____  _____ ");
            Console.WriteLine("/  \\/  \\/   __\\/  ___>/  _  \\");
            Console.WriteLine("|  \\/  ||   __||___  ||  _  |");
            Console.WriteLine("\\__ \\__/\\_____/<_____/\\__|__/");
                             
        }

        public void EditarCarta()
        {
            Console.WriteLine(" _____  _____  ___  ____  _____  _____    _____  _____  _____  ____  _____ ");
            Console.WriteLine("/   __\\|  _  \\/___\\/    \\/  _  \\/  _  \\  /     \\/  _  \\/  _  \\/    \\/  _  \\");
            Console.WriteLine("|   __||  |  ||   |\\-  -/|  _  ||  _  <  |  |--||  _  ||  _  <\\-  -/|  _  |");
            Console.WriteLine("\\_____/|_____/\\___/ |__| \\__|__/\\__|\\_/  \\_____/\\__|__/\\__|\\_/ |__| \\__|__/");
        }

        public void AsignarProducto()
        {
            Console.WriteLine(" _____  _____  ___  _____  _____  _____  _____    _____  _____  _____  _____  __ __  _____  ____  _____ ");
            Console.WriteLine("/  _  \\/  ___>/___\\/   __\\/  _  \\/  _  \\/  _  \\  /  _  \\/  _  \\/  _  \\|  _  \\/  |  \\/     \\/    \\/  _  \\");
            Console.WriteLine("|  _  ||___  ||   ||  |_ ||  |  ||  _  ||  _  <  |   __/|  _  <|  |  ||  |  ||  |  ||  |--|\\-  -/|  |  |");
            Console.WriteLine("\\__|__/<_____/\\___/\\_____/\\__|__/\\__|__/\\__|\\_/  \\__/   \\__|\\_/\\_____/|_____/\\_____/\\_____/ |__| \\_____/");
        }

        public void CambiarProducto()
        {
            Console.WriteLine(" _____  _____  __  __  _____  ___  _____  _____    _____  _____  _____  _____  __ __  _____  ____  _____ ");
            Console.WriteLine("/     \\/  _  \\/  \\/  \\/  _  \\/___\\/  _  \\/  _  \\  /  _  \\/  _  \\/  _  \\|  _  \\/  |  \\/     \\/    \\/  _  \\");
            Console.WriteLine("|  |--||  _  ||  \\/  ||  _  <|   ||  _  ||  _  <  |   __/|  _  <|  |  ||  |  ||  |  ||  |--|\\-  -/|  |  |");
            Console.WriteLine("\\_____/\\__|__/\\__ \\__/\\_____/\\___/\\__|__/\\__|\\_/  \\__/   \\__|\\_/\\_____/|_____/\\_____/\\_____/ |__| \\_____/");
        }

        public void Factura()
        {
            Console.WriteLine(" _____  _____  _____  ____  __ __  _____  _____ ");
            Console.WriteLine("/   __\\/  _  \\/     \\/    \\/  |  \\/  _  \\/  _  \\");
            Console.WriteLine("|   __||  _  ||  |--|\\-  -/|  |  ||  _  <|  _  |");
            Console.WriteLine("\\__/   \\__|__/\\_____/ |__| \\_____/\\__|\\_/\\__|__/");
        }

    }
}
