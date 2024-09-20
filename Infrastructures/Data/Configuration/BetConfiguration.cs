using BetCyclingFriends.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetCyclingFriends.Infrastructures.Data.Configuration;

public class BetConfiguration : IEntityTypeConfiguration<Bet>
{
    public void Configure(EntityTypeBuilder<Bet> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.FavoriRider)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(b => b.BonusRider)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(b => b.PointsGained)
            .IsRequired();

        // Relations
        builder.HasOne(b => b.User)
            .WithMany(u => u.Bets)
            .HasForeignKey(b => b.UserId);

        builder.HasOne(b => b.Race)
            .WithMany(r => r.Bets)
            .HasForeignKey(b => b.RaceId);
        
        this.SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<Bet> builder)
    {
        builder.HasData(new List<Bet>
        {
            new Bet
            {
                Id = 1,
                FavoriRider = "Tadej Pogacar",
                BonusRider = "Primoz Roglic",
                PointsGained = 100,
                UserId = 1,
                RaceId = 1
            },
        });
    }
}