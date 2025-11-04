using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class Brand
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public List<Car> Cars { get; } = new();
}
