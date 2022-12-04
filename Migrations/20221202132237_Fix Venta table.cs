using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentasBienes.Migrations
{
    public partial class FixVentatable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_ClienteId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Forma_Pago_FormaPagoId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Inmueble_InmuebleId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_ClienteId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_FormaPagoId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_InmuebleId",
                table: "Venta");

            migrationBuilder.AddColumn<int>(
                name: "Forma_PagoId_Forma_Pago",
                table: "Venta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InmuebleId_Inmueble",
                table: "Venta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_Forma_PagoId_Forma_Pago",
                table: "Venta",
                column: "Forma_PagoId_Forma_Pago");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_InmuebleId",
                table: "Venta",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_InmuebleId_Inmueble",
                table: "Venta",
                column: "InmuebleId_Inmueble",
                unique: true,
                filter: "[InmuebleId_Inmueble] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_InmuebleId",
                table: "Venta",
                column: "InmuebleId",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Forma_Pago_Forma_PagoId_Forma_Pago",
                table: "Venta",
                column: "Forma_PagoId_Forma_Pago",
                principalTable: "Forma_Pago",
                principalColumn: "Id_Forma_Pago");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Inmueble_InmuebleId_Inmueble",
                table: "Venta",
                column: "InmuebleId_Inmueble",
                principalTable: "Inmueble",
                principalColumn: "Id_Inmueble");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_InmuebleId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Forma_Pago_Forma_PagoId_Forma_Pago",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Inmueble_InmuebleId_Inmueble",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_Forma_PagoId_Forma_Pago",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_InmuebleId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_InmuebleId_Inmueble",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "Forma_PagoId_Forma_Pago",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "InmuebleId_Inmueble",
                table: "Venta");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ClienteId",
                table: "Venta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_FormaPagoId",
                table: "Venta",
                column: "FormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_InmuebleId",
                table: "Venta",
                column: "InmuebleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_ClienteId",
                table: "Venta",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Forma_Pago_FormaPagoId",
                table: "Venta",
                column: "FormaPagoId",
                principalTable: "Forma_Pago",
                principalColumn: "Id_Forma_Pago",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Inmueble_InmuebleId",
                table: "Venta",
                column: "InmuebleId",
                principalTable: "Inmueble",
                principalColumn: "Id_Inmueble",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
