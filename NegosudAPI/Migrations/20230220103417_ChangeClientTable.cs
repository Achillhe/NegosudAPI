using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Clients",
                newName: "MotDePasse");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Clients",
                newName: "ConfirmationMotDePasse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotDePasse",
                table: "Clients",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "ConfirmationMotDePasse",
                table: "Clients",
                newName: "Adresse");
        }
    }
}
