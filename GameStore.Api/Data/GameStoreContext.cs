using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fighting" },
            new { Id = 2, Name = "Action" },
            new { Id = 3, Name = "Adventure" },
            new { Id = 4, Name = "RPG" },
            new { Id = 5, Name = "Shooter" },
            new { Id = 6, Name = "Platformer" },
            new { Id = 7, Name = "Survival Horror" },
            new { Id = 8, Name = "Strategy" },
            new { Id = 9, Name = "Simulation" },
            new { Id = 10, Name = "Racing" }
        );
    }
}
