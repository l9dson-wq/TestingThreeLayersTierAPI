using Database.Models;

namespace Application.ViewModels
{
  public class PokemonViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PrimaryType { get; set; } = string.Empty;
    public string SecondaryType { get; set; } = string.Empty;
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
  }
}
