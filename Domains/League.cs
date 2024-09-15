namespace BetCyclingFriends.Domains;

public class League
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Password { get; set; }
    
    public List<LeagueUser> LeageUsers { get; set; }
    
    public List<Race> Races { get; set; }
}