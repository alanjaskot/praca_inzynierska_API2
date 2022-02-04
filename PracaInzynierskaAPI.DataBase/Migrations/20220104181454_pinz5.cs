using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzynierskaAPI.DataBase.Migrations
{
    public partial class pinz5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24b10f01-972f-4547-a638-b7f3398496da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 19, 14, 52, 873, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2bd0c9e3-e1f4-41e5-8d3f-5b8e4a40dfba"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 19, 14, 52, 873, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a7f01eb1-ccb1-4e67-a63e-ce07c2e052bc"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 19, 14, 52, 873, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 19, 14, 52, 859, DateTimeKind.Local).AddTicks(6524));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24b10f01-972f-4547-a638-b7f3398496da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2bd0c9e3-e1f4-41e5-8d3f-5b8e4a40dfba"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a7f01eb1-ccb1-4e67-a63e-ce07c2e052bc"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 4, 11, 29, 40, 677, DateTimeKind.Local).AddTicks(6408));
        }
    }
}
