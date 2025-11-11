using Microsoft.EntityFrameworkCore;
using CarDealership.Models;

public class DB_Context : DbContext
{
    public DB_Context(DbContextOptions<DB_Context> options) : base(options) { }

    public DbSet<Vehicle> Vehicles { get; set; }

    //start data examples for the database
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Vehicle>().HasData(
            new Vehicle
            {
                Id = 1,
                Brand = "Škoda",
                Model = "Octavia",
                Year = 2019,
                Kilometers = 84500,
                Fuel = "Benzín",
                Body_type = "Kombi",
                SPZ = "4AN 5623",
                Status = "Dostupné",
                From = new DateTime(2024, 3, 12),
                Note = "Servisní knížka, po prvním majiteli. Vozidlo je v perfektním technickém stavu a nikdy nebylo havarováno.",
                Image = "/uploads/octavia.jpg"
            },
            new Vehicle
            {
                Id = 2,
                Brand = "Volkswagen",
                Model = "Golf",
                Year = 2020,
                Kilometers = 51200,
                Fuel = "Nafta",
                Body_type = "Hatchback",
                SPZ = "2BC 7398",
                Status = "Dostupné",
                From = new DateTime(2024, 5, 1),
                Note = "Automat DSG, pravidelnì servisováno u autorizovaného dealera. Interiér bez známek opotøebení, vùz po nekuøákovi.",
                Image = "/uploads/golf.jpeg"
            },
            new Vehicle
            {
                Id = 3,
                Brand = "BMW",
                Model = "320d",
                Year = 2017,
                Kilometers = 125000,
                Fuel = "Nafta",
                Body_type = "Sedan",
                SPZ = "7AC 4521",
                Status = "Rezervováno",
                From = new DateTime(2024, 2, 22),
                Note = "Sportovní paket M Performance, výborná dynamika a komfortní podvozek. Vozidlo bylo èerstvì po velkém servisu.",
                Image = "/uploads/bmw.jpg"
            },
            new Vehicle
            {
                Id = 4,
                Brand = "Peugeot",
                Model = "3008",
                Year = 2022,
                Kilometers = 18500,
                Fuel = "Hybrid",
                Body_type = "SUV",
                SPZ = "1AF 9810",
                Status = "Dostupné",
                From = new DateTime(2024, 7, 15),
                Note = "Plug-in hybrid s nízkým nájezdem a kompletní výbavou GT Line. Auto v tovární záruce a bez jediné závady.",
                Image = "/uploads/peugeot.jpg"
            }
        );
    }
}
