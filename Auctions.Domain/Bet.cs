namespace Auctions.Domain;

/// <summary>
/// Ставка на лот
/// </summary>
public class Bet
{
    /// <summary>
    /// Индентификатор ставки
    /// </summary>
    public int Id { get; init; }
    
    /// <summary>
    /// Пользователь сделавший ставку
    /// </summary>
    public int AuthorId { get; init; }
    
    /// <summary>
    /// Индентификатор лота в котором совершена ставка
    /// </summary>
    public int LotId { get; init; }
    
    /// <summary>
    /// Размер ставки
    /// </summary>
    public decimal Amount { get; init; }
    
    /// <summary>
    /// Время ставки
    /// </summary>
    public DateTime DateTime { get; init; }
}