using System;
using System.Collections.Generic;
using System.Text;

namespace Battle.Core
{
    public class Freya: Wojownik
    {
        public int Magia { get; set; }
        public Freya(string imię, int poziom, int hp, int magia): base(imię, poziom, hp)
        {
            if (magia < 0 || magia > 100)
                throw new ArgumentException("Ustaw magie w przedziale (0,100)");
            Magia = magia;
        }
        public override string Atakuj()
        {
            return ("Freya atakuje magicznym mieczem!") ;
        }
        public override string SpecjalnaUmiejętność()
        {
            if (Magia >= 30)
            {
                Magia -= 30;
                return ("Freya rzuca zaklęcie leczenia!");
            }
            else
            {
                return ($"Freya nie ma enough many (ma {Magia})");
            }
        }
        public override string ToString()
        {
            return $"[{Imię}] (Freya, lvl {Poziom}, HP {PunktyŻycia}, Magia {Magia})";  
        }
        public override string UżyjUmiejętnościPrzeciwko(Wojownik cel)
        {
            return ("Atreus: Ciotka Freya!");
        }
    }
}
