using BetCyclingFriends.Infrastructures.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages
{
    public class Inscription : PageModel
    {
        private readonly UserRepository _userRepository;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string PasswordRepeat { get; set; }
        
        public Inscription(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult OnPost()
        {
            // Vérification des mots de passe
            if (Password != PasswordRepeat)
            {
                ModelState.AddModelError(string.Empty, "Les mots de passe ne correspondent pas.");
            }

            // Vérification de la validité du modèle
            if (!ModelState.IsValid)
            {
                return Page(); // Retourne la page avec les erreurs de validation
            }

            // Si tout est correct, créer l'utilisateur
            _userRepository.createUser(Username, Password);

            // Redirection après inscription réussie
            return RedirectToPage("/Index");
        }
    }
}