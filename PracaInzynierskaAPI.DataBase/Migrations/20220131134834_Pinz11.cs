﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzynierskaAPI.DataBase.Migrations
{
    public partial class Pinz11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "ImageCovers");

            migrationBuilder.RenameColumn(
                name: "ImageTitle",
                table: "ImageCovers",
                newName: "FilePath");

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "ImageCovers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ImageCovers",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CommentId",
                table: "Comments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("00268e14-83df-4882-ba68-1089579eed8a"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08c5d55a-1784-4806-8656-1e13d8c2c61d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0babc995-ad56-44e2-a92b-ca225f80ae40"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("108ebc86-ceb8-4357-87f6-0b82485a389d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1255c632-24c3-4091-b043-72d94c174db8"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1e7d8ef5-3d1d-44bd-b58f-204de558d72d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("23049d10-dfea-458d-b285-3a78f6cf28d9"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24758f53-051b-4ba1-bea1-317d76c08558"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3f34777b-8a49-496c-9dc8-8f13f6a512da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("438d0327-21c7-4920-887c-de5e24e1efd2"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("43b1e7bb-1d6f-407c-82f5-ec17637e7aad"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("613750bc-e471-4b28-be60-fd538a802f1e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6e6df870-d6dd-4434-80b8-884a6624eae7"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("76a4ef96-9f1b-4c7f-9c3f-2daa9ed9401b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77a822b5-2211-4eaa-abef-e28cff58a096"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("78273246-91e9-497e-9823-7948777ddd08"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b073c81-8bcd-4a93-96e3-8ef64b87960b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b8591d9-aa83-4ff6-8a68-5c8ca41b253f"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("823bf0ff-0179-4f6d-a485-e93c9523d700"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("bc6cd79c-64c5-4bec-b5aa-e2240a0f7cf4"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c3d979d6-4c97-4ff4-ae14-8319388c90ed"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf69651e-3bb1-49eb-b1ed-a3bb453ba954"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d9447300-3048-4e21-bb29-4d943881554c"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d998336a-005e-4016-b72c-2c01532a5d28"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e0f6bc31-eb25-4dbc-9af5-af200709088e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e319013c-ac3f-45d4-b1c0-d23be2664028"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 812, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 31, 14, 48, 33, 805, DateTimeKind.Local).AddTicks(5154));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "ImageCovers");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ImageCovers");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "ImageCovers",
                newName: "ImageTitle");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageFile",
                table: "ImageCovers",
                type: "bytea",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CommentId",
                table: "Comments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("00268e14-83df-4882-ba68-1089579eed8a"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08c5d55a-1784-4806-8656-1e13d8c2c61d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0babc995-ad56-44e2-a92b-ca225f80ae40"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("108ebc86-ceb8-4357-87f6-0b82485a389d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1255c632-24c3-4091-b043-72d94c174db8"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1e7d8ef5-3d1d-44bd-b58f-204de558d72d"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("23049d10-dfea-458d-b285-3a78f6cf28d9"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("24758f53-051b-4ba1-bea1-317d76c08558"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3f34777b-8a49-496c-9dc8-8f13f6a512da"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("438d0327-21c7-4920-887c-de5e24e1efd2"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("43b1e7bb-1d6f-407c-82f5-ec17637e7aad"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("613750bc-e471-4b28-be60-fd538a802f1e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6e6df870-d6dd-4434-80b8-884a6624eae7"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("76a4ef96-9f1b-4c7f-9c3f-2daa9ed9401b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77a822b5-2211-4eaa-abef-e28cff58a096"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("78273246-91e9-497e-9823-7948777ddd08"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b073c81-8bcd-4a93-96e3-8ef64b87960b"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7b8591d9-aa83-4ff6-8a68-5c8ca41b253f"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("823bf0ff-0179-4f6d-a485-e93c9523d700"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("bc6cd79c-64c5-4bec-b5aa-e2240a0f7cf4"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c3d979d6-4c97-4ff4-ae14-8319388c90ed"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf69651e-3bb1-49eb-b1ed-a3bb453ba954"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d9447300-3048-4e21-bb29-4d943881554c"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d998336a-005e-4016-b72c-2c01532a5d28"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e0f6bc31-eb25-4dbc-9af5-af200709088e"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e319013c-ac3f-45d4-b1c0-d23be2664028"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 439, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcad5300-ef78-4e65-9240-d3609cc88176"),
                column: "CreatedAt",
                value: new DateTime(2022, 1, 21, 15, 47, 35, 429, DateTimeKind.Local).AddTicks(6998));
        }
    }
}
