using Microsoft.EntityFrameworkCore.Migrations;

namespace MySciptureJournal.Migrations
{
    public partial class Chapter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chapter",
                table: "Scripture",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "Scripture");
        }
    }
}
