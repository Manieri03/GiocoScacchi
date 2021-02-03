using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Pedone : Pezzo
    {
        public Pedone(Schieramento schieramento) : base(1, schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            switch (Colore)
            {
                case Schieramento.Bianco:
                    if (nuovaPosizione.x == Posizione.x && nuovaPosizione.y == Posizione.y + 1)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else if (nuovaPosizione.x == Posizione.x && nuovaPosizione.y == Posizione.y + 2 && Posizione.y == 2)
                    {
                        Posizione = nuovaPosizione;
                    }
                    Errore();
                    break;

                case Schieramento.Nero:
                    if (nuovaPosizione.x == Posizione.x && nuovaPosizione.y == Posizione.y - 1)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else if (nuovaPosizione.x == Posizione.x && nuovaPosizione.y == Posizione.y - 2 && Posizione.y == 7)
                    {
                        Posizione = nuovaPosizione;
                    }
                    Errore();
                    break;
            
            }
        }
    }
}
