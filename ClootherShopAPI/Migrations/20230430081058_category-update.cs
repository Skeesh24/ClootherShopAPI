using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClootherShopAPI.Migrations
{
    public partial class categoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryEntityId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryEntityId",
                table: "Products",
                newName: "CategoryEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryEntityId",
                table: "Products",
                newName: "IX_Products_CategoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryEntityId",
                table: "Products",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryEntityId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryEntityId",
                table: "Products",
                newName: "ProductCategoryEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryEntityId",
                table: "Products",
                newName: "IX_Products_ProductCategoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryEntityId",
                table: "Products",
                column: "ProductCategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
