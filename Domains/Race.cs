namespace BetCyclingFriends.Domains;

public class Race
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime RaceDate { get; set; }

    public string RealWinner { get; set; }

    public int LeagueId { get; set; }
    public League League { get; set; }

    public ICollection<Bet> Bets { get; set; }
}
