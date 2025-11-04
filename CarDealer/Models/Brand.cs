using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class Brand
{
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
    public List<Car> Cars { get; } = new();
}
