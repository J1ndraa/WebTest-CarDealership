using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealership.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/uploads/octavia.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/uploads/golf.jpeg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/uploads/bmw.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/uploads/peugeot.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://cdn.skoda-storyboard.com/2020/01/octavia-combi-2020-exterior-front.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://cdn.motor1.com/images/mgl/0x0v1/s1/2020-volkswagen-golf.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://cdn.bmwblog.com/wp-content/uploads/2016/11/BMW-3-Series-F30-320d-M-Sport.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://cdn.motor1.com/images/mgl/Q7jlp/s1/2022-peugeot-3008-hybrid.jpg");
        }
    }
}
