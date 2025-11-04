using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class BrandsWithCount
{
    public int BrandId { get; set; }
    [Required]
    public string BrandName { get; set; }
    [Required]
    public int CarCount { get; set; }
}
