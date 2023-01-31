using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class version12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "Clients");
        }
    }
}
