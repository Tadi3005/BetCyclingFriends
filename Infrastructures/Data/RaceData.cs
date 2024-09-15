namespace BetCyclingFriends.Infrastructures;

public class RaceData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime RaceDate { get; set; }

    public string RealWinner { get; set; }

    public int LeagueId { get; set; }
    public LeagueData League { get; set; }

    public ICollection<BetData> Bets { get; set; }
}
