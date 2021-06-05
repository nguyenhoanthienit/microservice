using Microsoft.EntityFrameworkCore.Migrations;

namespace Post.Data.Context.Migrations
{
    public partial class updateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryEntity_Posts_PostId",
                table: "CategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity");

            migrationBuilder.RenameTable(
                name: "CategoryEntity",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryEntity_PostId",
                table: "Categories",
                newName: "IX_Categories_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Posts_PostId",
                table: "Categories",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Posts_PostId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_PostId",
                table: "CategoryEntity",
                newName: "IX_CategoryEntity_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryEntity_Posts_PostId",
                table: "CategoryEntity",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
