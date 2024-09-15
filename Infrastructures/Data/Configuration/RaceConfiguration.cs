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
    }
}