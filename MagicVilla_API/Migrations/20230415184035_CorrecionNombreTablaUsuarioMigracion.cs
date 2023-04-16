using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionNombreTablaUsuarioMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 4, 15, 12, 40, 35, 285, DateTimeKind.Local).AddTicks(1859), new DateTime(2023, 4, 15, 12, 40, 35, 285, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 4, 15, 12, 40, 35, 285, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 4, 15, 12, 40, 35, 285, DateTimeKind.Local).AddTicks(1862) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 4, 15, 11, 41, 39, 741, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 4, 15, 11, 41, 39, 741, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 4, 15, 11, 41, 39, 741, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 4, 15, 11, 41, 39, 741, DateTimeKind.Local).AddTicks(4725) });
        }
    }
}
