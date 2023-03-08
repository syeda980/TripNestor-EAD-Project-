using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripNestor.Migrations
{
    public partial class AuditHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Hotels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Hotels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedUserId",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "Hotels");
        }
    }
}
