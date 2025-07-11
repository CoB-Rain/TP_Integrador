using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class Vaso
    {
		private TipoVaso _tipo;

		public TipoVaso Tipo
		{
			get { return _tipo; }
		}

		private int _capacidad;

		public int Capacidad
		{
			get { return _capacidad; }
		}

		public VasoCafe Servir(Cafe cafe, MaquinaCafe maquina)
		{
			if (cafe != null)
			{
				VasoCafe vasoLleno = new VasoCafe(_tipo, cafe, maquina);
				return vasoLleno;
			}
			return null;
		}

		public Vaso(TipoVaso tipoVaso)
		{
			_tipo = tipoVaso;
            if (tipoVaso == TipoVaso.Chico)
			{
				_capacidad = 50;
			}
			else if(tipoVaso == TipoVaso.Mediano)
			{
				_capacidad = 100;
			}
			else
			{
				_capacidad = 250;
			}
        }
    }
}