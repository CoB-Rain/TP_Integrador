using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Barril
    {
		private static int _contBarriles = 0;

		private int _numero;

		public int Numero
		{
			get { return _numero; }
		}

		private Cerveza _contenido;

		public Cerveza Contenido
		{
			get { return _contenido; }
			set { _contenido = value; }
		}

		private int _capacidad;

		public int Capacidad
		{
			get { return _capacidad; }
		}

		private int _nivel;

		public int Nivel
		{
			get { return _nivel; }
		}

		private DateTime _fechaIngreso;

		public DateTime FechaIngreso
		{
			get { return _fechaIngreso; }
		}

		private float _recaudacionBarril;

		public float RecaudacionBarril
		{
			get { return _recaudacionBarril; }
		}

		private int _cantVentas;

		public int CantidadVentas
		{
			get { return _cantVentas; }
		}

		private int _cantRecargas;

		public int CantidadRecargas
		{
			get { return _cantRecargas; }
		}

		private int _litrosServidos;

		public int LitrosServidos
		{
			get { return _litrosServidos; }
		}

		private float _pVenta;

		public float PorcentajeVenta
		{
			get { return _pVenta; }
			set { _pVenta = value; }
		}

		private float _pRecaudacion;

		public float PorcentajeRecaudacion
		{
			get { return _pRecaudacion; }
			set { _pRecaudacion = value; }
		}

        public override string ToString()
        {
			return $"Barril {_numero}";
        }

        public bool Servir(Vaso vaso)
		{
			bool ok = _nivel >= vaso.Capacidad;
			if(ok)
			{
                vaso.Usar();
                _nivel -= vaso.Capacidad;
				_litrosServidos += vaso.Capacidad;
				_contenido.RealizarVenta(vaso);
				_recaudacionBarril += _contenido.CalcularVenta(vaso);
				_cantVentas++;
			}
			return ok;
		}

		public bool Recargar()
		{
			bool ok = _nivel < _capacidad;
			if(ok)
			{
				_nivel = _capacidad;
				_cantRecargas++;
			}
			return ok;
		}

		public Barril(Cerveza contenido) : this()
        {
            _contenido = contenido;
        }

        public Barril(Cerveza contenido, DateTime ingreso) : this(contenido)
        {
			_fechaIngreso = ingreso;
        }

        public Barril()
        {
            _cantVentas = 0;
            _cantRecargas = 0;
            _recaudacionBarril = 0;
            _capacidad = 20000;
            _nivel = 0;
            _litrosServidos = 0;
            _pVenta = 0;
            _pRecaudacion = 0;
            _contBarriles++;
            _numero = _contBarriles;
			_fechaIngreso = DateTime.Now;
        }
    }
}