using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GloboTicket.Infrastructure.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Venue",
                newName: "VenueId");

            migrationBuilder.AddColumn<Guid>(
                name: "VenueGuid",
                table: "Venue",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Act",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Show_ShowGuid",
                table: "Show",
                column: "ShowGuid");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Act_ActGuid",
                table: "Act",
                column: "ActGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Show_ShowGuid",
                table: "Show");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Act_ActGuid",
                table: "Act");

            migrationBuilder.DropColumn(
                name: "VenueGuid",
                table: "Venue");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Venue",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Act",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
