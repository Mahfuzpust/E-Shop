using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class ppp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewProducts",
                table: "NewProducts");

            migrationBuilder.RenameTable(
                name: "NewProducts",
                newName: "NewProduct1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewProduct1",
                table: "NewProduct1",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewProduct1",
                table: "NewProduct1");

            migrationBuilder.RenameTable(
                name: "NewProduct1",
                newName: "NewProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewProducts",
                table: "NewProducts",
                column: "Id");
        }
    }
}
