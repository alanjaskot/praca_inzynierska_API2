using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzynierskaAPI.DataBase.Migrations
{
    public partial class Pinz4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Banned", "CreatedAt", "DeletedAt", "Email", "IsBuildIn", "IsDeleted", "IsModified", "LastModifiedAt", "Likes", "Name", "NumberOfBooks", "NumberOfComments", "Password", "Sex", "Surname", "UserName" },
                values: new object[] { new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"), null, new DateTime(2022, 1, 4, 11, 29, 40, 677, DateTimeKind.Local).AddTicks(6408), null, null, true, null, null, null, 0L, null, 0L, 0L, "123", null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsBuildIn", "IsDeleted", "IsModified", "LastModifiedAt", "PermissionName", "UserId" },
                values: new object[,]
                {
                    { new Guid("a7f01eb1-ccb1-4e67-a63e-ce07c2e052bc"), new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(8375), null, true, null, null, null, "UserPermission.Write", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") },
                    { new Guid("24b10f01-972f-4547-a638-b7f3398496da"), new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(9709), null, true, null, null, null, "UserPermission.Update", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") },
                    { new Guid("2bd0c9e3-e1f4-41e5-8d3f-5b8e4a40dfba"), new DateTime(2022, 1, 4, 11, 29, 40, 685, DateTimeKind.Local).AddTicks(9737), null, true, null, null, null, "UserPermission.Delete", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24b10f01-972f-4547-a638-b7f3398496da"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2bd0c9e3-e1f4-41e5-8d3f-5b8e4a40dfba"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a7f01eb1-ccb1-4e67-a63e-ce07c2e052bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"));
        }
    }
}
