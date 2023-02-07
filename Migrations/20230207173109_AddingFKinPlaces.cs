using Microsoft.EntityFrameworkCore.Migrations;

namespace TripNestor.Migrations
{
    public partial class AddingFKinPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Places_AdminId",
                table: "Places",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Admin_AdminId",
                table: "Places",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Admin_AdminId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_AdminId",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Places");
        }
    }
}
