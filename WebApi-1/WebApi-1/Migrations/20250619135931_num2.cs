using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_1.Migrations
{
    /// <inheritdoc />
    public partial class num2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item",
                table: "Items");
        }
    }
}
