using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Regina : Pezzo
    {
        public Regina(Schieramento schieramento) : base(10, schieramento) { }

        protected override bool ControllaSpostamento(Cella nuovaPosizione)
        {
           
            if (nuovaPosizione.x == Posizione.x || nuovaPosizione.y == Posizione.y ||
                Math.Abs(nuovaPosizione.x - Posizione.x) == Math.Abs(nuovaPosizione.y - Posizione.y))
            {
                return true;
            }
            return false;
        }
    }
}
