using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTransportBack.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_rides_CarId",
                table: "rides",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_rides_UserId",
                table: "rides",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_rides_rides_CarId",
                table: "rides",
                column: "CarId",
                principalTable: "rides",
                principalColumn: "TripId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_rides_users_UserId",
                table: "rides",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rides_rides_CarId",
                table: "rides");

            migrationBuilder.DropForeignKey(
                name: "FK_rides_users_UserId",
                table: "rides");

            migrationBuilder.DropIndex(
                name: "IX_rides_CarId",
                table: "rides");

            migrationBuilder.DropIndex(
                name: "IX_rides_UserId",
                table: "rides");
        }
    }
}
