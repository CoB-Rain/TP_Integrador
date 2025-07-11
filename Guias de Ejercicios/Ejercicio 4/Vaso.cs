using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Vaso
    {
		private int _capacidad;

		public int Capacidad
		{
			get { return _capacidad; }
		}

		private TipoVaso _tipo;

		public TipoVaso Tipo
		{
			get { return _tipo; }
		}

		private int _cantVecesSolicitado;

		public int CantidadVecesSolicitado
		{
			get { return _cantVecesSolicitado; }
		}

		public void Usar()
		{
			_cantVecesSolicitado++;
		}

        public override string ToString()
        {
			return $"{_tipo}";
        }

        public Vaso(TipoVaso tipoVaso)
        {
			_tipo = tipoVaso;
			_cantVecesSolicitado = 0;
			if(tipoVaso == TipoVaso.Chopp)
			{
				_capacidad = 750;
			}
			else if(tipoVaso == TipoVaso.Vaso)
			{
				_capacidad = 500;
			}
			else
			{
				_capacidad = 3000;
			}
        }
    }
}