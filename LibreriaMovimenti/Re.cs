using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Re : Pezzo
    {
        public Re(Schieramento schieramento) : base(int.MaxValue, schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (Math.Abs(nuovaPosizione.x - Posizione.x) == Math.Abs(1) && nuovaPosizione.y == Posizione.y ||
                Math.Abs(nuovaPosizione.y - Posizione.y) == Math.Abs(1) && nuovaPosizione.x == Posizione.x ||
                Math.Abs(nuovaPosizione.x - Posizione.x) == Math.Abs(1) && Math.Abs(nuovaPosizione.y - Posizione.y) == Math.Abs(1))
            {
                Posizione = nuovaPosizione;
            }
            Errore();
        }

        public override string ShortName => " R";
    }
}
