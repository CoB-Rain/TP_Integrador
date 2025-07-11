using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{
    public class Polideportivo
    {
        public Polideportivo()
        {
			_canchas = new List<Cancha>();
			_arbitros = new List<Juez>();
			_alquileres = new List<Alquiler>();
        }

        private List<Cancha> _canchas;

		public List<Cancha> canchas
		{
			get { return _canchas; }
			set { _canchas = value; }
		}

		private List<Juez> _arbitros;

		public List<Juez> arbitros
		{
			get { return _arbitros; }
			set { _arbitros = value; }
		}

		private List<Alquiler> _alquileres;

		public List<Alquiler> alquileres
		{
			get { return _alquileres; }
			set { _alquileres = value; }
		}

		public bool ValidarAlquiler(Cancha cancha, DateTime inicio, int duracion)
		{
			bool ok = !(_alquileres.Count > 0);
			if(!ok)
			{
                DateTime fin = inicio.AddHours(duracion);

				foreach(Alquiler alquiler in _alquileres)
				{
					if(cancha == alquiler.Cancha)
					{
						ok = inicio >= alquiler.FechaFin || fin <= alquiler.FechaInicio;
					}
				}
            }
			return ok;
		}

		public bool RegistrarAlquiler(Alquiler alquiler)
		{
			bool ok = alquiler != null;
            if (ok)
			{
                ok = ValidarAlquiler(alquiler.Cancha, alquiler.FechaInicio, alquiler.Duracion);
				if(ok)
				{
                    _alquileres.Add(alquiler);
                }
			}
			return ok;
		}

		public bool AbonarAlquiler(Alquiler alquiler)
		{
			bool ok = alquiler != null;
			if(ok)
			{
				ok = _alquileres.Contains(alquiler);
				if(ok)
				{
					ok = alquiler.Pagar();
				}
			}
			return ok;
		}

		public float ConsultarPrecioAlquiler(Alquiler alquiler)
		{
			return alquiler.CalcularPrecio();
		}

		public float ObtenerRecaudacion()
		{
			float total = 0;
			foreach(Alquiler alquiler in _alquileres)
			{
				total += alquiler.CalcularPrecio();
			}
			return total;
		}

		public float ObtenerGanancia()
		{
			float total = ObtenerRecaudacion();
			foreach(Juez juez in _arbitros)
			{
				total -= juez.Ganancia;
			}
			return total;
		}

		public Cancha MostrarCanchaMasAlquilada()
		{
			if (_canchas.Count > 0)
			{
				Cancha canchaMasAlquilada = _canchas.First();
				foreach (Cancha cancha in _canchas)
				{
					if(canchaMasAlquilada.CantidadAlquileres < cancha.CantidadAlquileres)
					{
						canchaMasAlquilada = cancha;
					}
				}
				return canchaMasAlquilada;
			}
			else
				return null;
        }

        public Cancha MostrarCanchaMasRecaudo()
        {
            if (_canchas.Count > 0)
            {
                Cancha canchaMasRecaudo = _canchas.First();
                foreach (Cancha cancha in _canchas)
                {
                    if (canchaMasRecaudo.Recaudacion < cancha.Recaudacion)
                    {
                        canchaMasRecaudo = cancha;
                    }
                }
                return canchaMasRecaudo;
            }
            else
                return null;
        }

		public Juez MostrarJuezMasPartidosDirigidos()
		{
			if (_arbitros.Count > 0)
			{
				Juez juezMasPartidosDirigio = _arbitros.First();
				foreach(Juez juez in _arbitros)
				{
					if(juezMasPartidosDirigio.CantidadPartidosDirigidos < juez.CantidadPartidosDirigidos)
					{
						juezMasPartidosDirigio = juez;
					}
				}
				return juezMasPartidosDirigio;
			}
			else
				return null;
		}

        public Juez MostrarJuezMasRecaudo()
        {
            if (_arbitros.Count > 0)
            {
                Juez juezMasRecaudo = _arbitros.First();
                foreach (Juez juez in _arbitros)
                {
                    if (juezMasRecaudo.Ganancia < juez.Ganancia)
                    {
                        juezMasRecaudo = juez;
                    }
                }
                return juezMasRecaudo;
            }
            else
                return null;
        }
    }
}