namespace BetCyclingFriends.Infrastructures;

public class BetData
{
    public int Id { get; set; }
    public string ChosenRider { get; set; }
    public string Bonus { get; set; }
    public int PointsGained { get; set; }

    public int UserId { get; set; }
    public UserData User { get; set; }

    public int RaceId { get; set; }
    public RaceData Race { get; set; }
}
