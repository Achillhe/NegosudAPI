using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class TypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Produits");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Produits");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Produits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
