using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Battle.Core
{
    public  class Kratos : Wojownik
    {
        public Kratos(string imię, int poziom, int hp, int gniew) : base(imię, poziom, hp)
        {
            if (gniew < 0 || gniew > 100)
                throw new Exception("gniew nie wychodzi poza (0,100)");
            else
                Gniew = gniew;
        }

        public int Gniew { get; set; }
        public override string Atakuj()
        {
            return ("Kratos atakuje Toporem Lewiatana!");
        }
        public override string SpecjalnaUmiejętność()
        {
            if (Gniew >= 50)
            {
                Gniew = 0;
                return ("Kratos w aktywuje Gniew Sparty!");
            }
            else
            {
                return  ($"Kratos nie ma wystarczająco gniewu (ma {Gniew})");
            }
        }
        public override string ToString()
        {
            return $"[{Imię}] (Kratos, lvl {Poziom}, HP {PunktyŻycia}, Gniew {Gniew})";
        }
        public override string UżyjUmiejętnościPrzeciwko(Wojownik cel)
        {
            return ("Thor: Synu Sparty!");
        }
        public void SekretnaKombinacja()
        {
            Console.WriteLine("Kratos: BOY!");
            // Ukryty easter egg: jeśli imię to "Kratos" i poziom 10,
            // wypisz dodatkowo: "Kratos: Jesteś gotowy, synu?"
            if (Imię == "Kratos" && Poziom == 10)
            {
                Console.WriteLine("Kratos: Jesteś gotowy, synu?");
            }
        }
        public string SekretnaKombinacjaTekst()
        {
            string wynik = "Kratos: BOY!";

            if (Imię == "Kratos" && Poziom == 10)
            {
                wynik += "\nKratos: Jesteś gotowy, synu?";
            }

            return wynik;
        }
    }

}
