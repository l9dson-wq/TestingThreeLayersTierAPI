using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
  public class PokemonRepository
  {
    private readonly DataContext _dbContext;
    public PokemonRepository(DataContext dbContext)
    {
      _dbContext = dbContext;
    }

    // Create
    public async Task AddAsync(Pokemon pokemon)
    {
      await _dbContext.Pokemons.AddAsync(pokemon);
      await _dbContext.SaveChangesAsync();
    }

    // Read
    public async Task<List<Pokemon>> GetAllAsync()
    {
      var pokemons = await _dbContext.Set<Pokemon>().ToListAsync();
      return pokemons;
    }

    // update
    public async Task UpdateAsync(Pokemon pokemon)
    {
      _dbContext.Entry(pokemon).State = EntityState.Modified;
      await _dbContext.SaveChangesAsync();
    }

    // Delete
    public async Task DeleteAsync(Pokemon pokemon)
    {
      _dbContext.Pokemons.Remove(pokemon);
      await _dbContext.SaveChangesAsync();
    }

    // Get by Id
    public async Task<Pokemon> GetByIdAsync(int id)
    {
      return await _dbContext.Pokemons.FindAsync(id);
    }
  }
}
