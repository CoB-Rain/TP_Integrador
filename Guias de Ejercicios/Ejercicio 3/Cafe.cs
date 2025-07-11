using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class Cafe
    {
		private TipoCafe _tipo;

		public TipoCafe Tipo
		{
			get { return _tipo; }
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
			set { _cantVentas = value; }
        }

        private double _recaudacionCafe;

        public double RecaudacionCafe
        {
            get { return _recaudacionCafe; }
			set { _recaudacionCafe = value; }
        }

        public void RegistrarVentaUnitaria()
        {
            _cantVentas++;
        }

        public override string ToString()
		{
			return $"{Tipo}";
		}

		public Cafe(TipoCafe tipoCafe)
        {
			_tipo = tipoCafe;
			if(tipoCafe == TipoCafe.Arabigo)
			{
				_precio = 50;
			}
			else
			{
				_precio = 58;
			}
			_cantVentas = 0;
			_recaudacionCafe = 0.0;
        }
    }
}