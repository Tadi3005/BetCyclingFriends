using BetCyclingFriends.Domains;

namespace BetCyclingFriends.Infrastructures.Mapper;

public static class LeagueMapper
{
    public static League ToDomain(LeagueData data)
    {
        return new League
        {
            Id = data.Id,
            Name = data.Name,
        };
    }

    public static LeagueData ToData(League domain)
    {
        return new LeagueData
        {
            Id = domain.Id,
            Name = domain.Name
        };
    }
}
