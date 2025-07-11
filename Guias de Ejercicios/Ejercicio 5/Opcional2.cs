using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{
    public class Opcional2 : Opcional1
    {
        public Opcional2(Juez arbitro, Juez linea1, Juez linea2) : base(arbitro)
        {
            _adicional += 90;
            _linea1 = linea1;
            _linea1.DefinirSueldo(35);
            _linea2 = linea2;
            _linea2.DefinirSueldo(35);
        }

        private Juez _linea1;

        public Juez Linea1
        {
            get { return _linea1; }
            set { _linea1 = value; }
        }

        private Juez _linea2;

        public Juez Linea2
        {
            get { return _linea2; }
            set { _linea2 = value; }
        }

        public override float CalcularPrecio()
        {
            AdicionarCancha();
            return base.CalcularPrecio();
        }

        //Sueldo Juez Linea
        public float CalcularSueldoLinea(Juez linea)
        {
            float sueldoLinea = linea.Sueldo * _duracion;
            return sueldoLinea;
        }

        public override void PagarJuez()
        {
            float sueldoLinea = CalcularSueldoLinea(_linea1);
            _linea1.Cobrar(sueldoLinea, this);
            sueldoLinea = CalcularSueldoLinea(_linea2);
            _linea2.Cobrar(sueldoLinea, this);
        }

        public override bool Pagar()
        {
            if(!_pagado)
            {
                AdicionarCancha();
                PagarJuez();
            }
            return base.Pagar();
        }
    }
}