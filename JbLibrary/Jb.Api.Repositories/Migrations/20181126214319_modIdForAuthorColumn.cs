using Microsoft.EntityFrameworkCore.Migrations;

namespace Jb.Api.Repositories.Migrations
{
    public partial class modIdForAuthorColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Authors");
        }
    }
}
