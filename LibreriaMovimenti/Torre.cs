using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Torre : Pezzo
    {
        public Torre(Schieramento schieramento) : base(5, schieramento) { }

        protected override bool ControllaSpostamento(Cella nuovaPosizione)
        {
            
            if (nuovaPosizione.x == Posizione.x || nuovaPosizione.y == Posizione.y)
            {
                return true;
            }
            return false;
        }
    }
}
