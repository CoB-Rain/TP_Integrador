using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalDLL
{
    public class HistorialClinico
    {
		private Paciente _paciente;

		public Paciente paciente
		{
			get { return _paciente; }
			set { _paciente = value; }
		}

		private List<Estudio> _estudios;

		public List<Estudio> estudios
		{
			get { return _estudios; }
			set { _estudios = value; }
		}

		private List<Derivacion> _derivaciones;

		public List<Derivacion> derivaciones
		{
			get { return _derivaciones; }
			set { _derivaciones = value; }
		}

		private List<OrdenMedica> _ordenes;

		public List<OrdenMedica> ordenes
		{
			get { return _ordenes; }
			set { _ordenes = value; }
		}

		private List<Turno> _turnos;

		public List<Turno> turnos
		{
			get { return _turnos; }
			set { _turnos = value; }
		}
	}
}