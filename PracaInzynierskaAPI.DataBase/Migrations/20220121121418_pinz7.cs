using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzynierskaAPI.DataBase.Migrations
{
    public partial class pinz7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("00268e14-83df-4882-ba68-1089579eed8a"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08c5d55a-1784-4806-8656-1e13d8c2c61d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0babc995-ad56-44e2-a92b-ca225f80ae40"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("108ebc86-ceb8-4357-87f6-0b82485a389d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1255c632-24c3-4091-b043-72d94c174db8"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1e7d8ef5-3d1d-44bd-b58f-204de558d72d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("23049d10-dfea-458d-b285-3a78f6cf28d9"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24758f53-051b-4ba1-bea1-317d76c08558"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3f34777b-8a49-496c-9dc8-8f13f6a512da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("438d0327-21c7-4920-887c-de5e24e1efd2"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("43b1e7bb-1d6f-407c-82f5-ec17637e7aad"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("613750bc-e471-4b28-be60-fd538a802f1e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6e6df870-d6dd-4434-80b8-884a6624eae7"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("76a4ef96-9f1b-4c7f-9c3f-2daa9ed9401b"),
                columns: new[] { "CreatedAt", "PermissionName" },
                values: new object[] { new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(150), "Policy.Author.Approve" });

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77a822b5-2211-4eaa-abef-e28cff58a096"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("78273246-91e9-497e-9823-7948777ddd08"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b073c81-8bcd-4a93-96e3-8ef64b87960b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b8591d9-aa83-4ff6-8a68-5c8ca41b253f"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("823bf0ff-0179-4f6d-a485-e93c9523d700"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("bc6cd79c-64c5-4bec-b5aa-e2240a0f7cf4"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c3d979d6-4c97-4ff4-ae14-8319388c90ed"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf69651e-3bb1-49eb-b1ed-a3bb453ba954"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d9447300-3048-4e21-bb29-4d943881554c"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d998336a-005e-4016-b72c-2c01532a5d28"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e0f6bc31-eb25-4dbc-9af5-af200709088e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e319013c-ac3f-45d4-b1c0-d23be2664028"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 713, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 13, 14, 17, 702, DateTimeKind.Local).AddTicks(2536));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("00268e14-83df-4882-ba68-1089579eed8a"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08c5d55a-1784-4806-8656-1e13d8c2c61d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0babc995-ad56-44e2-a92b-ca225f80ae40"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("108ebc86-ceb8-4357-87f6-0b82485a389d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1255c632-24c3-4091-b043-72d94c174db8"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1e7d8ef5-3d1d-44bd-b58f-204de558d72d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("23049d10-dfea-458d-b285-3a78f6cf28d9"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24758f53-051b-4ba1-bea1-317d76c08558"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3f34777b-8a49-496c-9dc8-8f13f6a512da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("438d0327-21c7-4920-887c-de5e24e1efd2"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("43b1e7bb-1d6f-407c-82f5-ec17637e7aad"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("613750bc-e471-4b28-be60-fd538a802f1e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6e6df870-d6dd-4434-80b8-884a6624eae7"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("76a4ef96-9f1b-4c7f-9c3f-2daa9ed9401b"),
                columns: new[] { "CreatedAt", "PermissionName" },
                values: new object[] { new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8337), "Author.Approve" });

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77a822b5-2211-4eaa-abef-e28cff58a096"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("78273246-91e9-497e-9823-7948777ddd08"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b073c81-8bcd-4a93-96e3-8ef64b87960b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b8591d9-aa83-4ff6-8a68-5c8ca41b253f"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("823bf0ff-0179-4f6d-a485-e93c9523d700"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("bc6cd79c-64c5-4bec-b5aa-e2240a0f7cf4"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c3d979d6-4c97-4ff4-ae14-8319388c90ed"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf69651e-3bb1-49eb-b1ed-a3bb453ba954"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d9447300-3048-4e21-bb29-4d943881554c"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d998336a-005e-4016-b72c-2c01532a5d28"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e0f6bc31-eb25-4dbc-9af5-af200709088e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e319013c-ac3f-45d4-b1c0-d23be2664028"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsBuildIn", "IsDeleted", "IsModified", "LastModifiedAt", "PermissionName", "UserId" },
                values: new object[,]
                {
                    { new Guid("2bd0c9e3-e1f4-41e5-8d3f-5b8e4a40dfba"), new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8330), null, true, null, null, null, "UserPermission.Delete", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") },
                    { new Guid("24b10f01-972f-4547-a638-b7f3398496da"), new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(8310), null, true, null, null, null, "UserPermission.Update", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") },
                    { new Guid("a7f01eb1-ccb1-4e67-a63e-ce07c2e052bc"), new DateTime(2022, 1, 5, 14, 40, 58, 687, DateTimeKind.Local).AddTicks(7305), null, true, null, null, null, "UserPermission.Write", new Guid("bcad5300-ef78-4e65-9240-d3609cc88176") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 5, 14, 40, 58, 680, DateTimeKind.Local).AddTicks(4819));
        }
    }
}
