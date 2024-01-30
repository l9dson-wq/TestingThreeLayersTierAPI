using Application.Repositories;
using Application.ViewModels;
using Database;
using Database.Models;

namespace Application.Services
{
  public class PokemonService
  {
    private readonly PokemonRepository _pokemonRepository;

    public PokemonService(DataContext dataContext)
    {
      _pokemonRepository = new(dataContext);
    }

    // Create
    public async Task Add(SavePokemonViewModel savePokemonViewModel)
    {
      var pokemon = new Pokemon
      {
        Name = savePokemonViewModel.Name,
        PrimaryType = savePokemonViewModel.PrimaryType,
        SecondaryType = savePokemonViewModel.SecondaryType,
        TrainerId = 1,
      };

      await _pokemonRepository.AddAsync(pokemon);
    }

    // Read
    public async Task<List<PokemonViewModel>> GetAll()
    {
      var pokemons = await _pokemonRepository.GetAllAsync();

      return pokemons.Select(pokemon => new PokemonViewModel
      {
        Id = pokemon.Id,
        Name = pokemon.Name,
        PrimaryType = pokemon.PrimaryType,
        SecondaryType = pokemon.SecondaryType,
        TrainerId = pokemon.TrainerId,
      }).ToList();
    }

    // Update
    public async Task Update(SavePokemonViewModel savePokemonViewModel)
    {
      var pokemon = new Pokemon
      {
        Id = savePokemonViewModel.Id,
        Name = savePokemonViewModel.Name,
        PrimaryType = savePokemonViewModel.PrimaryType,
        SecondaryType = savePokemonViewModel.SecondaryType,
        TrainerId = 1,
      };

      await _pokemonRepository.UpdateAsync(pokemon);
    }

    // Delete
    public async Task Delete(int Id)
    {
      var pokemon = await _pokemonRepository.GetByIdAsync(Id);

      await _pokemonRepository.DeleteAsync(pokemon);
    }

    // Get By Id
    public async Task<PokemonViewModel> GetById(int Id)
    {
      var pokemon = await _pokemonRepository.GetByIdAsync(Id);

      return new PokemonViewModel
      {
        Id = pokemon.Id,
        Name = pokemon.Name,
        PrimaryType = pokemon.PrimaryType,
        SecondaryType = pokemon.SecondaryType,
        TrainerId = pokemon.TrainerId,
      };
    }
  }
}
