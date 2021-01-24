using System;
using System.Collections.Generic;

namespace LibreriaMovimenti
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        public List<Cella> celle { get; private set; } = new List<Cella>();

        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    celle.Add(new Cella(c, n));
                }
            }
        }


        public Cella GetCella(char x, int y)
        {
            foreach (Cella p in celle)
            {
                if (p.x == x && p.y == y)
                {
                    return p;
                }
            }
            throw new Exception("Cella non valida");
        }
    }
}
