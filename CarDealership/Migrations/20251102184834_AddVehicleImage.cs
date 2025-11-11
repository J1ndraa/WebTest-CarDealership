using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Vehicles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Body_type", "Brand", "From", "Fuel", "Image", "Kilometers", "Model", "Note", "SPZ", "Status", "Year" },
                values: new object[,]
                {
                    { 1, "Kombi", "Škoda", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benzín", "https://cdn.skoda-storyboard.com/2020/01/octavia-combi-2020-exterior-front.jpg", 84500, "Octavia", "Servisní knížka, po prvním majiteli. Vozidlo je v perfektním technickém stavu a nikdy nebylo havarováno.", "4AN 5623", "Dostupné", 2019 },
                    { 2, "Hatchback", "Volkswagen", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nafta", "https://cdn.motor1.com/images/mgl/0x0v1/s1/2020-volkswagen-golf.jpg", 51200, "Golf", "Automat DSG, pravidelně servisováno u autorizovaného dealera. Interiér bez známek opotřebení, vůz po nekuřákovi.", "2BC 7398", "Dostupné", 2020 },
                    { 3, "Sedan", "BMW", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nafta", "https://cdn.bmwblog.com/wp-content/uploads/2016/11/BMW-3-Series-F30-320d-M-Sport.jpg", 125000, "320d", "Sportovní paket M Performance, výborná dynamika a komfortní podvozek. Vozidlo bylo čerstvě po velkém servisu.", "7AC 4521", "Rezervováno", 2017 },
                    { 4, "SUV", "Peugeot", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hybrid", "https://cdn.motor1.com/images/mgl/Q7jlp/s1/2022-peugeot-3008-hybrid.jpg", 18500, "3008", "Plug-in hybrid s nízkým nájezdem a kompletní výbavou GT Line. Auto v tovární záruce a bez jediné závady.", "1AF 9810", "Dostupné", 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicles");
        }
    }
}
