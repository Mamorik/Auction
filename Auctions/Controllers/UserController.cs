using Microsoft.AspNetCore.Mvc;

namespace Auctions.Controllers;

/// <summary>
/// Контроллер для работы с пользователем
/// </summary>
[ApiController]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    /// <summary>
    /// Добавить пользователя
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateUserAsync()
    {
        return Ok();
    }
    
    /// <summary>
    /// Удалить пользователя
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteUserAsync()
    {
        return Ok();
    }
    
    /// <summary>
    /// Изменить пользователя
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateUserAsync()
    {
        return Ok();
    }
    
    /// <summary>
    /// Авторизировать пользователя
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AuthAsync()
    {
        return Ok();
    }
}