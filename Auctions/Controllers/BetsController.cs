using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

/// <summary>
/// Контроллер для работы со ставками
/// </summary>
[ApiController]
[Route("api/v1/auctions/lots/bets")]
public class BetsController : ControllerBase
{
    /// <summary>
    /// Сделать ставку
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> DoBetAsync()
    {
        return Ok();
    }
}