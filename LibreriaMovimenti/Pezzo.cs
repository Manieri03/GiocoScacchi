using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public abstract class Pezzo
    {
        public int peso { get; private set; }
        public Schieramento colore { get; private set; }
        public Cella posizione { get; set; }
        public Pezzo(int p, Schieramento colore)
        {
            p = peso;
            this.colore = colore;
        }
        public abstract void Muovi(Cella c) { }

        public override string ToString()
        {
            return $"Il pezzo, che ha peso {peso}, di colore {colore}, sta in {posizione}";
        }
    }
}
