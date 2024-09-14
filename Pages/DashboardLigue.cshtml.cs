using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages;

public class DashboardLigueModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public DashboardLigueModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}