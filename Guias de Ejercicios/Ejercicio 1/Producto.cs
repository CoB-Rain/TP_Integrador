using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    public class Producto
    {
		private string _codigoBarras;

		public string codigoBarras
		{
			get { return _codigoBarras; }
			set { _codigoBarras = value; }
		}

		private string _nombre;

		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _desc;

		public string descripcion
		{
			get { return _desc; }
			set { _desc = value; }
		}

		private double _precio;

		public double precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

        public Producto()
        {
            
        }

        public Producto(string codigoBarras, string nombre, string descripcion, double precio)
        {
			this.codigoBarras = codigoBarras;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.precio = precio;
        }
    }
}