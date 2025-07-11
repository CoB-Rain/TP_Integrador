using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;

namespace HotelDLL
{
    public class Reserva
    {
        public Reserva(List<Huesped> integrantes, Habitacion habitacion, DateTime inicio, int duracion, float deposito)
        {
			_abonada = false;
            _habitacion = habitacion;
			_checkIn = inicio;
			_duracion = duracion;
			_deposito = deposito;
			_integrantes = integrantes;
			_montoTotal = 0.0f;
        }

        protected DateTime _checkIn;

		public DateTime CheckIn
		{
			get { return _checkIn; }
		}

		public DateTime CheckOut
		{
			get { return CheckIn.AddDays(_duracion); }
		}

		protected int _duracion;

		public int Duracion
		{
			get { return _duracion; }
		}

		protected Habitacion _habitacion;

		public Habitacion Habitacion
		{
			get { return _habitacion; }
		}

		protected float _montoTotal;

		public float MontoTotal
		{
			get { return _montoTotal; }
		}

		protected List<Huesped> _integrantes;

		public List<Huesped> Integrantes
		{
			get { return _integrantes; }
		}

		protected float _deposito;

		public float Deposito
		{
			get { return _deposito; }
		}

		protected bool _abonada;

		public bool Abonada
		{
			get { return _abonada; }
		}

		public float Cancelar()
		{
            float porcentaje = _montoTotal * 0.1f;
			TimeSpan tp = DateTime.Now - CheckIn;
			//inferior a 2 dias
			if (tp.TotalDays < 2)
			{
				return _deposito - porcentaje;
			}
			//inferior a 7 dias
			else if(tp.TotalDays < 7 )
			{
				porcentaje = porcentaje * 0.5f;
                return _deposito - porcentaje;
            }
			//superior a 7 dias
			else
			{
				return _deposito;
			}
		}

		public virtual bool Pagar()
		{
			if(!_abonada)
			{
                _montoTotal += _habitacion.Valor * _duracion;
                _abonada = true;
			}
			return _abonada;
		}
	}
}