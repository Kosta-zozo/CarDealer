using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models;
public enum Color
{
    Black,
    Red,
    Blue,
    Green,
    Yellow,
    White,
    Orange
}
public class Car
{
    public int Id { get; set; }
    [Required]
    public int BrandId { get; set; }
    public Brand? Brand { get; set; }
    [Required]
    public int FuelTypeId { get; set; }
    public FuelType? FuelType { get; set; }
    [Required]
    public string Model { get; set; } = string.Empty;
    [Required]
    public Color Color { get; set; }
    [Range(0,int.MaxValue)]
    public int Mileage { get; set; }
    [DataType(DataType.Date)]
    public DateTime ManufacturingDate { get; set; }
    [Required]
    [Precision(18, 2)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
}
