namespace BetCyclingFriends.Infrastructures;

public class LeagueData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }

    // Relations
    public ICollection<LeagueUserData> LeagueUsers { get; set; }
    public ICollection<RaceData> Races { get; set; }
}
