namespace Taller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ahora deja compilar pero, no entiendo como hacer q imprima sin q los métodos sean static
            ImprimirMenu();
        }
        static void ImprimirMenu()
        {
            Console.Clear(); int opcion = 0;

            ImprimirTitle();
            ImprimirLinea(27, " _"); Console.WriteLine();
            ImprimirColumna(1, "|"); Console.Write("                1. Administrar mesas                   "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                2. Ver carta                           "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                3. Editar carta                        "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                4. Asignar productos a la mesa         "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                5. Cambiar productos de la mesa        "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                6. Imprimir factura                    "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                7. Guardar factura                     "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                8. Salir                               "); ImprimirColumna(1, "|");
            ImprimirColumna(1, "|"); Console.Write("                                                       "); ImprimirColumna(1, "|");
            ImprimirLinea(27, " _"); Console.WriteLine(); Console.WriteLine();
            Console.Write("- - > "); opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1: /*Enviar a Clase*/ break;
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

        static void ImprimirLinea(int ancho, string caracter)
        {
            string espacio = " ";

            Console.Write("°");
            for (int i = 0; i < ancho; i++)
            {
                espacio += caracter;
            }
            Console.WriteLine(espacio); Console.Write("°");
        }
        static void ImprimirColumna(int alto, string caracter)
        {
            string espacio = "";

            for (int i = 0; i < alto; i++)
            {
                espacio += caracter;
            }
            Console.WriteLine(espacio);
        }
        static void ImprimirTitle()
        {
            //Imágen de esas echas con texto
            Console.WriteLine(" __  __  _____  _____  __ __");
            Console.WriteLine("/  \\/  \\/   __\\/  _  \\/  |  \\");
            Console.WriteLine("|  \\/  ||   __||  |  ||  |  |");
            Console.WriteLine("\\__ \\__/\\_____/\\__|__/\\_____/");
        }
    }
}