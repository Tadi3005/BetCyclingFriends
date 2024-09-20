using BetCyclingFriends.Domains;
using BetCyclingFriends.Infrastructures.Data.Configuration;
using Microsoft.EntityFrameworkCore;

public class BetCyclingFriendsDbContext : DbContext
   {
       public BetCyclingFriendsDbContext(DbContextOptions<BetCyclingFriendsDbContext> options) : base(options)
       {
       }
   
       public DbSet<User> Users { get; set; }
       public DbSet<League> Leagues { get; set; }
       public DbSet<LeagueUser> LeagueUsers { get; set; }
       public DbSet<Race> Races { get; set; }
       public DbSet<Bet> Bets { get; set; }
   
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
   
           modelBuilder.ApplyConfiguration(new UserConfiguration());
           modelBuilder.ApplyConfiguration(new LeagueConfiguration());
           modelBuilder.ApplyConfiguration(new RaceConfiguration());
           modelBuilder.ApplyConfiguration(new LeagueUserConfiguration());
           modelBuilder.ApplyConfiguration(new BetConfiguration());
       }
   }
   