using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealer.Migrations
{
    /// <inheritdoc />
    public partial class DeleteBehaviourRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_FuelType_FuelTypeId",
                table: "Car");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_FuelType_FuelTypeId",
                table: "Car",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_FuelType_FuelTypeId",
                table: "Car");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_FuelType_FuelTypeId",
                table: "Car",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
