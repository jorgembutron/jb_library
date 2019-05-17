using Microsoft.EntityFrameworkCore.Migrations;

namespace Jb.Api.Repositories.Migrations
{
    public partial class deleteTestCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Authors",
                nullable: true);
        }
    }
}
