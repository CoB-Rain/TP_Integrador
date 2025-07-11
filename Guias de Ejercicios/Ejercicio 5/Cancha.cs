using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{
    public class Cancha
    {
        public Cancha(TipoCancha tipo)
        {
			contNumeroCanchas++;
			_numero = contNumeroCanchas;
			_cantAlquileres = 0;
			_recaudacion = 0;
			_tipo = tipo;
			if(_tipo == TipoCancha.tennis)
			{
				_valor = 200;
			}
			else if(_tipo == TipoCancha.futbol5)
			{
				_valor = 500;
			}
			else if(_tipo == TipoCancha.futbol7)
			{
				_valor = 650;
			}
			else
			{
				_valor = 800;
			}
        }

		private static int contNumeroCanchas = 0;

        private int _numero;

		public int Numero
		{
			get { return _numero; }
		}

		private TipoCancha _tipo;

		public TipoCancha Tipo
		{
			get { return _tipo; }
		}

		private float _valor;

		public float Valor
		{
			get { return _valor; }
		}

		private float _recaudacion;

		public float Recaudacion
		{
			get { return _recaudacion; }
		}

		private int _cantAlquileres;

		public int CantidadAlquileres
		{
			get { return _cantAlquileres; }
		}

		public void Alquilar(int horas)
		{
			_recaudacion += _valor * horas;
			_cantAlquileres++;
		}

		public void Adicionar(float valor)
		{
			_valor += valor;
		}

	}
}