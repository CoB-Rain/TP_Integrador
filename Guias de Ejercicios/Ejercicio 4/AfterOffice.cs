using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
	public class AfterOffice
	{
		public List<Barril> Barriles { get; set; }

		private Cerveza _rubiaNacional;

		public Cerveza RubiaNacional
		{
			get { return _rubiaNacional; }
		}

		private Cerveza _negraNacional;

		public Cerveza NegraNacional
		{
			get { return _negraNacional; }
		}

		private Cerveza _rubiaExtranjero;

		public Cerveza RubiaExtranjero
		{
			get { return _rubiaExtranjero; }
		}

		private Vaso _chopp;

		public Vaso Chopp
		{
			get { return _chopp; }
		}

		private Vaso _vaso;

		public Vaso Vaso
		{
			get { return _vaso; }
		}

		private Vaso _jarra;

		public Vaso Jarra
		{
			get { return _jarra; }
		}

		private float _recaudacionTotal;

		public float RecaudacionTotal
		{
			get { return _recaudacionTotal; }
		}


		public void RegistrarRecaudacionAfter()
		{
			_recaudacionTotal = CalcularRecaudacionAfter();
		}

		public float CalcularRecaudacionAfter()

		{
			float total = 0;
			if (Barriles.Count > 0)
			{
				foreach (Barril barril in Barriles)
				{
					total += barril.RecaudacionBarril;
				}
			}
			return total;
		}

		public Barril MostrarBarrilMasCervezaSirvio()
		{
			if (Barriles.Count > 0)
			{
				Barril barrilMasCervezaSirvio = Barriles.First();
				foreach (Barril barril in Barriles)
				{
					if (barrilMasCervezaSirvio.LitrosServidos < barril.LitrosServidos)
					{
						barrilMasCervezaSirvio = barril;
					}
				}
				return barrilMasCervezaSirvio;
			}
			else
				return null;
		}

		public Barril MostrarBarrilMenosCervezaSirvio()
		{
			if (Barriles.Count > 0)
			{
				Barril barrilMenosCervezaSirvio = Barriles.First();
				foreach (Barril barril in Barriles)
				{
					if (barrilMenosCervezaSirvio.LitrosServidos > barril.LitrosServidos)
					{
						barrilMenosCervezaSirvio = barril;
					}
				}
				return barrilMenosCervezaSirvio;
			}
			else
				return null;
		}

		public Barril MostrarBarrilMasDineroRecaudo()
		{
			if (Barriles.Count > 0)
			{
				Barril barrilMasDineroRecaudo = Barriles.First();
				foreach (Barril barril in Barriles)
				{
					if (barrilMasDineroRecaudo.RecaudacionBarril < barril.RecaudacionBarril)
					{
						barrilMasDineroRecaudo = barril;
					}
				}
				return barrilMasDineroRecaudo;
			}
			else
				return null;
		}

		public Cerveza MostrarCervezaMasVendida()
		{
			Cerveza cervezaMasVendida;
			if (_rubiaNacional.CantidadVentas > _negraNacional.CantidadVentas)
			{
				//verdadero
				if(_rubiaNacional.CantidadVentas > _rubiaExtranjero.CantidadVentas)
				{
                    //verdadero
                    cervezaMasVendida = _rubiaNacional;
                }
				else
				{
					//falso
					cervezaMasVendida = _rubiaExtranjero;
				}
			}
			else if(_negraNacional.CantidadVentas > _rubiaExtranjero.CantidadVentas)
			{
				//verdadero
				cervezaMasVendida = _negraNacional;
			}
			else
			{
				//falso
				cervezaMasVendida = _rubiaExtranjero;
			}
			return cervezaMasVendida;
		}

		public Cerveza MostrarCervezaMayorGanancia()
		{
			Cerveza cervezaMayorGanancia = (_rubiaNacional.RecaudacionCerveza > _negraNacional.RecaudacionCerveza) ? _rubiaNacional : _negraNacional;
			cervezaMayorGanancia = (cervezaMayorGanancia.RecaudacionCerveza > _rubiaExtranjero.RecaudacionCerveza) ? cervezaMayorGanancia : _rubiaExtranjero;
			return cervezaMayorGanancia;
		}

		public Cerveza MostrarCervezaMasLitrosVendidos()
		{
            Cerveza cervezaMasLitros = (_rubiaNacional.LitrosServidos > _negraNacional.LitrosServidos) ? _rubiaNacional : _negraNacional;
            cervezaMasLitros = (cervezaMasLitros.LitrosServidos > _rubiaExtranjero.LitrosServidos) ? cervezaMasLitros : _rubiaExtranjero;
            return cervezaMasLitros;
        }

        public Cerveza MostrarCervezaMenosLitrosVendidos()
        {
            Cerveza cervezaMenosLitros = (_rubiaNacional.LitrosServidos > _negraNacional.LitrosServidos) ? _negraNacional : _rubiaNacional;
            cervezaMenosLitros = (cervezaMenosLitros.LitrosServidos > _rubiaExtranjero.LitrosServidos) ? _rubiaExtranjero : cervezaMenosLitros;
            return cervezaMenosLitros;
        }

		public Vaso MostrarVasoMasSolicitado()
		{
			Vaso vasoMasSolicitado = (_chopp.CantidadVecesSolicitado > _vaso.CantidadVecesSolicitado) ? _chopp : _vaso;
			vasoMasSolicitado = (vasoMasSolicitado.CantidadVecesSolicitado > _jarra.CantidadVecesSolicitado) ? vasoMasSolicitado : _jarra;
			return vasoMasSolicitado;
		}

		public float CalcularPorcentajeVentaCerveza(Cerveza cerveza)
		{
			float porcentajeVenta = 0;
			int total = _rubiaNacional.CantidadVentas + _negraNacional.CantidadVentas + _rubiaExtranjero.CantidadVentas;
			if (total > 0)
			{
                porcentajeVenta = (cerveza.CantidadVentas * 100) / total;
            }
            return porcentajeVenta;
		}

        public float CalcularPorcentajeRecaudacionCerveza(Cerveza cerveza)
        {
            float porcentajeVenta = 0;
            float total = _rubiaNacional.RecaudacionCerveza + _negraNacional.RecaudacionCerveza + _rubiaExtranjero.RecaudacionCerveza;
			if (total > 0)
			{
                porcentajeVenta = (cerveza.RecaudacionCerveza * 100) / total;
            }
            return porcentajeVenta;
        }

		public void CalcularPorcentajeVentaBarriles()
		{
			if(Barriles.Count > 0)
			{
				int total = 0;
				foreach(Barril b in Barriles)
				{
					total += b.CantidadVentas;
				}

				if (total > 0)
				{
                    foreach (Barril b in Barriles)
                    {
                        b.PorcentajeVenta = (b.CantidadVentas * 100) / total;
                    }
                }
			}
		}

        public void CalcularPorcentajeRecaudacionBarriles()
        {
            if (Barriles.Count > 0)
            {
                float total = 0;
                foreach (Barril barril in Barriles)
                {
                    total += barril.RecaudacionBarril;
                }

				if (total > 0)
				{
                    foreach (Barril barril in Barriles)
                    {
                        barril.PorcentajeRecaudacion = (barril.RecaudacionBarril * 100) / total;
                    }
                }
            }
        }

        public AfterOffice()
        {
			Barriles = new List<Barril>();
			_rubiaNacional = new Rubia(Origen.Nacional);
			_negraNacional = new Negra();
			_rubiaExtranjero = new Rubia(Origen.Extranjero);
			_chopp = new Vaso(TipoVaso.Chopp);
			_vaso = new Vaso(TipoVaso.Vaso);
			_jarra = new Vaso(TipoVaso.Jarra);
			_recaudacionTotal = 0;
        }
    }
}