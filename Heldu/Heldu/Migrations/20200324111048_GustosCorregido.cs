using Microsoft.EntityFrameworkCore.Migrations;

namespace Heldu.Migrations
{
    public partial class GustosCorregido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoCategoria_Usuario_UsuarioId",
                table: "ProductoCategoria");

            migrationBuilder.DropIndex(
                name: "IX_ProductoCategoria_UsuarioId",
                table: "ProductoCategoria");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ProductoCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ProductoCategoria",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductoCategoria_UsuarioId",
                table: "ProductoCategoria",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoCategoria_Usuario_UsuarioId",
                table: "ProductoCategoria",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
