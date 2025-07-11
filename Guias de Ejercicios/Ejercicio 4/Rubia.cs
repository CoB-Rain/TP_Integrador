using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Rubia : Cerveza
    {
        public Rubia(Origen origen) : base()
        {
            Sabor = Sabor.Rubia;
            Origen = origen;
            if(origen == Origen.Nacional)
            {
                Precio = 50;
            }
            else
            {
                Precio = 65;
            }
        }
    }
}