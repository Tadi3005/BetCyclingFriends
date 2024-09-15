namespace BetCyclingFriends.Infrastructures;

public class LeagueUserData
{
    public int LeagueId { get; set; }
    public LeagueData League { get; set; }

    public int UserId { get; set; }
    public UserData User { get; set; }

    public int PointsInLeague { get; set; }
}
