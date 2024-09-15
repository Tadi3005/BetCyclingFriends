namespace BetCyclingFriends.Domains;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string HashedPassword { get; set; }

    public ICollection<LeagueUser> LeagueUsers { get; set; }
    public ICollection<Bet> Bets { get; set; }
    
}
