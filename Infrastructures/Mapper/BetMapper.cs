using BetCyclingFriends.Domains;

namespace BetCyclingFriends.Infrastructures.Mapper;

public static class BetMapper
{
    public static Bet ToDomain(BetData data)
    {
        return new Bet
        {
            Id = data.Id,
            PointsGained = data.PointsGained,
            UserId = data.UserId,
            RaceId = data.RaceId
        };
    }

    public static BetData ToData(Bet domain)
    {
        return new BetData
        {
            Id = domain.Id,
            PointsGained = domain.PointsGained,
            UserId = domain.UserId,
            RaceId = domain.RaceId
        };
    }
}
