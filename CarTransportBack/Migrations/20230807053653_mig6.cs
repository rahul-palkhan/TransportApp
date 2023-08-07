using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTransportBack.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rides_rides_CarId",
                table: "rides");

            migrationBuilder.AddForeignKey(
                name: "FK_rides_cars_CarId",
                table: "rides",
                column: "CarId",
                principalTable: "cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rides_cars_CarId",
                table: "rides");

            migrationBuilder.AddForeignKey(
                name: "FK_rides_rides_CarId",
                table: "rides",
                column: "CarId",
                principalTable: "rides",
                principalColumn: "TripId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
