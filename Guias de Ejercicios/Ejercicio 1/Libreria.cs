using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    public class Libreria : Ventas
    {
        public List<Producto> lstProductos { get; set; }

        public List<Ventas> RegistroVentas { get; set; }

        public void CrearProducto(Producto producto)
        {
            this.lstProductos.Add(producto);
        }

        public void RegistrarVenta(Ventas nuevaVenta)
        {
            RegistroVentas.Add(nuevaVenta);
            this.subtotalVenta = 0;
            this.cantProductos = 0;
        }

        public Libreria()
        {
            RegistroVentas = new List<Ventas>();
            lstProductos = new List<Producto>();
        }

    }
}