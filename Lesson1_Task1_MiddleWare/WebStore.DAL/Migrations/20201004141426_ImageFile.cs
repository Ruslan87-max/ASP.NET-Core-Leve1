using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.DAL.Migrations
{
    public partial class ImageFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomeField",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ImageFilesId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ImageFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageFilesId",
                table: "Products",
                column: "ImageFilesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ImageFiles_ImageFilesId",
                table: "Products",
                column: "ImageFilesId",
                principalTable: "ImageFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ImageFiles_ImageFilesId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ImageFiles");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImageFilesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageFilesId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "SomeField",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
