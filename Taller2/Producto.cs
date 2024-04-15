using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Producto
    {

        public int id = 0; private float precio; private int cantidad; private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        
        public float Precio { get => precio; set => precio = value; }
        
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(string nombre, float precio, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}
