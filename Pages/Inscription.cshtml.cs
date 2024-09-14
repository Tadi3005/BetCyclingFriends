using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages;

public class InscriptionModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public InscriptionModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}