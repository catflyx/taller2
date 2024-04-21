using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Inventario
    {
        private Producto[] productosCarta = new Producto[16];
        
        internal Producto[] ProductosCarta { get => productosCarta; set => productosCarta = value; }

        public Inventario() { }

        public Inventario(Producto[] inventarioInicial) {
            this.ProductosCarta = inventarioInicial;
        }

        public void InicializarInventario(Producto[] productos)
        {
            ProductosCarta = productos;
        }  
        public void Restar(int id)
        {

        }

        public void Administrar()
        {

        }
    }
}
