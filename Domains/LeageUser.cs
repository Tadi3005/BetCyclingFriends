namespace BetCyclingFriends.Domains;

public class LeagueUser
{
    public int LeagueId { get; set; }
    public League League { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int PointsInLeague { get; set; }
}
