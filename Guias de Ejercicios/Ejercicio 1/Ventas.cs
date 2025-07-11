using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_1
{
    public class Ventas
    {
        private double _subtotalVentas;

        public double subtotalVenta
        {
            get { return _subtotalVentas; }
            set { _subtotalVentas = value; }
        }

        private int _cantProductos;

        public int cantProductos
        {
            get { return _cantProductos; }
            set { _cantProductos = value; }
        }


        public void AgregarProductoAVenta(Producto producto, int cantidad)
        {
            this.cantProductos += cantidad;
            this.subtotalVenta += producto.precio * cantidad;
        }

        public Ventas()
        {
            this.subtotalVenta = 0;
        }

        public Ventas(double subtotal)
        {
            this.subtotalVenta = subtotal;
        }
    }

}