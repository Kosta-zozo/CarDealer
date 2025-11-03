using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;

public class BrandElectricCarCount
{
    public int BrandId { get; set; }
    public string BrandName { get; set; }
    public int CarCount { get; set; }
}
