using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SebastianPossisFinalProjComputerStore.Migrations
{
    /// <inheritdoc />
    public partial class SeedComputerPartsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComputerParts",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 4, "High-performance GPU", "Graphics Card", 399.99m, 10 },
                    { 5, "Quad-core CPU", "Processor", 299.99m, 15 },
                    { 6, "16GB DDR4", "RAM", 79.99m, 25 },
                    { 7, "512GB NVMe SSD", "SSD", 119.99m, 20 },
                    { 8, "ATX Motherboard", "Motherboard", 149.99m, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComputerParts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComputerParts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ComputerParts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ComputerParts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ComputerParts",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
