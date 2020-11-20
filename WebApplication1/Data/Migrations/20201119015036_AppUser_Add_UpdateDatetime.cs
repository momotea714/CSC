using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class AppUser_Add_UpdateDatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDatetime",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDatetime",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f946ed85-5a36-4161-aba0-ca1ebe2bc329");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "2010909d-d31d-4f14-ab9b-686691587928");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "708acd01-37f7-437d-8f62-e82908eeeedc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed50a6f4-6098-4c5f-b10c-b91845b83943", "AQAAAAEAACcQAAAAEGzD5QGOYgPMt/QEEU9NBjKh16K6JbJpqlSHz1t1MGB/p8Z6KcnipG9lX+XX7Xjv6g==", "681bfef6-9745-4ad0-95f3-459842b5814e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e05f03b-ba56-420e-babc-e27f9b927bac", "AQAAAAEAACcQAAAAEPc1XnJiFImDBJp7NzouziaOimIAkbVrSDDm3Zv2Urfoxa9S2YzqoFaoLdyqQqkQZg==", "25694332-f358-48a7-b85e-82832ae47281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c43ad297-b8a8-4329-9fee-1d9792c778ae", "AQAAAAEAACcQAAAAECSbsmEsn9qna8aZAsz1UqGGlZhTtf6WcOl9fKUv6HeJxZBv1U2oa3qT8xpDhPWZoQ==", "8f1731cd-7d67-4975-a969-014920827649" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDatetime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdateDatetime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a8259bbc-fbec-42c6-9471-a54aff220796");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "ff89e7df-1132-45ba-9843-c169859a0447");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "fc522e20-329a-4a61-8ebe-1f4d55360d8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407d9aa0-ff32-4faa-87b5-6ba58c972d18", "AQAAAAEAACcQAAAAEMi7hJFcN9838JQUd+Ev2tJFhK9wg4zZQymDX+pBP/hbcuvqlirmbwE0WDTGnAjZmg==", "158bddc7-60ea-4513-b096-b4db28b56482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb685b0e-76ed-4a7e-9ad0-800ce8ba7c33", "AQAAAAEAACcQAAAAEDqCVlSDzoWb2HOnHSgdVfPJEPBiwmui4IKX+Zgy9lKr2bdr/NYgPpl6petmjLwi0Q==", "de354ee7-b0e9-4fa6-a99d-f5e0a8a43f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96c52d22-01fe-4f04-bf8b-795c9488f534", "AQAAAAEAACcQAAAAEGRxVJfGS74ry/onD25LC9v7RxNmsBgAzZOr1tNf+daAnaR3cmBx6VV5jmg2xR3MWg==", "0268e34d-b830-45eb-9407-cf5b3224b47d" });
        }
    }
}
