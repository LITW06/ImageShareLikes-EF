using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageShareLikes.Data.Migrations
{
    public partial class AddHighRes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHighRes",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHighRes",
                table: "Images");
        }
    }
}
