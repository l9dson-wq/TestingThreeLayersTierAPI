using Database.Models;

namespace Application.ViewModels
{
  public class TrainerViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Pokemon> Pokemons { get; set; }
  }
}
