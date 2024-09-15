namespace BetCyclingFriends.Domains;

public class Bet
{
    public int Id { get; set; }
    
    public string FavoriRider { get; set; }

    public string BonusRider { get; set; }

    public int PointsGained { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int RaceId { get; set; }
    public Race Race { get; set; }
}
