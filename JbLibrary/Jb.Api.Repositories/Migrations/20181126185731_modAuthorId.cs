using Microsoft.EntityFrameworkCore.Migrations;

namespace Jb.Api.Repositories.Migrations
{
    public partial class modAuthorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "AuthorId");
        }
    }
}
