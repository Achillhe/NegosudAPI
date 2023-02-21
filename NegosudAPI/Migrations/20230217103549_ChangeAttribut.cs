using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NegosudAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttribut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Types",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "volume",
                table: "Produits",
                newName: "Volume");

            migrationBuilder.RenameColumn(
                name: "typeId",
                table: "Produits",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "reference",
                table: "Produits",
                newName: "Reference");

            migrationBuilder.RenameColumn(
                name: "quantite",
                table: "Produits",
                newName: "Quantite");

            migrationBuilder.RenameColumn(
                name: "prix",
                table: "Produits",
                newName: "Prix");

            migrationBuilder.RenameColumn(
                name: "millesime",
                table: "Produits",
                newName: "Millesime");

            migrationBuilder.RenameColumn(
                name: "nom_de_domaine",
                table: "Produits",
                newName: "NomDomaine");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "Fournisseurs",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "siret",
                table: "Fournisseurs",
                newName: "Siret");

            migrationBuilder.RenameColumn(
                name: "pays",
                table: "Fournisseurs",
                newName: "Pays");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Fournisseurs",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Fournisseurs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "code_postal",
                table: "Fournisseurs",
                newName: "CodePostal");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Collaborateurs",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Collaborateurs",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Collaborateurs",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Collaborateurs",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Collaborateurs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "Clients",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Clients",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Clients",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clients",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "adresse",
                table: "Clients",
                newName: "Adresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Types",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Volume",
                table: "Produits",
                newName: "volume");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Produits",
                newName: "typeId");

            migrationBuilder.RenameColumn(
                name: "Reference",
                table: "Produits",
                newName: "reference");

            migrationBuilder.RenameColumn(
                name: "Quantite",
                table: "Produits",
                newName: "quantite");

            migrationBuilder.RenameColumn(
                name: "Prix",
                table: "Produits",
                newName: "prix");

            migrationBuilder.RenameColumn(
                name: "Millesime",
                table: "Produits",
                newName: "millesime");

            migrationBuilder.RenameColumn(
                name: "NomDomaine",
                table: "Produits",
                newName: "nom_de_domaine");

            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Fournisseurs",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "Siret",
                table: "Fournisseurs",
                newName: "siret");

            migrationBuilder.RenameColumn(
                name: "Pays",
                table: "Fournisseurs",
                newName: "pays");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Fournisseurs",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Fournisseurs",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CodePostal",
                table: "Fournisseurs",
                newName: "code_postal");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Collaborateurs",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Collaborateurs",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Collaborateurs",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Collaborateurs",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Collaborateurs",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Clients",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Clients",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Clients",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Clients",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Clients",
                newName: "adresse");
        }
    }
}
