using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class ReservaConAdicional : Reserva
    {
        public ReservaConAdicional(List<Huesped> integrantes, Habitacion habitacion, DateTime inicio, int duracion, float deposito, List<Adicional> adicionales) : base(integrantes, habitacion, inicio, duracion, deposito)
        {
            _adicionales = adicionales;
        }

        private List<Adicional> _adicionales;

        public List<Adicional> adicionales
        {
            get { return _adicionales; }
            set { _adicionales = value; }
        }

        public override bool Pagar()
        {
            if(!_abonada)
            {
                foreach (Adicional ad in adicionales)
                {
                    _montoTotal += ad.Valor * _duracion;
                }
            }
            return base.Pagar();
        }
    }
}