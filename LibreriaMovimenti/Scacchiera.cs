using System;
using System.Collections.Generic;

namespace LibreriaMovimenti
{
    public class Scacchiera
    {
        public Scacchiera() {}
        public Cella c { get; private set; }
        public List<Cella> Celle { get; private set; }
    }
}
