namespace BetCyclingFriends.Infrastructures;

public class UserData
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string HashedPassword { get; set; }

    // Relations
    public ICollection<LeagueUserData> LeagueUsers { get; set; }
    public ICollection<BetData> Bets { get; set; }

    public int TotalPoints { get; set; }
}
