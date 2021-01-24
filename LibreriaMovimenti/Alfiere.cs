using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    class Alfiere:Pezzo
    {
        public Alfiere(Schieramento schieramento) : base(3, schieramento) { }

        public override void Muovi(Cella c)
        {
            if (Math.Abs(c.x - Cella.x) == Math.Abs(c.y - Cella.y))
            {
                Cella = c;
            }
            else throw new Exception("Mossa non valida");
        }
    }
}
