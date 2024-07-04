using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommnetStatus",
                table: "Comments",
                newName: "CommentStatus");

            migrationBuilder.RenameColumn(
                name: "CommnetContent",
                table: "Comments",
                newName: "CommentContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentStatus",
                table: "Comments",
                newName: "CommnetStatus");

            migrationBuilder.RenameColumn(
                name: "CommentContent",
                table: "Comments",
                newName: "CommnetContent");
        }
    }
}
