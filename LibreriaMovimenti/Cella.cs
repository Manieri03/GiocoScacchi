using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaMovimenti
{
    public class Cella
    {
        public char X { get; private set; }
        public int Y { get; private set; }
        public Schieramento s { get; private set; }
        public Pezzo p { private get; set; }

        public Cella(char x, int y)
        {
            this.Y = y;
            this.X = x;
        }
    }
}
