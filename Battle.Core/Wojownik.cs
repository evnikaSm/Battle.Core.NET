using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Battle.Core
{
    public class Wojownik
    {
        public Wojownik(string imię, int poziom, int hp)
        {
            Imię = imię;
            if (poziom < 1 || poziom > 10)
            {
                Poziom = 1;
                Console.WriteLine("Wyzerowany poziom");
            }
            else
                Poziom = poziom;
            PunktyŻycia = hp;
        }

        public string Imię { get; set; }
        public int Poziom { get; set; }
        public int PunktyŻycia { get; set; }
        public virtual string Atakuj()
        {
            return ($"[{Imię}] wykonuje podstawowy atak!");
        }
        public virtual string SpecjalnaUmiejętność()
        {
            return ($"[{Imię}] nie ma specjalnej umiejętności.");
        }
        public override string ToString()
        {
            return ($"[{Imię}] (Wojownik, lvl {Poziom}, HP {PunktyŻycia})");
        }
        public virtual string UżyjUmiejętnościPrzeciwko(Wojownik cel)
        {
            SpecjalnaUmiejętność(); // wywołanie polimorficzne
            return ($"{Imię} używa umiejętności przeciwko {cel.Imię}");
        }
        public virtual string Identyfikuj()
        {
            return ($"Jestem {GetType().Name} o imieniu {Imię}");
        }
    }
}
