using BetCyclingFriends.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetCyclingFriends.Infrastructures.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.Username).IsUnique();

        builder.Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.HashedPassword)
            .IsRequired();

        // Relations
        builder.HasMany(u => u.LeagueUsers)
            .WithOne(lu => lu.User)
            .HasForeignKey(lu => lu.UserId);

        builder.HasMany(u => u.Bets)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);
        
        this.SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<User> builder)
    {
        builder.HasData(new List<User>
        {
            new User
            {
                Id = 1,
                Username = "john_doe",
                HashedPassword = "hashed_password_1"
            },
            new User
            {
                Id = 2,
                Username = "jane_smith",
                HashedPassword = "hashed_password_2"
            },
            new User
            {
                Id = 3,
                Username = "alice_jones",
                HashedPassword = "hashed_password_3"
            },
            new User
            {
                Id = 4,
                Username = "bob_brown",
                HashedPassword = "hashed_password_4"
            },
            new User
            {
                Id = 5, // Ajoutez cet utilisateur
                Username = "charlie_black",
                HashedPassword = "hashed_password_5"
            }
        });
    }
}