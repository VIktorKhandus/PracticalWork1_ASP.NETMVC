using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreApp1_2025.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldRating1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Manufacturers");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
