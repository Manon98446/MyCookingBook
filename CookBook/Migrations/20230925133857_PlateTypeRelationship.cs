using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookBook.Migrations
{
    /// <inheritdoc />
    public partial class PlateTypeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<int>(
                name: "PlateTypePlateId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlateTypes",
                columns: table => new
                {
                    PlateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlateName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateTypes", x => x.PlateId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_PlateTypePlateId",
                table: "Recipes",
                column: "PlateTypePlateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_PlateTypes_PlateTypePlateId",
                table: "Recipes",
                column: "PlateTypePlateId",
                principalTable: "PlateTypes",
                principalColumn: "PlateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_PlateTypes_PlateTypePlateId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "PlateTypes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_PlateTypePlateId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PlateId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PlateTypePlateId",
                table: "Recipes");
        }
    }
}
