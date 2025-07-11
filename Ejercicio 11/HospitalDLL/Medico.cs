using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalDLL
{
    public class Medico
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

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

		private List<Especialidad> _especialidades;

		public List<Especialidad> especialidades
		{
			get { return _especialidades; }
			set { _especialidades = value; }
		}
	}
}