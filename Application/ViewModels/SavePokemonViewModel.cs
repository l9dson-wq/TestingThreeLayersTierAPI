using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
  public class SavePokemonViewModel
  {
    public int Id { get; set; }

    [Required, MinLength(5, ErrorMessage = "You must use more than 5 characters for this field."),
      MaxLength(20, ErrorMessage = "You have a maximum of 30 characters for this field.")]
    [DataType(DataType.Text, ErrorMessage = "You must use Text inside of this.")]
    public string Name { get; set; } = string.Empty;

    [Required, MinLength(5, ErrorMessage = "You must use more than 5 characters for this field."),
      MaxLength(30, ErrorMessage = "You have a maximum of 30 characters for this field.")]
    [DataType(DataType.Text, ErrorMessage = "You must use Text inside of this.")]
    public string PrimaryType { get; set; } = string.Empty;

    [Required, MinLength(5, ErrorMessage = "You must use more than 5 characters for this field."),
      MaxLength(30, ErrorMessage = "You have a maximum of 30 characters for this field.")]
    [DataType(DataType.Text, ErrorMessage = "You must use Text inside of this.")]
    public string SecondaryType { get; set; } = string.Empty;

    [Required]
    [RegularExpression("([1-9][0-9])",
      ErrorMessage = "You must use a number either bigger than 0 and not a decimal number.")]
    public int TrainerId { get; set; }
  }
}
