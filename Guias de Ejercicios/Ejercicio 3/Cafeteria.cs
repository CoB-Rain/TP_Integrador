using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Ejercicio_3
{
    public class Cafeteria
    {
		private List<MaquinaCafe> _maquinas;

		public List<MaquinaCafe> Maquinas
		{
			get { return _maquinas; }
			set { _maquinas = value; }
		}

		private Cafe _arabigo;

		public Cafe Arabigo
		{
			get { return _arabigo; }
			set { _arabigo = value; }
		}

		private Cafe _robusto;

		public Cafe Robusto
		{
			get { return _robusto; }
			set { _robusto = value; }
		}

		private Vaso _chico;

		public Vaso Chico
		{
			get { return _chico; }
			set { _chico = value; }
		}

		private Vaso _mediano;

		public Vaso Mediano
		{
			get { return _mediano; }
			set { _mediano = value; }
		}

		private Vaso _grande;

		public Vaso Grande
		{
			get { return _grande; }
			set { _grande = value; }
		}

		private double _recaudacionTotal;

		public double RecaudacionTotal
		{
			get { return _recaudacionTotal; }
		}

		public double CalcularRecaudacionTotal()
		{
			double total = 0.0;
			foreach(MaquinaCafe maquinaCafe in _maquinas)
			{
				total += maquinaCafe.RecaudacionMaquina;
			}
			return total;
		}

		public MaquinaCafe ObtenerMaquinaMasCafeSirvio()
		{
			if (_maquinas.Count > 0)
			{
                MaquinaCafe maquinaMasCafeSirvio = _maquinas.First();
                foreach (MaquinaCafe maquina in _maquinas)
                {
                    bool ok = (maquinaMasCafeSirvio.CantidadCafeServido < maquina.CantidadCafeServido);
                    if (ok)
                    {
                        maquinaMasCafeSirvio = maquina;
                    }
                }
				return maquinaMasCafeSirvio;
            }
			else
				return null;
		}

        public MaquinaCafe ObtenerMaquinaMenosCafeSirvio()
        {
            if (_maquinas.Count > 0)
            {
				MaquinaCafe maquinaMenosCafeSirvio = _maquinas.First();
                foreach (MaquinaCafe maquina in _maquinas)
                {
					bool ok = (maquinaMenosCafeSirvio.CantidadCafeServido > maquina.CantidadCafeServido);
                    if (ok)
                    {
                        maquinaMenosCafeSirvio = maquina;
                    }
                }
                return maquinaMenosCafeSirvio;
            }
            else
                return null;
        }

		public MaquinaCafe ObtenerMaquinaMayorRecaudacion()
		{
			if (_maquinas.Count > 0)
			{
				MaquinaCafe maquinaMayorDineroRecaudo = _maquinas.First();
				foreach (MaquinaCafe maquina in _maquinas)
				{
					bool ok = (maquinaMayorDineroRecaudo.RecaudacionMaquina < maquina.RecaudacionMaquina);
					if (ok)
					{
						maquinaMayorDineroRecaudo = maquina;
					}
				}
				return maquinaMayorDineroRecaudo;
			}
			else
				return null;
		}

        public MaquinaCafe ObtenerMaquinaMenorRecaudacion()
        {
            if (_maquinas.Count > 0)
            {
                MaquinaCafe maquinaMenorDineroRecaudo = _maquinas.First();
                foreach (MaquinaCafe maquina in _maquinas)
                {
                    bool ok = (maquinaMenorDineroRecaudo.RecaudacionMaquina > maquina.RecaudacionMaquina);
                    if (ok)
                    {
                        maquinaMenorDineroRecaudo = maquina;
                    }
                }
                return maquinaMenorDineroRecaudo;
            }
            else
                return null;
        }

		public Cafe ObtenerCafeMasDemandado()
		{
			Cafe cafeMasDemandado = (_arabigo.CantidadVentas > _robusto.CantidadVentas) ? _arabigo : _robusto;
			return cafeMasDemandado;
		}

        public Cafe ObtenerCafeMenosDemandado()
        {
            Cafe cafeMenosDemandado = (_arabigo.CantidadVentas < _robusto.CantidadVentas) ? _arabigo : _robusto;
            return cafeMenosDemandado;
        }

		public Cafe ObtenerCafeMayorRecaudacion()
		{
			Cafe cafeMayorRecaudacion = (_arabigo.RecaudacionCafe > _robusto.RecaudacionCafe) ? _arabigo : _robusto;
			return cafeMayorRecaudacion;
		}

        public Cafe ObtenerCafeMenorRecaudacion()
        {
            Cafe cafeMenorRecaudacion = (_arabigo.RecaudacionCafe < _robusto.RecaudacionCafe) ? _arabigo : _robusto;
            return cafeMenorRecaudacion;
        }

        public double CalcularPorcentajeVentaCafe(Cafe cafe)
        {
            double total = _arabigo.CantidadVentas + _robusto.CantidadVentas;
            return (cafe.CantidadVentas * 100) / total;
        }

        public double CalcularPorcentajeRecaudacionCafe(Cafe cafe)
        {
            double total = _arabigo.RecaudacionCafe + _robusto.RecaudacionCafe;
            return (cafe.RecaudacionCafe * 100) / total;
        }

		public void CalcularPorcentajeVentaMaquina()
		{
			if (_maquinas.Count > 0)
			{
				double total = 0.0;
				foreach(MaquinaCafe maquina in _maquinas)
				{
					total += maquina.CantidadClientes;
				}

                foreach (MaquinaCafe maquina in _maquinas)
                {
					maquina.PorcentajeVenta = float.Parse(((maquina.CantidadClientes * 100) / total).ToString());
                }
			}
		}

        public void CalcularPorcentajeRecaudacionMaquina()
        {
            if (_maquinas.Count > 0)
            {
                double total = 0.0;
                foreach (MaquinaCafe maquina in _maquinas)
                {
                    total += maquina.RecaudacionMaquina;
                }

                foreach (MaquinaCafe maquina in _maquinas)
                {
                    maquina.PorcentajeRecaudacion = float.Parse(((maquina.RecaudacionMaquina * 100) / total).ToString());
                }
            }
        }

		public MaquinaCafe ObtenerMaquinaMayorRecargas()
		{
			if (_maquinas.Count > 0)
			{
				MaquinaCafe maquinaMayorRecargas = _maquinas.First();
				foreach(MaquinaCafe maquina in _maquinas)
				{
					bool ok = maquinaMayorRecargas.CantidadRecargas < maquina.CantidadRecargas;
					if(ok)
					{
						maquinaMayorRecargas = maquina;
					}
				}
                return maquinaMayorRecargas;
            }
			else
				return null;
		}

		public Cafeteria()
        {
			_maquinas = new List<MaquinaCafe>();
			_arabigo = new Cafe(TipoCafe.Arabigo);
			_robusto = new Cafe(TipoCafe.Robusto);
			_chico = new Vaso(TipoVaso.Chico);
			_mediano = new Vaso(TipoVaso.Mediano);
			_grande = new Vaso(TipoVaso.Grande);
			_recaudacionTotal = 0.0;
        }

    }
}