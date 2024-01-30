namespace Database.Models
{
  public class Trainer
  {
    public int Id { get; set; }
    public string Name { get; set; } 
    
    //Relations.
    public ICollection<Pokemon> Pokemons { get; set; }
  }
}
