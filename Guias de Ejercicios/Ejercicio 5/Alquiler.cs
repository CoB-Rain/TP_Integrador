using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{
    public class Alquiler
    {
        public Alquiler()
        {
			_montoTotal = 0;
			_pagado = false;
        }

        public Alquiler(Cancha cancha) : this()
        {
			_cancha = cancha;
        }

		public Alquiler(Cancha cancha, DateTime inicio, int duracion) : this(cancha)
        {
			_duracion = duracion;
			_fechaInicio = inicio;
        }

        protected Cancha _cancha;

		public Cancha Cancha
		{
			get { return _cancha; }
			set { _cancha = value; }
		}

		private DateTime _fechaInicio;

		public DateTime FechaInicio
		{
			get { return _fechaInicio; }
			set { _fechaInicio = value; }
		}

		public DateTime FechaFin
		{
			get { return _fechaInicio.AddHours(_duracion); }
		}

		protected int _duracion;

		public int Duracion
		{
			get { return _duracion; }
			set { _duracion = value; }
		}

		protected float _montoTotal;

		public float MontoTotal
		{
			get { return _montoTotal; }
		}

		protected bool _pagado;

		public virtual float CalcularPrecio()
		{
            _montoTotal += _cancha.Valor * _duracion;
            return _montoTotal;
		}

		public virtual bool Pagar()
		{
			if(!_pagado)
			{
                _cancha.Alquilar(_duracion);
				_pagado = true;
            }
			return _pagado;
		}
	}
}