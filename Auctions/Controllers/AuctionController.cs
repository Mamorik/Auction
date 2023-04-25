using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

/// <summary>
/// контроллер для работы с аукционом
/// </summary>
[ApiController]
[Route("api/v1/auctions")]
public class AuctionController : ControllerBase
{
    /// <summary>
    /// Создание аукицона
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateAuctionAsync()
    {
        return Ok();
    }
    
    /// <summary>
    /// Отмена аукциона
    /// </summary>
    /// <param name="id">Индентификатор аукциона</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> CancekAuctionAsync(int id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Обновление аукциона
    /// </summary>
    /// <param name="id">Индентификатор аукицона</param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateActionAsync(int id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Отображение аукциона
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAuctionsAsync()
    {
        return Ok();
    }
    
}