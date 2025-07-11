using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio_3
{
    public class MaquinaCafe
    {
		private static int _contMaquinas = 0;

		private int _numero;

		public int Numero
		{
			get { return _numero; }
		}

		private Cafe _cafe;

		public Cafe Cafe
		{
			get { return _cafe; }
			set { _cafe = value; }
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

		private double _recaudacionMaquina;

		public double RecaudacionMaquina
		{
			get { return _recaudacionMaquina; }
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

		private int _cantCafeServido;

		public int CantidadCafeServido
		{
			get { return _cantCafeServido; }
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

		public VasoCafe Cargar(Vaso vaso)
		{
            if (vaso.Capacidad <= _nivel)
            {
				//verdadero
				VasoCafe vasoLleno = vaso.Servir(_cafe, this);
                _nivel -= vaso.Capacidad;
                if (_nivel == 0)
                {
                    //verdadero
                    Recargar();
                }
				return vasoLleno;
            }
			return null;
		}

		public bool Recargar()
		{
			bool ok = _capacidad > _nivel;
            if (ok)
            {
                //verdadero
                _nivel = _capacidad;
                _cantRecargas++;
            }
			return ok;
        }

		public override string ToString()
        {
			return $"Máquina {_numero} | Nvl [{_nivel}]";
        }

        public void RegistrarRecaudacion(int cantidadCafe, double monto)
        {
            _cantCafeServido += cantidadCafe;
            _recaudacionMaquina += monto;
        }

        public void RegistrarCliente()
        {
            _cantClientes++;
        }


        public MaquinaCafe()
        {
			_capacidad = 1000;
			_nivel = 0;
			_recaudacionMaquina = 0.0;
			_cantClientes = 0;
			_cantRecargas = 0;
			_cantCafeServido = 0;
        }

        public MaquinaCafe(Cafe cafe) : this()
        {
			_cafe = cafe;
			_contMaquinas++;
			_numero = _contMaquinas;
        }
    }
}