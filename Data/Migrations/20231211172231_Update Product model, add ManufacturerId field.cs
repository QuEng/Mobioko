using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobioko.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductmodeladdManufacturerIdfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Products",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Products");
        }
    }
}
