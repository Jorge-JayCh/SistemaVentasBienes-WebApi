using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentasBienes.Migrations
{
    public partial class UpdateTableclientefixclientId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Cliente_clienteId_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_clienteId_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "clienteId_Cliente",
                table: "Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "clienteId_Cliente",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_clienteId_Cliente",
                table: "Cliente",
                column: "clienteId_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Cliente_clienteId_Cliente",
                table: "Cliente",
                column: "clienteId_Cliente",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente");
        }
    }
}
