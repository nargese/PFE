//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace DATA.Migrations
//{
//    public partial class MG2 : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Station",
//                columns: table => new
//                {
//                    IdStation = table.Column<Guid>(nullable: false),
//                    NomStation = table.Column<string>(maxLength: 30, nullable: false),
//                    Code = table.Column<string>(nullable: true),
//                    Capacite = table.Column<int>(nullable: false),
//                    TypeStation = table.Column<string>(nullable: true),
//                    FK_Atelier = table.Column<Guid>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Station", x => x.IdStation);
//                    table.ForeignKey(
//                        name: "FK_Station_Atelier_FK_Atelier",
//                        column: x => x.FK_Atelier,
//                        principalTable: "Atelier",
//                        principalColumn: "IdAtelier",
//                        onDelete: ReferentialAction.Cascade);
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_Station_FK_Atelier",
//                table: "Station",
//                column: "FK_Atelier");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Station");
//        }
//    }
//}
