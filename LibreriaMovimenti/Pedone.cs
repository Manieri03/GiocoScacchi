using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Pedone : Pezzo
    {
        public Pedone(Schieramento schieramento) : base(1, schieramento) { }

        protected override bool ControllaSpostamento(Cella nuovaPosizione)
        {
            if (nuovaPosizione.x == Posizione.x)
            {
                int segno = Colore == Schieramento.Bianco ? +1 : -1;
                int start = Colore == Schieramento.Bianco ? 2 : 7;
                if (nuovaPosizione.y == Posizione.y + segno)
                {
                    return true;
                }
                else if (Posizione.y == start && nuovaPosizione.y == Posizione.y + segno * 2)
                {
                    return true;
                }
                
            }

            return false;

        }
    }
}
