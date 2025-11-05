using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class FuelType
{
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
}
