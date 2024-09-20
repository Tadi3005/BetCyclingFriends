using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BetCyclingFriends.Infrastructures.Repository;  // Assurez-vous d'inclure cette ligne pour utiliser le UserRepository

namespace BetCyclingFriends.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserRepository _userRepository;  // Injectez le UserRepository

        [BindProperty]
        public string Username { get; set; }  // Ces propriétés sont liées au formulaire
        [BindProperty]
        public string Password { get; set; }

        public IndexModel(ILogger<IndexModel> logger, UserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Utilisez le UserRepository pour vérifier les informations de connexion
            if (_userRepository.connectUser(Username, Password))
            {
                // Si la connexion est réussie, rediriger vers une autre page
                return RedirectToPage("/Ligue");
            }
            else
            {
                // Si la connexion échoue, ajoutez un message d'erreur et restez sur la même page
                ModelState.AddModelError(string.Empty, "Nom d'utilisateur ou mot de passe incorrect");
                return Page();
            }
        }
    }
}