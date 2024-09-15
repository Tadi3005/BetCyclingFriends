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
    }
}