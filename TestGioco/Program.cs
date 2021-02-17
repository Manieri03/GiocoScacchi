using LibreriaMovimenti;
using System;
using System.IO;

namespace TestGioco
{
    class Program
    {
        private const bool SCRIVI_FILE = false;
        private static StreamWriter writer;
        static void Main(string[] args)
        {
            Scacchiera s = Scacchiera.Istanza;
            s.Spostamento += StampaConsole;
            writer = new StreamWriter("log.txt");
            s.Spostamento += StampaFile;

            Pedone p = new Pedone(Schieramento.Bianco)
            {
                Posizione = s.GetCella('B', 2)
            };
            Torre t = new Torre(Schieramento.Bianco)
            {
                Posizione = s.GetCella('C', 1)
            };
            Alfiere a = new Alfiere(Schieramento.Bianco)
            {
                Posizione = s.GetCella('E', 2)
            };
            Re re = new Re(Schieramento.Bianco)
            {
                Posizione = s.GetCella('E', 1)
            };
            Regina r = new Regina(Schieramento.Bianco)
            {
                Posizione = s.GetCella('G', 3)
            };
            Cavallo c = new Cavallo(Schieramento.Bianco)
            {
                Posizione = s.GetCella('F', 2)
            };
            s.Print();

            Console.WriteLine();
            Console.WriteLine("".PadRight(40, '-'));
            Console.WriteLine();
            try
            {
                p.Muovi(s.GetCella('B', 3));
                t.Muovi(s.GetCella('C', 4));
                a.Muovi(s.GetCella('B', 5));
                re.Muovi(s.GetCella('F', 1));
                r.Muovi(s.GetCella('G', 5));
                c.Muovi(s.GetCella('E', 5));
                s.Print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            writer.Flush();
            writer.Close();
            Console.ReadLine();

        }
        private static void StampaConsole(Pezzo p, Cella vecchia, Cella nuova)
        {
            Console.WriteLine($"Il pezzo {p.Name} si è spostato da {vecchia} a {nuova}");
        }
        private static void StampaFile(Pezzo p, Cella vecchia, Cella nuova)
        {
            writer.WriteLine($"Il pezzo {p.Name} si è spostato da {vecchia} a {nuova}");
        }
    }
}
