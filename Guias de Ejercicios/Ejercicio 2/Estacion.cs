using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
	public class Estacion
	{
		private Surtidor _s1 = new Surtidor();

		public Surtidor Surtidor1
		{
			get { return _s1; }
		}

		private Surtidor _s2 = new Surtidor();

		public Surtidor Surtidor2
		{
			get { return _s2; }
		}

		private Surtidor _s3 = new Surtidor();

		public Surtidor Surtidor3
		{
			get { return _s3; }
		}

		private Nafta _normal = new Nafta();

		public Nafta Normal
		{
			get { return _normal; }
		}

		private Nafta _super = new Nafta();

		public Nafta Super
		{
			get { return _super; }
		}

		private Nafta _premium = new Nafta();

		public Nafta Premium
		{
			get { return _premium; }
		}

		public double CalcularRecaudacionTotal()
		{
			return _s1.TotalRecaudado + _s2.TotalRecaudado + _s3.TotalRecaudado;
		}

		public Surtidor DevolverSurtidorMayorRecaudacion()
		{
			Surtidor aux = (_s1.TotalRecaudado >= _s2.TotalRecaudado) ? _s1 : _s2;

			aux = (aux.TotalRecaudado >= _s3.TotalRecaudado) ? aux : _s3;

			return aux;
		}

        public Surtidor DevolverSurtidorMenorRecaudacion()
        {
            Surtidor aux = (_s1.TotalRecaudado >= _s2.TotalRecaudado) ? _s2 : _s1;

            aux = (aux.TotalRecaudado >= _s3.TotalRecaudado) ? _s3 : aux;

            return aux;
        }

        public Surtidor DevolverSurtidorMasClientes()
        {
            Surtidor aux = (_s1.CantidadClientes >= _s2.CantidadClientes) ? _s1 : _s2;

            aux = (aux.CantidadClientes >= _s3.CantidadClientes) ? aux : _s3;

            return aux;
        }

		public double CalcularPorcentajeVentaNafta(Nafta nafta)
		{
			double total = _normal.CantidadVentas + _super.CantidadVentas + _premium.CantidadVentas;

			return (nafta.CantidadVentas * 100) / total;
		}

        public double CalcularPorcentajeRecaudacionNafta(Nafta nafta)
        {
            double total = _normal.Recaudacion + _super.Recaudacion + _premium.Recaudacion;

			return (nafta.Recaudacion * 100) / total;
        }

        public Surtidor DevolverSurtidorMayorRecargas()
        {
            Surtidor aux = (_s1.CantidadRecargas >= _s2.CantidadRecargas) ? _s1 : _s2;

            aux = (aux.CantidadRecargas >= _s3.CantidadRecargas) ? aux : _s3;

            return aux;
        }

		public double CalcularPromedioVentasSurtidor()
		{
			return (_s1.CantidadClientes + _s2.CantidadClientes + _s3.CantidadClientes) / 3;
		}

        public double CalcularPromedioRecaudacionSurtidor()
        {
            return (_s1.TotalRecaudado + _s2.TotalRecaudado + _s3.TotalRecaudado) / 3;
        }
    }
}