using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class Correccionnombrecolumnasprueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaActualizacio",
                table: "NumeroVillas",
                newName: "FechaActualizacion");

            migrationBuilder.RenameColumn(
                name: "DetalleEspecuak",
                table: "NumeroVillas",
                newName: "DetalleEspecial");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 20, 16, 34, 36, 577, DateTimeKind.Local).AddTicks(7208), new DateTime(2023, 3, 20, 16, 34, 36, 577, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 20, 16, 34, 36, 577, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 3, 20, 16, 34, 36, 577, DateTimeKind.Local).AddTicks(7212) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaActualizacion",
                table: "NumeroVillas",
                newName: "FechaActualizacio");

            migrationBuilder.RenameColumn(
                name: "DetalleEspecial",
                table: "NumeroVillas",
                newName: "DetalleEspecuak");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 20, 12, 37, 13, 40, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 3, 20, 12, 37, 13, 40, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 20, 12, 37, 13, 40, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 3, 20, 12, 37, 13, 40, DateTimeKind.Local).AddTicks(3693) });
        }
    }
}
