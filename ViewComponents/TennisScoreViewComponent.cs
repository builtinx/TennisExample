using Microsoft.AspNetCore.Mvc;
using TennisWebApp.Services;

namespace TennisWebApp.ViewComponents;

public class TennisScoreViewComponent(ITennisGame game) : ViewComponent
{
  public IViewComponentResult Invoke(string? player)
  {
    if (player != null)
    {
      game.WonPoint(player);
    }
    string score = game.GetScore();
    ScoreViewModel model = new() { Score = score};
    return View(model);
  }
}
public class ScoreViewModel
{
  public string Score { get; set; } = string.Empty;
}