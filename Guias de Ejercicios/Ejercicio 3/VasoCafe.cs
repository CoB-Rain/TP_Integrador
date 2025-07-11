using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    
    public class VasoCafe : Vaso
    {
        private Cafe _contenido;

        public Cafe Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        private MaquinaCafe _maquinaOrigen;

        public MaquinaCafe MaquinaOrigen
        {
            get { return _maquinaOrigen; }
            set { _maquinaOrigen = value; }
        }

        public string DescripcionParaLista
        {
            get
            {
                return $"$({(Capacidad * _contenido.Precio) / 1000}) | {Tipo} - {_contenido}";
            }
        }


        public void RegistrarVenta()
        {
            _contenido.RecaudacionCafe += (Capacidad * _contenido.Precio) / 1000;

            if (_maquinaOrigen != null)
            {
                _maquinaOrigen.RegistrarRecaudacion(Capacidad, (Capacidad * _contenido.Precio) / 1000);
            }
        }

        public VasoCafe(TipoVaso tipoVaso, Cafe contenido, MaquinaCafe maquina) : base(tipoVaso)
        {
            _contenido = contenido;
            _maquinaOrigen = maquina;
        }
    }
}