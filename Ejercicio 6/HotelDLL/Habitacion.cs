using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDLL
{
    public class Habitacion
    {
        public Habitacion(TipoHabitacion tipo, bool vistaAlMar = false)
        {
            _tipo = tipo;
            contNumero++;
            _numero = contNumero;
            _cantVecesReservada = 0;
            if(_tipo == TipoHabitacion.Simple)
            {
                _valor = 200;
            }
            else if(_tipo == TipoHabitacion.Doble)
            {
                _valor = 350;
            }
            else if(_tipo == TipoHabitacion.Triple)
            {
                _valor = 550;
            }
            else
            {
                _valor = 700;
            }

            _vistaAlMar = vistaAlMar;
            if (vistaAlMar)
            {
                _valor -= _valor * 0.15f;
            }
        }

        private bool _vistaAlMar;

        public bool VistaAlMar
        {
            get { return _vistaAlMar; }
        }

        private TipoHabitacion _tipo;

        public TipoHabitacion Tipo
        {
            get { return _tipo; }
        }

        protected float _valor;

        public float Valor
        {
            get { return _valor; }
        }

        private static int contNumero = 0;

        private int _numero;

        public int Numero
        {
            get { return _numero; }
        }

        private int _cantVecesReservada;

        public int CantidadVecesReservada
        {
            get { return _cantVecesReservada; }
        }

        public override string ToString()
        {
            return $"N°{Numero} - {Tipo} vista al mar:{VistaAlMar}";
        }

        public void Reservar()
        {
            _cantVecesReservada++;
        }
    }
}