using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class Demo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Foods_ID",
                table: "Reviews");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FoodID",
                table: "Reviews",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Foods_FoodID",
                table: "Reviews",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Foods_FoodID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_FoodID",
                table: "Reviews");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Foods_ID",
                table: "Reviews",
                column: "ID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
