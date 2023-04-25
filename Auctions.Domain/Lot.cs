using FluentResults;

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
    /// Код лота
    /// </summary>
    public string Code { get; init; }
    
    /// <summary>
    /// Описание лота
    /// </summary>
    public string Description { get; init; }
    
    /// <summary>
    ///  Статут лота
    /// </summary>
    public LotStatus Status { get; init; }

    
    private List<Bet> _bets = new List<Bet>();
    
    /// <summary>
    /// Список ставок
    /// </summary>
    public IReadOnlyCollection<Bet> Bets => _bets;

    /// <summary>
    /// Картинки лота
    /// </summary>
    public IReadOnlyCollection<string> Images { get; init; } = new List<string>();

    /// <summary>
    /// Попытка сделать ставку
    /// </summary>
    /// <param name="bet">Ставка</param>
    /// <returns>Результат выполнения операция. Если по лоту торги завершены или ставка с таким размером сделана то выдаст Fail</returns>
    public Result TryDoBet(Bet bet)
    {
        if (Status == LotStatus.Complete)
            return Result.Fail("На данный лот невозможно сделать ставку, так как торги завершены");

        if (_bets.Any(b => b.Amount <= bet.Amount))
            return Result.Fail("Ваша ставка была перекрыта, пожалуйста повторите попытку");
        
        _bets.Add(bet);
        return Result.Ok();
    }
}