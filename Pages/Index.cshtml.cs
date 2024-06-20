using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TennisWebApp.Pages;

[IgnoreAntiforgeryToken]
public class IndexModel : PageModel
{
  public IActionResult OnPostPlayerScored([FromBody]PlayerScoreModel playerScore)
  {
    return ViewComponent("TennisScore", new { playerScore.Player });
  }
}

public class PlayerScoreModel
{
  public string Player { get; set; } = string.Empty;
}