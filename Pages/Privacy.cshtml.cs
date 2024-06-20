using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TennisWebApp.Pages;

public class PrivacyModel : PageModel
{
  private readonly ILogger<PrivacyModel> _logger;

  public PrivacyModel(ILogger<PrivacyModel> logger)
  {
    _logger = logger;
  }

  public void OnGet() { }
}