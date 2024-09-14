using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages;

public class ParierModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public ParierModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}