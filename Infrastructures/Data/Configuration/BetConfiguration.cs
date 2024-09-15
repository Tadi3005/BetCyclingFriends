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
    }
}