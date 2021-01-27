using System;
using System.Collections.Generic;

namespace LibreriaMovimenti
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        public IDictionary<string, Cella> Celle { get; } = new Dictionary<string, Cella>();

        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    Celle.Add($"{c}{n}", new Cella(c,n));
                }
            }
        }


        public Cella GetCella(char x, int y)
        {
            string pos = $"{x}{y}";
            {
                if (Celle.ContainsKey(pos))
                {
                    return Celle[pos];
                }
            }
            throw new Exception($"Cella {pos} non valida");
        }

        public void Stampa()
        {
            string s = "";
            int DimensioneCelle = 3; 
        }

        //private static void StampaLettere(ref string s,int DimensioneCelle)
    }
}
