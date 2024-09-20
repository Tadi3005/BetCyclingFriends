using BetCyclingFriends.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetCyclingFriends.Infrastructures.Data.Configuration;

public class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        builder.HasKey(l => l.Id);

        builder.HasIndex(l => l.Password).IsUnique();

        builder.Property(l => l.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.Password)
            .IsRequired()
            .HasMaxLength(6);

        // Relations
        builder.HasMany(l => l.LeageUsers)
            .WithOne(lu => lu.League)
            .HasForeignKey(lu => lu.LeagueId);

        builder.HasMany(l => l.Races)
            .WithOne(r => r.League)
            .HasForeignKey(r => r.LeagueId);
        
        this.SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<League> builder)
    {
        builder.HasData(new List<League>
            {
                new League
                {
                    Id = 1,
                    Name = "League 1",
                    Password = "123456"
                },
                new League
                {
                    Id = 2,
                    Name = "League 2",
                    Password = "654321"
                }
            });
    }
}