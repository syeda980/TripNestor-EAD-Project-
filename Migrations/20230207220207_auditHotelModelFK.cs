using Microsoft.EntityFrameworkCore.Migrations;

namespace TripNestor.Migrations
{
    public partial class auditHotelModelFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_AdminId",
                table: "Hotels",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Admin_AdminId",
                table: "Hotels",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Admin_AdminId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_AdminId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Hotels");
        }
    }
}
