using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PokemonController : ControllerBase
  {
    private readonly PokemonService _pokemonService;

    public PokemonController(DataContext dataContext)
    {
      _pokemonService = new(dataContext);
    }

    // Create.
    [HttpPost]
    [Route("[Action]")]
    public async Task<IActionResult> AddPokemon(SavePokemonViewModel savePokemonViewModel)
    {
      try
      {
        await _pokemonService.Add(savePokemonViewModel);

        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    // Read.
    [HttpGet]
    [Route("[Action]")]
    public async Task<IActionResult> GetAllPokemon()
    {
      try
      {
        var pokemons = await _pokemonService.GetAll();

        return Ok(pokemons);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    // Update.
    [HttpPut]
    [Route("[Action]")]
    public async Task<IActionResult> EditPokemon(SavePokemonViewModel savePokemonViewModel)
    {
      try
      {
        await _pokemonService.Update(savePokemonViewModel);

        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    // Delete.
    [HttpDelete]
    [Route("[Action]")]
    public async Task<IActionResult> DeletePokemon(int id)
    {
      try
      {
        await _pokemonService.Delete(id);

        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    //Get by Id.
    [HttpPost]
    [Route("[Action]")]
    public async Task<IActionResult> GetById(int Id)
    {
      try
      {
        var pokemon = await _pokemonService.GetById(Id);

        return Ok(pokemon);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
