using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripNestor.Migrations
{
    public partial class AuditHotelImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "HotelImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "HotelImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedUserId",
                table: "HotelImages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "HotelImages");
        }
    }
}
