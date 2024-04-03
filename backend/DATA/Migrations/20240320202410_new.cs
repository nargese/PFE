using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Compte",
                columns: table => new
                {
                    IdCompte = table.Column<Guid>(nullable: false),
                    Motdepasse = table.Column<string>(nullable: true),
                    CIN = table.Column<string>(maxLength: 8, nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    access = table.Column<bool>(nullable: false),
                    FK_Role = table.Column<Guid>(nullable: false),
                    FK_Filiale = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compte", x => x.IdCompte);
                    table.ForeignKey(
                        name: "FK_Compte_Filiale_FK_Filiale",
                        column: x => x.FK_Filiale,
                        principalTable: "Filiale",
                        principalColumn: "IdFiliale",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compte_Role_FK_Role",
                        column: x => x.FK_Role,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compte_FK_Filiale",
                table: "Compte",
                column: "FK_Filiale");

            migrationBuilder.CreateIndex(
                name: "IX_Compte_FK_Role",
                table: "Compte",
                column: "FK_Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compte");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
