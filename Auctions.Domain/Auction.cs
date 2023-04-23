namespace Auctions.Domain;

/// <summary>
/// Аукицон
/// </summary>
public class Auction
{
    /// <summary>
    /// Индентификатор аукциона
    /// </summary>
    public int Id { get; init; }
    
    /// <summary>
    /// Название аукциона
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Индентификатор пользователя создавшего аукицон
    /// </summary>
    public int AuthorId { get; init; }
    
    /// <summary>
    /// Дата начала аукциона
    /// </summary>
    public DateTime DateStart { get; init; }
    
    /// <summary>
    /// Флаг, оформляется ли он сейчас
    /// </summary>
    public bool IsCreation { get; init; }

    private  DateTime _dateEnd;
    
    /// <summary>
    /// Дата завершения аукицона
    /// </summary>
    public DateTime DateEnd
    {
        get
        {
            // Логика автопродления аукциона, если ставка сделана за 30 или менее секунд до конца аукциона продлеваем его на 30 сек
            // воиисбежание ситуаций когда пользователи пытются сделать ставку под конец аукциона
            var maxBetDate = Lots.Values.SelectMany(l => l.Bets).Max(s => s.DateTime).AddSeconds(30);

            return _dateEnd > maxBetDate ? _dateEnd : maxBetDate;
        }
        init => _dateEnd = value;
    }
    
    /// <summary>
    /// Статус аукциона
    /// </summary>
    public AuctionStatus Status
    {
        get
        {
            var dateTimeNow = DateTime.UtcNow;
            
            if (IsCreation)
                return AuctionStatus.Creation;

            if (dateTimeNow > DateStart && dateTimeNow < DateEnd)
                return AuctionStatus.Bidding;

            if (dateTimeNow < DateStart)
                return AuctionStatus.WaitBidding;
            
            return AuctionStatus.Complete;
        }
    }

    /// <summary>
    /// Список активых лотов на аукционе
    /// </summary>
    public Dictionary<int, Lot> Lots { get; init; } = new();
}