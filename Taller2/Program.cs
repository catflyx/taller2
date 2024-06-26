﻿using System.Security.Cryptography.X509Certificates;

namespace Taller2
{
    internal class Program
    {
        public static Producto[] productosCarta = new Producto[16];
        public static Mesa[] listadoMesas = new Mesa[5];
        public static Factura[] facturas = new Factura[10];

       
        public static void Main(string[] args)
        {
            productosCarta[0] = new Producto("Crema de champinones", 21000, 10,0);
            productosCarta[1] = new Producto("Patacon con carne", 24000, 10,1);
            productosCarta[2] = new Producto("Porcion de platanitos", 7000, 15,2);
            productosCarta[3] = new Producto("Lasana Bolognesa", 25000, 20,3);
            productosCarta[4] = new Producto("Lasana pollo y champinones", 27000, 20,4);
            productosCarta[5] = new Producto("Lomo de cerdo", 28500, 35,5);
            productosCarta[6] = new Producto("Churrasco", 40000, 15,6);
            productosCarta[7] = new Producto("Milanesa de pollo", 35000, 15,7);
            productosCarta[8] = new Producto("Copa con helado", 9000, 13,8);
            productosCarta[9] = new Producto("Brownie con helado", 12000, 10,9);
            productosCarta[10] = new Producto("Postre tres leches", 11000, 14,10);
            productosCarta[11] = new Producto("Limonada natural", 9000, 9,11);
            productosCarta[12] = new Producto("Jugo de mora", 8000, 15,12);
            productosCarta[13] = new Producto("Coca cola", 5000, 20,13);
            productosCarta[14] = new Producto("Cafe", 4500, 20,14);
            productosCarta[15] = new Producto("Aromatica", 4500, 10,15);

            
           

            for (int i =0; i< listadoMesas.Length; i++)
            {
                listadoMesas[i]=new Mesa(i+1);
            }
            for (int j = 0; j < facturas.Length; j++)
            {
                facturas[j] = new Factura();
            }

            MenuPrincipal principal = new MenuPrincipal();
            
            
            while (true)
            { 
                principal.ImprimirMenu();
            }

         
        }
    }
}