using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttribut2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Produits_TypeId",
                table: "Produits",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Types_TypeId",
                table: "Produits",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Types_TypeId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_TypeId",
                table: "Produits");
        }
    }
}
