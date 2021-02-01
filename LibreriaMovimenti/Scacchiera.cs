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

        public void Print()
        {
            string s = "";
            int cellSize = 3;
            PrintLetters(ref s, cellSize);
            PrintLine(ref s, cellSize);
            for(int n=8; n >= 1; n--)
            {
                s += $"{n}|";
                for(char c='A'; c <= 'H'; c++)
                {
                    Cella cella = GetCella(c, n);
                    if (cella.Pezzo != null)
                    {
                        s += cella.Pezzo.ShortName.PadRight(cellSize);
                    }
                    else
                    {
                        s += $"".PadRight(cellSize);
                    }
                    s += "|";
                }
                s += "\n";
                PrintLine(ref s, cellSize);
            }
            PrintLetters(ref s, cellSize);
            Console.Write(s);

        }

        private static void PrintLetters(ref string s, int cellSize)
        {
            s += "";
            for(char c='A'; c<= 'H'; c++)
            {
                s += $"| {c}".PadRight(cellSize + 1);
            }
            s += "|\n";
        }

        private static void PrintLine(ref string s, int cellSize)
        {
            s += " |".PadRight(cellSize * 11, '-') + "-\n";
        }

       
    }
}
