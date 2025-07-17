using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace projetPromamec.Pages.FicheProjet
{
    public class CreateProjectModel : PageModel
    {
        [BindProperty]
        public string Client { get; set; }

        [BindProperty]
        public string Ville { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            // TODO: Ajouter à la base de données ou liste existante
            // Exemple console temporaire
            Console.WriteLine($"Client: {Client}, Ville: {Ville}");
            return RedirectToPage("/Index"); // ou la liste des projets
        }
    }
}