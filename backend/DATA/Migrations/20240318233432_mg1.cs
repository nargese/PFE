using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorieProduitChimique",
                columns: table => new
                {
                    IdCategorie = table.Column<Guid>(nullable: false),
                    NomCategorie = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieProduitChimique", x => x.IdCategorie);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    IdFournisseur = table.Column<Guid>(nullable: false),
                    FournisseurNom = table.Column<string>(nullable: true),
                    FournisseurCode = table.Column<string>(nullable: true),
                    FournisseurPhoneNumber = table.Column<int>(nullable: true),
                    FournisseurFaxNumber = table.Column<int>(nullable: true),
                    FournisseurEmail = table.Column<string>(nullable: true),
                    ProviderAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.IdFournisseur);
                });

            migrationBuilder.CreateTable(
                name: "SourceDeau",
                columns: table => new
                {
                    IdSourceDeau = table.Column<Guid>(nullable: false),
                    QuantiteDeau = table.Column<double>(nullable: false),
                    FK_Bassin = table.Column<Guid>(nullable: false),
                    FK_Puit = table.Column<Guid>(nullable: false),
                    FK_Filiale = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    NomBassin = table.Column<string>(maxLength: 30, nullable: true),
                    Profondeur = table.Column<double>(nullable: true),
                    NomPuit = table.Column<string>(nullable: true),
                    AmortissementType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceDeau", x => x.IdSourceDeau);
                    table.ForeignKey(
                        name: "FK_SourceDeau_Filiale_FK_Filiale",
                        column: x => x.FK_Filiale,
                        principalTable: "Filiale",
                        principalColumn: "IdFiliale",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeCartouche",
                columns: table => new
                {
                    IdTypeCartouche = table.Column<Guid>(nullable: false),
                    NomCartouche = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCartouche", x => x.IdTypeCartouche);
                });

            migrationBuilder.CreateTable(
                name: "TypeMembrane",
                columns: table => new
                {
                    IdTypeMembrane = table.Column<Guid>(nullable: false),
                    NomMembrane = table.Column<string>(maxLength: 30, nullable: false),
                    TypeMembraneLabel = table.Column<string>(nullable: true),
                    TypeMembraneSize = table.Column<double>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeMembrane", x => x.IdTypeMembrane);
                });

            migrationBuilder.CreateTable(
                name: "ProduitChimique",
                columns: table => new
                {
                    IdProduitChimique = table.Column<Guid>(nullable: false),
                    ProduitChimiqueLabel = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FK_CategorieProduitChimique = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitChimique", x => x.IdProduitChimique);
                    table.ForeignKey(
                        name: "FK_ProduitChimique_CategorieProduitChimique_FK_CategorieProduitChimique",
                        column: x => x.FK_CategorieProduitChimique,
                        principalTable: "CategorieProduitChimique",
                        principalColumn: "IdCategorie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProduitChimique_FK_CategorieProduitChimique",
                table: "ProduitChimique",
                column: "FK_CategorieProduitChimique");

            migrationBuilder.CreateIndex(
                name: "IX_SourceDeau_FK_Filiale",
                table: "SourceDeau",
                column: "FK_Filiale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "ProduitChimique");

            migrationBuilder.DropTable(
                name: "SourceDeau");

            migrationBuilder.DropTable(
                name: "TypeCartouche");

            migrationBuilder.DropTable(
                name: "TypeMembrane");

            migrationBuilder.DropTable(
                name: "CategorieProduitChimique");
        }
    }
}
