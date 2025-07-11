using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalDLL
{
    public class Paciente
    {
		private string _nombre;

		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private byte _edad;

		public byte Edad
		{
			get { return _edad; }
			set { _edad = value; }
		}

		private DateTime _fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}

		private long _dni;

		public long DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private HistorialClinico _historial;

		public HistorialClinico historial
		{
			get { return _historial; }
			set { _historial = value; }
		}
	}
}