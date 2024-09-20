using BetCyclingFriends.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetCyclingFriends.Infrastructures.Data.Configuration;

public class RaceConfiguration : IEntityTypeConfiguration<Race>
{
    public void Configure(EntityTypeBuilder<Race> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(r => r.RaceDate)
            .IsRequired();

        builder.Property(r => r.RealWinner)
            .HasMaxLength(100);

        // Relations
        builder.HasMany(r => r.Bets)
            .WithOne(b => b.Race)
            .HasForeignKey(b => b.RaceId);
        
        builder.HasOne(r => r.League)
            .WithMany(l => l.Races)
            .HasForeignKey(r => r.LeagueId);

        
        this.SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<Race> builder)
    {
        builder.HasData(new List<Race>
        {
            new Race
            {
                Id = 1,
                Name = "Stage 1 - Nice",
                RaceDate = new DateTime(2023, 7, 1),
                RealWinner = "Tadej Pogacar",
                LeagueId = 1
            },
            new Race
            {
                Id = 2,
                Name = "Stage 2 - Marseille",
                RaceDate = new DateTime(2023, 7, 2),
                RealWinner = "Primoz Roglic",
                LeagueId = 1
            },
            new Race
            {
                Id = 3,
                Name = "Stage 3 - Lyon",
                RaceDate = new DateTime(2023, 7, 3),
                RealWinner = "Egan Bernal",
                LeagueId = 1
            },
            new Race
            {
                Id = 4,
                Name = "Stage 4 - Paris",
                RaceDate = new DateTime(2023, 7, 4),
                RealWinner = "Chris Froome",
                LeagueId = 1
            },
            new Race
            {
                Id = 5,
                Name = "Stage 1 - Rome",
                RaceDate = new DateTime(2023, 5, 1),
                RealWinner = "Vincenzo Nibali",
                LeagueId = 2
            },
            new Race
            {
                Id = 6,
                Name = "Stage 2 - Florence",
                RaceDate = new DateTime(2023, 5, 2),
                RealWinner = "Fabio Aru",
                LeagueId = 2
            },
            new Race
            {
                Id = 7,
                Name = "Stage 3 - Milan",
                RaceDate = new DateTime(2023, 5, 3),
                RealWinner = "Alberto Contador",
                LeagueId = 2
            },
            new Race
            {
                Id = 8,
                Name = "Stage 4 - Venice",
                RaceDate = new DateTime(2023, 5, 4),
                RealWinner = "Nairo Quintana",
                LeagueId = 2
            }
        });
    }
}