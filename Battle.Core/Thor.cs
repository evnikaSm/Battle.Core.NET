using System;
using System.Collections.Generic;
using System.Text;
namespace Battle.Core
{
    public sealed class Thor : Wojownik
    {
        public Thor(string imię, int poziom, int hp) : base(imię, poziom, hp){}
        public sealed override string SpecjalnaUmiejętność()
        {
            return ("Thor przywołuje pioruny!");
        }
        public override string Atakuj()
        {
            return ("Thor uderza Mjolnirem!");
        }
        public override string ToString()
        {
            return $"[{Imię}] (Thor, lvl {Poziom}, HP {PunktyŻycia})";
        }
        public override string UżyjUmiejętnościPrzeciwko(Wojownik cel)
        {
            return ("Kratos: Wreszcie się spotykamy, Thorki!");
        }
    }
}
