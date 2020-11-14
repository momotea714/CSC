using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class User_Add_UpdateDatetime : Migration
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
                value: "0f12c6c7-8e28-4291-bd16-cac8779ed36b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "0ec29d5d-072d-4d16-b8b0-18a7c6e9140a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "b009d7ae-55e6-43d8-97a6-0d8be38d9cc9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72bfa2de-82df-4e64-9e17-2e25a93d4802", "AQAAAAEAACcQAAAAEOMu6Y7kWFRbIjGg5xIJreHL1l3V3aRf7Pbe8SwjefWopUxA3sbgh7n0fOgMZK/YRw==", "c15398a4-4476-4a01-8b38-76ac524a5a51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32620bab-3975-4239-86c9-0c16464cb184", "AQAAAAEAACcQAAAAEIeCP712aclFc123VdGNqZQlwf8pdhKGz/0CjW9Xf9IrrEPnIAlStVOVRWMwrnI5ng==", "0e4abaa7-5817-4d89-84e1-e5fce147ff1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ec19e3-1eb0-4794-917d-ef637d9f0fec", "AQAAAAEAACcQAAAAEDW7EJIA2f69sm9f9yn8LirzOWvtRWphg1oM9zg9NZEctf+Cqml52/FLOYWiAFTfgg==", "cdc25d4f-64a7-4210-94a1-741fe31a8f50" });
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
