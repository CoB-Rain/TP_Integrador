using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Ejercicio_5
{
    public class Juez
    {
        public Juez()
        {
			_ganancia = 0;
			_sueldo = 0;
			_cantPartidosDirigidos = 0;
			contNumeroLegajo++;
			_legajo = contNumeroLegajo;
        }

        public Juez(string nombre, string apellido) : this()
        {
			_nombre = nombre;
			_apellido = apellido;
        }

        private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private static int contNumeroLegajo = 0;

		private int _legajo;

		public int Legajo
		{
			get { return _legajo; }
		}

		private float _ganancia;

		public float Ganancia
		{
			get { return _ganancia; }
		}

		private float _sueldo;

		public float Sueldo
		{
			get { return _sueldo; }
		}

		private int _cantPartidosDirigidos;

		public int CantidadPartidosDirigidos
		{
			get { return _cantPartidosDirigidos; }
		}

		private List<Alquiler> _alquileres;

		public List<Alquiler> alquileres
		{
			get { return _alquileres; }
			set { _alquileres = value; }
		}

		public void DefinirSueldo(float sueldo)
		{
			_sueldo = sueldo;
		}

		public void Cobrar(float valor, Alquiler alquiler)
		{
			_ganancia += valor;
			_alquileres.Add(alquiler);
			_cantPartidosDirigidos++;
		}

		public bool VerificarDisponibilidad(DateTime inicio, int duracion)
		{
            bool ok = !(_alquileres.Count > 0);
            if (!ok)
            {
                DateTime fin = inicio.AddHours(duracion);
				foreach(Alquiler alquiler in _alquileres)
				{
					if(alquiler is Opcional1 op1)
					{
                        if(this == op1.Arbitro)
						{
                            ok = inicio >= alquiler.FechaFin || fin <= alquiler.FechaInicio;
                        }
                    }
					else if(alquiler is Opcional2 op2)
					{
						if(this == op2.Arbitro || this == op2.Linea1 || this == op2.Linea2)
						{
                            ok = inicio >= alquiler.FechaFin || fin <= alquiler.FechaInicio;
                        }
                    }
				}
            }
            return ok;
        }
    }
}