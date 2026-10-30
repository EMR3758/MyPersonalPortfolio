using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPersonalPortfolio.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageDetail",
                table: "Messages",
                newName: "MessageContent");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Messages",
                newName: "Mail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "Messages",
                newName: "MessageDetail");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Messages",
                newName: "Email");
        }
    }
}
