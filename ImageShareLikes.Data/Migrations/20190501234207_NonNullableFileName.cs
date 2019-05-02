using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageShareLikes.Data.Migrations
{
    public partial class NonNullableFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
