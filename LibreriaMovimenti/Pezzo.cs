﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public abstract class Pezzo
    {
        private Cella posizione;

        public int Peso { get; private set; }
        public Schieramento Colore { get; private set; }
        public Cella Posizione
        {
            get => Posizione; set
            {
                if (Posizione != null)
                    Posizione.Pezzo = null;
                Posizione = value;
                Posizione.Pezzo = this;
            }
        }

        public string Name => GetType().Name;
        public virtual string ShortName => Name.Substring(0, 3);
        protected Pezzo(int p, Schieramento colore)
        {
            p = Peso;
            this.Colore = colore;
        }
        public virtual void Muovi(Cella nuovaposizione)
        {
            ControllaPosizione(nuovaposizione);
            if (ControllaSpostamento(nuovaposizione))
                EseguiMovimento(nuovaposizione);
            throw new Exception("Mossa non valida");
        }

        private void ControllaPosizione(Cella p)
        {
            if (Posizione.Pezzo != null)
                throw new Exception($"La cella {Posizione} è già occupata");
        }

        protected abstract bool ControllaSpostamento(Cella nuovaposizione);

        private void EseguiMovimento(Cella nuovaposizione)
        {
            Posizione = nuovaposizione;
            Console.WriteLine($"Pezzo{ToString()} spostato in {nuovaposizione}");
        }



        public override string ToString()
        {
            return $"Il pezzo, che ha peso {Peso}, di colore {Colore}, sta in {Posizione}";
        }

    }
}
