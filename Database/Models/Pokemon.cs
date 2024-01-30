namespace Database.Models
{
  public class Pokemon
  {
    public int Id { get; set; }
    public string  Name { get; set; }
    public string PrimaryType { get; set; }
    public string SecondaryType { get; set; } 

    // Relations.
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
  }
}
