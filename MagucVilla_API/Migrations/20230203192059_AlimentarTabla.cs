using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagucVilla_API.Migrations
{
    public partial class AlimentarTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 1, "", "Detalle de la villa ...", new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2776), "", 50, "Villa Real", 5, 200.0 });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 2, "", "Detalle de la villa ...", new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2814), "", 50, "Villa Tropical", 2, 500.0 });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 3, "", "Detalle de la villa ...", new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 2, 3, 12, 20, 59, 134, DateTimeKind.Local).AddTicks(2819), "", 100, "Villa sencilla", 15, 150.0 });
        }

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

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
