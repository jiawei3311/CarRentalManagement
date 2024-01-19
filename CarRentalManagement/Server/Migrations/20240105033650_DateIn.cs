using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class DateIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2c33f4b-5fcc-4209-abe7-2767119f9e0f", "AQAAAAIAAYagAAAAEDwmi2d2P37aUsjKhLnVf8tGEZNYGzOrSxaiaJoHx/Uz+9oGzneP3grOFwq4CCuJcg==", "f42baec7-4fa9-4dc7-9dd6-eb2724d4d108" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(3756), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(3774), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4214), new DateTime(2024, 1, 5, 11, 36, 50, 23, DateTimeKind.Local).AddTicks(4215) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "313a5f58-6d4f-4088-9ee8-68bfc573e809", "AQAAAAIAAYagAAAAEJu73l6qq3LkCFUFRno2QmVq23kf9CRaAJrkprN9rNcdyQfXSwln8ND7Od9uAW10xA==", "bc96944a-dace-4e08-a8a6-6fc304348542" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9663), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 1, 5, 11, 28, 29, 790, DateTimeKind.Local).AddTicks(9667) });
        }
    }
}
