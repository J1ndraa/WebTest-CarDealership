namespace CarDealership.Models;

public class Vehicle
{
    public int Id {get; set;}
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Kilometers { get; set; }
    public string Fuel  { get; set; }
    public string Body_type { get; set; }
    public string SPZ {get; set;}
    public string Status {get; set;}
    public DateTime? From {get; set;}
    public string Note {get; set;}
    public string? Image { get; set; }

    public Vehicle()
    {}
}