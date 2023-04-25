using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

/// <summary>
/// Контроллер для работы с лотом
/// </summary>
[ApiController]
[Route("api/v1/auctions/lots")]
public class LotsController : ControllerBase
{
    /// <summary>
    /// Создание лота аукциона
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateLotAsync()
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаление лота с аукциона
    /// </summary>
    /// <param name="id">Индентификатор лота</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteLotAsync(int id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Изменение лота на аукционе
    /// </summary>
    /// <param name="id">Индентификатор лота на аукционе</param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateLtAsync(int id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Получение спика лотов по индентификатору аукциона
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetLotsBAuctionsIdAsync([FromQuery] int auctionsId)
    {
        return Ok();
    }
}