//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace DATA.Migrations
//{
//    public partial class MG1 : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Filiale",
//                columns: table => new
//                {
//                    IdFiliale = table.Column<Guid>(nullable: false),
//                    Labelle = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Filiale", x => x.IdFiliale);
//                });

//            migrationBuilder.CreateTable(
//                name: "Atelier",
//                columns: table => new
//                {
//                    IdAtelier = table.Column<Guid>(nullable: false),
//                    NomAtelier = table.Column<string>(maxLength: 30, nullable: false),
//                    Labelle = table.Column<string>(nullable: true),
//                    FK_Filiale = table.Column<Guid>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Atelier", x => x.IdAtelier);
//                    table.ForeignKey(
//                        name: "FK_Atelier_Filiale_FK_Filiale",
//                        column: x => x.FK_Filiale,
//                        principalTable: "Filiale",
//                        principalColumn: "IdFiliale",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_Atelier_FK_Filiale",
//                table: "Atelier",
//                column: "FK_Filiale");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Atelier");

//            migrationBuilder.DropTable(
//                name: "Filiale");
//        }
//    }
//}
