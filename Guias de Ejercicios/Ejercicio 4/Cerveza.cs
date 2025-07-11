using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public abstract class Cerveza
    {
		private Sabor _sabor;

		public Sabor Sabor
		{
			get { return _sabor; }
			set { _sabor = value; }
		}

		private Origen _origen;

		public Origen Origen
		{
			get { return _origen; }
			set { _origen = value; }
		}

		private float _precio;

		public float Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		private float _recaudacionCerveza;

		public float RecaudacionCerveza
		{
			get { return _recaudacionCerveza; }
		}

		private int _cantVentas;

		public int CantidadVentas
		{
			get { return _cantVentas; }
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

        public void RealizarVenta(Vaso vaso)
		{
			_recaudacionCerveza += CalcularVenta(vaso);
			_litrosServidos += vaso.Capacidad;
			_cantVentas++;
		}

		public float CalcularVenta(Vaso vaso)
		{
			float total = _precio * vaso.Capacidad / 1000;
			double incremento = 0.05;
			total += total * ((float)incremento);
            return total;
		}

        public override string ToString()
        {
			return $"{_sabor} {_origen}";
        }

        protected Cerveza()
        {
			_cantVentas = 0;
			_recaudacionCerveza = 0;
			_litrosServidos = 0;
			_pVenta = 0;
			_pRecaudacion = 0;
        }
    }
}