using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Torre : Pezzo
    {
        public Torre(Schieramento schieramento) : base(5, schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (nuovaPosizione.x == Posizione.x || nuovaPosizione.y == Posizione.y)
            {
                Posizione = nuovaPosizione;
            }
            Errore();
        }
    }
}
