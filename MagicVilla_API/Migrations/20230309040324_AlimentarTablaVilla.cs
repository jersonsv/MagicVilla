using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa..", new DateTime(2023, 3, 8, 22, 3, 24, 527, DateTimeKind.Local).AddTicks(4918), new DateTime(2023, 3, 8, 22, 3, 24, 527, DateTimeKind.Local).AddTicks(4882), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa..", new DateTime(2023, 3, 8, 22, 3, 24, 527, DateTimeKind.Local).AddTicks(5212), new DateTime(2023, 3, 8, 22, 3, 24, 527, DateTimeKind.Local).AddTicks(5210), "", 40, "Premium Vista a la Piscina", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
