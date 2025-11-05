using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class BrandsWithCount
{
    public int BrandId { get; set; }
    public required string BrandName { get; set; }
    public int CarCount { get; set; }
}
