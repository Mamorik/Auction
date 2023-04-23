namespace Auctions.Domain;

/// <summary>
/// Статут лота
/// </summary>
public enum LotStatus
{
    /// <summary>
    /// Идут торги
    /// </summary>
    Bidding = 0,
    /// <summary>
    /// Торги завершены
    /// </summary>
    Complete = 1
}