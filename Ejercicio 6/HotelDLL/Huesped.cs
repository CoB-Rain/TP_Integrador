using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class Huesped
    {
		public Huesped(long dni, string nombre, string apellido, DateTime fn)
        {
			_nombre = nombre;
			_apellido = apellido;
			_dni = dni;
			_fechaNacimiento = fn;
			_edad = CalcularEdad();
        }

        private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
		}

		private DateTime _fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
		}

		private long _dni;

		public long DNI
		{
			get { return _dni; }
		}

		private byte _edad;

		public byte Edad
		{
			get { return _edad; }
		}

		private int _cantVecesHospedado = 0;

		public int CantidadVecesHospedado
		{
			get { return _cantVecesHospedado; }
		}

        public override string ToString()
        {
			return $"{DNI} - {Nombre} {Apellido}";
        }

        public byte CalcularEdad()
		{
			byte edad = 0;

			edad = Convert.ToByte(DateTime.Now.Year - _fechaNacimiento.Year);

			return edad;
		}

		public void Hospedar()
		{
			_cantVecesHospedado++;
		}
	}
}