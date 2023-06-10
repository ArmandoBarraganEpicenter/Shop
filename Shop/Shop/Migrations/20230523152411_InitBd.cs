using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class InitBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_State_Name_CountryId",
                table: "State");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name_StateId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_State_Name_CountryId",
                table: "State",
                columns: new[] { "Name", "CountryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_StateId",
                table: "Cities",
                columns: new[] { "Name", "StateId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }
    }
}
