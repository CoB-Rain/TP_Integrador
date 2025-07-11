using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    public class Nafta
    {
		private string _tipo;

		public string Tipo
		{
			get
			{
				if(string.IsNullOrWhiteSpace(_tipo))
				{
					return "Sin Nombre";
				}
				else
				{
					return _tipo;
				}
			}
			set { _tipo = value; }
		}

		private double _precio;

		public double Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		private int _cantVentas;

		public int CantidadVentas
		{
			get { return _cantVentas; }
		}

		private double _recaudacion;

		public double Recaudacion
		{
			get { return _recaudacion; }
		}

		public void RegistrarVenta(int Litros)
		{
			_cantVentas++;
			_recaudacion += Litros * _precio;
		}
    }
}