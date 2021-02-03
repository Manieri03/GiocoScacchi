using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Alfiere:Pezzo
    {
        public Alfiere(Schieramento schieramento) : base(3, schieramento) { }

        protected override bool ControllaSpostamento(Cella nuovaPosizione)
        {
            if (Math.Abs(nuovaPosizione.x - Posizione.x) == Math.Abs(nuovaPosizione.y - Posizione.x))
            {
                return true;
            }
            else
                return false;
            
        }

    }
}
