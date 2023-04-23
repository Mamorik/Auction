namespace Auctions.Domain;

/// <summary>
///  Лот
/// </summary>
public class Lot
{
    /// <summary>
    ///  Индентификатор лота
    /// </summary>
    public int Id { get; init; }
    
    /// <summary>
    /// Название лота
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Описание лота
    /// </summary>
    public string Description { get; init; }
    
    /// <summary>
    ///  Статут лота
    /// </summary>
    public LotStatus Status { get; init; }
    
    /// <summary>
    /// Список ставок
    /// </summary>
    public List<Bet> Bets { get; init; }
    
    /// <summary>
    /// Картинки лота
    /// </summary>
    public ICollection<string> Images { get; init; }
}