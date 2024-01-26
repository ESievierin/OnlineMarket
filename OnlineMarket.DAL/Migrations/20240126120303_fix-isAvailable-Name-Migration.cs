using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMarket.DAL.Migrations
{
    public partial class fixisAvailableNameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsАvailable",
                table: "Goods",
                newName: "IsAvailable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Goods",
                newName: "IsАvailable");
        }
    }
}
