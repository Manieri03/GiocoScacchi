using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Cavallo:Pezzo
    {
        public Cavallo(Schieramento schieramento) : base(3, schieramento) { }

        public override void Muovi(Cella nuovaposizione)
        {
            int h = Math.Abs(nuovaposizione.y - Posizione.y);
            int v = Math.Abs(nuovaposizione.x - Posizione.x);
            if ((h == 3 && v == 1) || (h == 1 && v == 3))
            {
                Posizione = nuovaposizione
            } else
                Errore();
        }
    }
}
