using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HotelDLL
{
	public class HotelTuristico
	{
		public HotelTuristico()
		{
			_habitaciones = new List<Habitacion>();
			_huespedes = new List<Huesped>();
			_reservas = new List<Reserva>();
			_recaudacion = 0.0f;
		}

		private List<Habitacion> _habitaciones;

		public List<Habitacion> habitaciones
		{
			get { return _habitaciones; }
			set { _habitaciones = value; }
		}

		private List<Huesped> _huespedes;

		public List<Huesped> huespedes
		{
			get { return _huespedes; }
			set { _huespedes = value; }
		}

		private List<Reserva> _reservas;

		public List<Reserva> reservas
		{
			get { return _reservas; }
			set { _reservas = value; }
		}

		private float _recaudacion;

		public float Recaudacion
		{
			get { return _recaudacion; }
		}

		public bool ValidarReserva(Reserva nuevaReserva)
		{
			bool ok = !(_reservas.Count > 0);
			if(!ok)
			{
				ok = true;
			    foreach (Reserva r in _reservas)
			    {
					if(nuevaReserva.Habitacion == r.Habitacion)
					{
						ok = nuevaReserva.CheckIn >= r.CheckOut || nuevaReserva.CheckOut <= r.CheckIn;
			        }
			    }
			}
            return ok;
        }

		public bool RegistrarReserva(Reserva nuevaReserva)
		{
			bool ok = nuevaReserva != null;
			if(ok)
			{
				ok = ValidarReserva(nuevaReserva);
				if(ok)
				{
					foreach(Huesped h in nuevaReserva.Integrantes)
					{
						h.Hospedar();
					}
					nuevaReserva.Habitacion.Reservar();
                    _reservas.Add(nuevaReserva);
                }
			}
			return ok;
		}

		public bool RegistrarCancelacion(Reserva reservaCancelada)
		{
			bool ok = false;
			if(!reservaCancelada.Abonada && DateTime.Now < reservaCancelada.CheckIn)
			{
                _recaudacion = reservaCancelada.Cancelar();
                _reservas.Remove(reservaCancelada);
				ok = true;
            }
			return ok;
        }

		public bool RegistrarPago(Reserva reservaPagoPendiente)
		{
			bool ok = reservaPagoPendiente.Abonada;
            if(!ok)
			{
				reservaPagoPendiente.Pagar();
				_recaudacion = reservaPagoPendiente.MontoTotal;
			}
			return ok;
		}

		public Habitacion MostrarHabitacionMasSolicitada(DateTime inicio, DateTime fin)
		{
			/*
			var reservasEnPeriodo = _reservas.Where(r => r.CheckIn < fin && r.CheckOut > inicio);
			var agrupado = reservasEnPeriodo.GroupBy(r => r.Habitacion)
			.Select(g => new
			{
				Habitacion = g.Key,
				CantidadReservas = g.Count()
			})
			.OrderByDescending(x => x.CantidadReservas).ToList();

			return agrupado.FirstOrDefault()?.Habitacion;
			*/

			var reservasEnPeriodo = (from Reserva r in _reservas
									 where r.CheckIn < fin && r.CheckOut > inicio
									 select r).ToList();

			List<Habitacion> habitacionesValidas = new List<Habitacion>();
			foreach(Reserva r in reservasEnPeriodo)
			{
				habitacionesValidas.Add(r.Habitacion);
			}

			if (habitacionesValidas.Count > 0)
			{
                var habitaciones = (from Habitacion h in habitacionesValidas
                                    orderby h.CantidadVecesReservada descending
                                    select h).Take(1).ToList();

            }
            Habitacion habitacionMasSolicitada = habitaciones.FirstOrDefault();

            return habitacionMasSolicitada;
        }

		public Huesped MostrarHuespedMasVecesHospedado()
		{
			if (_huespedes.Count > 0)
			{
				Huesped huespedMasVecesHospedado = _huespedes.First();
				foreach (Huesped h in _huespedes)
				{
					if (huespedMasVecesHospedado.CantidadVecesHospedado < h.CantidadVecesHospedado)
					{
						huespedMasVecesHospedado = h;
					}
				}
				return huespedMasVecesHospedado;
			}
			else
				return null;
		}

		public float RecaudacionPorFecha(DateTime inicio, DateTime fin)
		{
            var reservasEnPeriodo = (from Reserva r in _reservas
                                     where r.CheckIn < fin && r.CheckOut > inicio
                                     select r).ToList();
			float total = 0.0f;
			foreach(Reserva r in reservasEnPeriodo)
			{
				total += r.MontoTotal;
			}
			return total;
        }
	}
}