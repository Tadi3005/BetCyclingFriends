using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages;

public class ModifierParisModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public ModifierParisModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}