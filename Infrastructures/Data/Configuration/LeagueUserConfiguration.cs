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
        
        this.SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<LeagueUser> builder)
    {
        builder.HasData(new List<LeagueUser>
            {
                new LeagueUser
                {
                    LeagueId = 1,
                    UserId = 1,
                    PointsInLeague = 100
                },
                new LeagueUser
                {
                    LeagueId = 1,
                    UserId = 2,
                    PointsInLeague = 200
                },
                new LeagueUser
                {
                    LeagueId = 2,
                    UserId = 1,
                    PointsInLeague = 300
                },
                new LeagueUser
                {
                    LeagueId = 2,
                    UserId = 2,
                    PointsInLeague = 400
                }
            });
    }
}