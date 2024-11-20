using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_project.Migrations
{
    /// <inheritdoc />
    public partial class f3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Directors_DirectorId",
                table: "Nationalities");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Directors_DirectorId",
                table: "Nationalities",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Directors_DirectorId",
                table: "Nationalities");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Directors_DirectorId",
                table: "Nationalities",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }
    }
}
