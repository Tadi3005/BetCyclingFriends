using BetCyclingFriends.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetCyclingFriends.Infrastructures.Data.Configuration;

public class LeagueUserConfiguration : IEntityTypeConfiguration<LeagueUser>
{
    public void Configure(EntityTypeBuilder<LeagueUser> builder)
    {
        builder.HasKey(lu => new { lu.LeagueId, lu.UserId });

        builder.Property(lu => lu.PointsInLeague)
            .IsRequired();

        // Relations
        builder.HasOne(lu => lu.League)
            .WithMany(l => l.LeageUsers)
            .HasForeignKey(lu => lu.LeagueId);

        builder.HasOne(lu => lu.User)
            .WithMany(u => u.LeagueUsers)
            .HasForeignKey(lu => lu.UserId);
    }
}