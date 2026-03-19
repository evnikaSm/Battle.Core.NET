using Battle.Core;

namespace Battle.Web.Services
{
    public class GameStateService
    {
        public List<Wojownik> Druzyna { get; private set; }
        public List<string> Logi { get; private set; }

        public GameStateService()
        {
            Druzyna = new List<Wojownik>
            {
                new Kratos("Kratos", 10, 200, 75),
                new Atreus("Atreus", 5, 100, 3),
                new Freya("Freya", 8, 150, 45),
                new Thor("Thor", 9, 250)
            };

            Logi = new List<string>();
            DodajLog("=== GOD OF WAR RAGNARÖK - SYSTEM POSTACI ===");
        }

        public void Reset()
        {
            Druzyna = new List<Wojownik>
            {
                new Kratos("Kratos", 10, 200, 75),
                new Atreus("Atreus", 5, 100, 3),
                new Freya("Freya", 8, 150, 45),
                new Thor("Thor", 9, 250)
            };

            Logi = new List<string>();
            DodajLog("System został zresetowany.");
        }

        public Wojownik? Znajdz(string imie)
        {
            return Druzyna.FirstOrDefault(w => w.Imię == imie);
        }

        public void DodajLog(string tekst)
        {
            Logi.Insert(0, tekst);
        }
    }
}