using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetCyclingFriends.Pages;

public class CourseModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public CourseModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}