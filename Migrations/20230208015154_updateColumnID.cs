using Microsoft.EntityFrameworkCore.Migrations;

namespace TripNestor.Migrations
{
    public partial class updateColumnID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hotels",
                newName: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Hotels",
                newName: "Id");
        }
    }
}
