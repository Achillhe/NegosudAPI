using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class version13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codepostal = table.Column<int>(name: "code_postal", type: "int", nullable: false),
                    pays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    siret = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fournisseurs");
        }
    }
}
