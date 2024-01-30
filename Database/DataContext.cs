using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Trainer> Trainers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Trainer>(trainer =>
      {
        trainer.HasMany(trainer => trainer.Pokemons)
          .WithOne(pokemon => pokemon.Trainer)
          .HasForeignKey(pokemon => pokemon.TrainerId)
          .OnDelete(DeleteBehavior.Cascade);
      });
    }
  }
}
