using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class UrlUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Docs_Url",
                table: "Docs",
                column: "Url",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Docs_Url",
                table: "Docs");
        }
    }
}
