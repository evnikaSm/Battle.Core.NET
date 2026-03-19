using Battle.Core;
using Battle.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Battle.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GameStateService _gameState;

        public List<Wojownik> Druzyna => _gameState.Druzyna;
        public List<string> Logi => _gameState.Logi;

        public IndexModel(GameStateService gameState)
        {
            _gameState = gameState;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostAction(string actionType, string characterName)
        {
            var postac = _gameState.Znajdz(characterName);

            if (postac == null)
            {
                _gameState.DodajLog("Nie znaleziono postaci.");
                return RedirectToPage();
            }

            string wynik = actionType switch
            {
                "atak" => postac.Atakuj(),
                "specjalna" => postac.SpecjalnaUmiejętność(),
                "identyfikuj" => postac.Identyfikuj(),
                "sekret" when postac is Kratos kratos => kratos.SekretnaKombinacjaTekst(),
                _ => "Nieznana akcja."
            };

            _gameState.DodajLog($"[{postac.Imię}] {wynik}");
            return RedirectToPage();
        }

        public IActionResult OnPostInteraction(string attackerName, string targetName)
        {
            var atakujacy = _gameState.Znajdz(attackerName);
            var cel = _gameState.Znajdz(targetName);

            if (atakujacy == null || cel == null)
            {
                _gameState.DodajLog("Nie udało się wykonać interakcji.");
                return RedirectToPage();
            }

            string wynik = atakujacy.UżyjUmiejętnościPrzeciwko(cel);
            _gameState.DodajLog($"[INTERAKCJA] {wynik}");

            return RedirectToPage();
        }

        public IActionResult OnPostRttiDemo()
        {
            foreach (var postac in Druzyna)
            {
                _gameState.DodajLog(
                    $"RTTI -> {postac.Imię} | GetType(): {postac.GetType().Name} | is Wojownik: {postac is Wojownik} | is Kratos: {postac is Kratos} | is Thor: {postac is Thor}");
            }

            return RedirectToPage();
        }

        public IActionResult OnPostReset()
        {
            _gameState.Reset();
            return RedirectToPage();
        }
    }
}