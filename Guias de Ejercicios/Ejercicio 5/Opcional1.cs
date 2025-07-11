using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ejercicio_5
{
    public class Opcional1 : Alquiler
    {
        public Opcional1(Juez arbitro)
        {
            _adicional = 100;
            _arbitro = arbitro;
            _arbitro.DefinirSueldo(50);
        }

        private Juez _arbitro;

        public Juez Arbitro
        {
            get { return _arbitro; }
        }

        protected float _adicional;

        public float Adicional
        {
            get { return _adicional; }
        }

        private bool adicionado = false;

        protected void AdicionarCancha()
        {
            if(!adicionado)
            {
                _cancha.Adicionar(_adicional);
                adicionado = true;
            }
        }

        public override float CalcularPrecio()
        {
            AdicionarCancha();
            return base.CalcularPrecio();
        }

        public virtual void PagarJuez()
        {
            float sueldoJuez = _arbitro.Sueldo * _duracion;
            _arbitro.Cobrar(sueldoJuez, this);
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