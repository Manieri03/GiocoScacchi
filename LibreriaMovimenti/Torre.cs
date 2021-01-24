using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Torre:Pezzo
    {
        public Torre(Schieramento schieramento) : base(5, schieramento) { }

        public override void Muovi(Cella c)
        {
            if (c.x == Cella.x || c.y == Cella.y)
            {
                Cella = c;
            }
            else throw new Exception("La mossa non è valida"); 
        }
    }
}
