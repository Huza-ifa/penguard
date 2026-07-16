using Microsoft.AspNetCore.Mvc;

namespace GrammarChecker.Controllers;

/// <summary>
/// Lightweight controller — grammar analysis is now handled client-side
/// by calling the LanguageTool API directly from the browser.
/// This avoids server-side internet dependency and is faster.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class GrammarController : ControllerBase
{
    /// <summary>
    /// GET /api/grammar/health
    /// Confirms the ASP.NET Core host is running.
    /// </summary>
    [HttpGet("health")]
    public IActionResult Health() =>
        Ok(new { status = "ok", timestamp = DateTime.UtcNow, note = "Grammar analysis runs client-side via LanguageTool API." });
}
