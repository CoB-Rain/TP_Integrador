using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Negra : Cerveza
    {
        public Negra() : base()
        {
            Sabor = Sabor.Negra;
            Origen = Origen.Nacional;
            Precio = 58;
        }
    }
}