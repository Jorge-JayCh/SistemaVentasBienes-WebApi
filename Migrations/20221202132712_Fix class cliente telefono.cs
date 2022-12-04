using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentasBienes.Migrations
{
    public partial class Fixclassclientetelefono : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Telefono_Cliente",
                table: "Cliente",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono_Cliente",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
