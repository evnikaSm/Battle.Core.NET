using System;
using System.Collections.Generic;
using System.Text;

namespace Battle.Core
{
    public class Atreus:Wojownik
    {
        public int Strzały { get; set; }
        public Atreus(string imię, int poziom, int hp, int strzały): base(imię, poziom,hp)
        {
            Strzały = strzały;
        }
        public override string Atakuj()
        {
            if (Strzały > 0)
            {
                Strzały -= 1;
                return ($"Atreus strzela z łuku! Pozostało {Strzały - 1} strzał.");
            }
            else
                return ("Atreus nie ma strzał!");
        }
        public override string SpecjalnaUmiejętność()
        {
            return ("Atreus przywołuje wilki!");
        }
        public override string ToString()
        {
            return $"[{Imię}] (Atreus, lvl {Poziom}, HP {PunktyŻycia}, Strzały {Strzały})";
        }
        public override string UżyjUmiejętnościPrzeciwko(Wojownik cel)
        {
            return ("Freya: Mały wilczku!");
        }
    }
}
