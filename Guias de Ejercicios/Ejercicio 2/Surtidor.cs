using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    public class Surtidor
    {
		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}

		private Nafta _nafta;

		public Nafta Nafta
		{
			get { return _nafta; }
			set { _nafta = value; }
		}

		private int _capacidad;

		public int Capacidad
		{
			get { return _capacidad; }
			set { _capacidad = value; }
		}

		private int _nivel;

		public int Nivel
		{
			get { return _nivel; }
			set { _nivel = value; }
		}

		private double _totalRecaudado;

		public double TotalRecaudado
		{
			get { return _totalRecaudado; }
		}

		private int _cantClientes;

		public int CantidadClientes
		{
			get { return _cantClientes; }
		}

		private int _cantRecargas;

		public int CantidadRecargas
		{
			get { return _cantRecargas; }
		}

		public bool Cargar(int Litros)
		{
			bool ok = (Litros <= _nivel);
			if(ok)
			{
				//verdadero
				_nivel -= Litros;
				_totalRecaudado += Litros * _nafta.Precio;
				_cantClientes++;
				_nafta.RegistrarVenta(Litros);
				if (_nivel == 0)
				{
					//verdadero
					Recargar();
				}
			}
			return ok;
		}

		public void Recargar()
		{
			if(_capacidad > _nivel)
			{
				//verdadero
				_nivel = _capacidad;
				_cantRecargas++;
			}
		}

	}
}