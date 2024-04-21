using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Producto
    {

        private int id = 0;

        private float precio; private int cantidad; private string nombre;
        
        public int Ident { get => id; set => id = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        
        public float Precio { get => precio; set => precio = value; }
        
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(string nombre, float precio, int cantidad, int id)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
        public Producto(int identificador, int cantidad)
        {
            
            this.cantidad = cantidad;
            this.id = identificador;
        }



    }
}
