using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class mg12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

         

            migrationBuilder.DropColumn(
                name: "FK_Bassin",
                table: "SourceDeau");

            migrationBuilder.DropColumn(
                name: "FK_Puit",
                table: "SourceDeau");

     

          

        

           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<Guid>(
                name: "FK_Bassin",
                table: "SourceDeau",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FK_Puit",
                table: "SourceDeau",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

      

           
        }
    }
}
