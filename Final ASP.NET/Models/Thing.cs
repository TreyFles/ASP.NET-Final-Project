using System.ComponentModel.DataAnnotations;

namespace Final_ASP.NET.Models
{
  public class Thing
  {
    [Range(1, 10)]
    public int? ID { get; set; }

    [Required]
    public string Color { get; set; }
  }
}