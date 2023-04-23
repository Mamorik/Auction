namespace Auctions.Domain;

/// <summary>
///  Пользователь
/// </summary>
public class User
{ 
    /// <summary>
    /// Индентификатор пользователя
    /// </summary>
    public int Id { get; init; }
    
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Почта пользователя
    /// </summary>
    public string Email { get; init; }
}