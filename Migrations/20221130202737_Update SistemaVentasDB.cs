using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentasBienes.Migrations
{
    public partial class UpdateSistemaVentasDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId_Cliente = table.Column<int>(type: "int", nullable: true),
                    Nombre_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dir_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_Cliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Cliente_clienteId_Cliente",
                        column: x => x.clienteId_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente");
                });

            migrationBuilder.CreateTable(
                name: "Condicion",
                columns: table => new
                {
                    Id_Condicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Condicion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condicion", x => x.Id_Condicion);
                });

            migrationBuilder.CreateTable(
                name: "Forma_Pago",
                columns: table => new
                {
                    Id_Forma_Pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Forma_Pago = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forma_Pago", x => x.Id_Forma_Pago);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Inmueble",
                columns: table => new
                {
                    Id_Tipo_Inmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Condicion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Inmueble", x => x.Id_Tipo_Inmueble);
                });

            migrationBuilder.CreateTable(
                name: "Inmueble",
                columns: table => new
                {
                    Id_Inmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Inmueble = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubic_Inmueble = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo_Inmueble = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TipoInmuebleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmueble", x => x.Id_Inmueble);
                    table.ForeignKey(
                        name: "FK_Inmueble_Tipo_Inmueble_TipoInmuebleId",
                        column: x => x.TipoInmuebleId,
                        principalTable: "Tipo_Inmueble",
                        principalColumn: "Id_Tipo_Inmueble",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Venta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_Venta = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Total_Iva = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Total_General = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Fecha_Venta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    FormaPagoId = table.Column<int>(type: "int", nullable: false),
                    CondicionId = table.Column<int>(type: "int", nullable: false),
                    InmuebleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id_Venta);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Condicion_CondicionId",
                        column: x => x.CondicionId,
                        principalTable: "Condicion",
                        principalColumn: "Id_Condicion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Forma_Pago_FormaPagoId",
                        column: x => x.FormaPagoId,
                        principalTable: "Forma_Pago",
                        principalColumn: "Id_Forma_Pago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "Id_Inmueble",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_clienteId_Cliente",
                table: "Cliente",
                column: "clienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Inmueble_TipoInmuebleId",
                table: "Inmueble",
                column: "TipoInmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ClienteId",
                table: "Venta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_CondicionId",
                table: "Venta",
                column: "CondicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_FormaPagoId",
                table: "Venta",
                column: "FormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_InmuebleId",
                table: "Venta",
                column: "InmuebleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Condicion");

            migrationBuilder.DropTable(
                name: "Forma_Pago");

            migrationBuilder.DropTable(
                name: "Inmueble");

            migrationBuilder.DropTable(
                name: "Tipo_Inmueble");
        }
    }
}
