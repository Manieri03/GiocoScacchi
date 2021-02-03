using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Cavallo:Pezzo
    {
        public Cavallo(Schieramento schieramento) : base(3, schieramento) { }

        protected override bool ControllaSpostamento(Cella nuovaPosizione)
        {
            int h = Math.Abs(nuovaPosizione.x - Posizione.y);
            int v = Math.Abs(nuovaPosizione.x - Posizione.x);
            if ((h == 3 && v == 1) || (h == 1 && v == 3))
            {
                return true;
            }
            else
                return false;
        }
    }
}
