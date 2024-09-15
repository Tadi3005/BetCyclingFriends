namespace BetCyclingFriends.Domains;

public class RaceResult
{
    public int Id { get; set; }
    public string RiderName { get; set; }
    public int Position { get; set; }

    public int RaceId { get; set; }
    public Race Race { get; set; }
}
