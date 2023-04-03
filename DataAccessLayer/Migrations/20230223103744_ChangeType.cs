using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Clients_ClientId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Produits_ProduitId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Types_TypeId",
                table: "Produits");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Panier",
                table: "Panier");

            migrationBuilder.RenameTable(
                name: "Panier",
                newName: "Paniers");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Produits",
                newName: "SortId");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_TypeId",
                table: "Produits",
                newName: "IX_Produits_SortId");

            migrationBuilder.RenameIndex(
                name: "IX_Panier_ProduitId",
                table: "Paniers",
                newName: "IX_Paniers_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Panier_ClientId",
                table: "Paniers",
                newName: "IX_Paniers_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paniers",
                table: "Paniers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sorts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Paniers_Clients_ClientId",
                table: "Paniers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paniers_Produits_ProduitId",
                table: "Paniers",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Sorts_SortId",
                table: "Produits",
                column: "SortId",
                principalTable: "Sorts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paniers_Clients_ClientId",
                table: "Paniers");

            migrationBuilder.DropForeignKey(
                name: "FK_Paniers_Produits_ProduitId",
                table: "Paniers");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Sorts_SortId",
                table: "Produits");

            migrationBuilder.DropTable(
                name: "Sorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paniers",
                table: "Paniers");

            migrationBuilder.RenameTable(
                name: "Paniers",
                newName: "Panier");

            migrationBuilder.RenameColumn(
                name: "SortId",
                table: "Produits",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_SortId",
                table: "Produits",
                newName: "IX_Produits_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Paniers_ProduitId",
                table: "Panier",
                newName: "IX_Panier_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Paniers_ClientId",
                table: "Panier",
                newName: "IX_Panier_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Panier",
                table: "Panier",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Clients_ClientId",
                table: "Panier",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Produits_ProduitId",
                table: "Panier",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Types_TypeId",
                table: "Produits",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
