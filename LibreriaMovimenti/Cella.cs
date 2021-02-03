using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Cella
    {
        public char x { get; private set; }
        public int y { get; private set; }
        public Schieramento schieramento { get; private set; }
        public Pezzo Pezzo { get; set; }

        internal Cella(char x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Schieramento Schieramento
        {
            get
            {
                bool nPari = y % 2 == 0;
                bool lPari = (x - 'A') % 2 == 0;
                if (nPari == lPari)
                    return Schieramento.Nero;
                return Schieramento.Bianco;


            }
        }
        public override string ToString()
        {
            return $"{x+ ";" +y}";
        }
    }
}
