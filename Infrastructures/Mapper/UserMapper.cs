using BetCyclingFriends.Domains;

namespace BetCyclingFriends.Infrastructures.Mapper;

public static class UserMapper
{
    public static User ToDomain(UserData data)
    {
        return new User
        {
            Id = data.Id,
            Username = data.Username,
            // Autres propriétés et relations peuvent être mappées ici
        };
    }

    public static UserData ToData(User domain)
    {
        return new UserData
        {
            Id = domain.Id,
            Username = domain.Username,
            // Autres propriétés et relations peuvent être mappées ici
        };
    }
}
