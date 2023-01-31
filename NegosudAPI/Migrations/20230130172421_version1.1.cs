using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class version11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomdedomaine = table.Column<string>(name: "nom_de_domaine", type: "nvarchar(max)", nullable: false),
                    reference = table.Column<int>(type: "int", nullable: false),
                    quantite = table.Column<int>(type: "int", nullable: false),
                    prix = table.Column<float>(type: "real", nullable: false),
                    volume = table.Column<float>(type: "real", nullable: false),
                    millesime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
