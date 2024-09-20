using BetCyclingFriends.Domains;

namespace BetCyclingFriends.Infrastructures.Repository;

public class UserRepository
{
    private readonly BetCyclingFriendsDbContext _context;
    
    public UserRepository(BetCyclingFriendsDbContext context)
    {
        _context = context;
    }
    
    public bool connectUser(string username, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == username);
        
        if (user == null)
        {
            return false;
        }
        
        return user.HashedPassword == password;
    }


    public void createUser(string username, string password)
    {
        _context.Users.Add(new User
        {
            Username = username,
            HashedPassword = password
        });
        _context.SaveChanges();
    }
}