using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Regina:Pezzo
    {
        public Regina(Schieramento schieramento) : base(10, schieramento) { }

        public override void Muovi(Cella c)
        {
            if (c.x == Cella.x || c.y == Posizione.Numero ||
                Math.Abs(c.x - Posizione.Lettera) == Math.Abs(c.y - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            else throw new Exception("Mossa non valida");
        }
    }
}
