using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class UserPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "a8259bbc-fbec-42c6-9471-a54aff220796", "管理者" });

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
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407d9aa0-ff32-4faa-87b5-6ba58c972d18", "P@ssw0rd", "AQAAAAEAACcQAAAAEMi7hJFcN9838JQUd+Ev2tJFhK9wg4zZQymDX+pBP/hbcuvqlirmbwE0WDTGnAjZmg==", "158bddc7-60ea-4513-b096-b4db28b56482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb685b0e-76ed-4a7e-9ad0-800ce8ba7c33", "P@ssw0rd", "AQAAAAEAACcQAAAAEDqCVlSDzoWb2HOnHSgdVfPJEPBiwmui4IKX+Zgy9lKr2bdr/NYgPpl6petmjLwi0Q==", "de354ee7-b0e9-4fa6-a99d-f5e0a8a43f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96c52d22-01fe-4f04-bf8b-795c9488f534", "P@ssw0rd", "AQAAAAEAACcQAAAAEGRxVJfGS74ry/onD25LC9v7RxNmsBgAzZOr1tNf+daAnaR3cmBx6VV5jmg2xR3MWg==", "0268e34d-b830-45eb-9407-cf5b3224b47d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5a814e66-9a86-49ff-b31c-d4a7aaad5afb", "管理" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "867f6f7e-f1e0-4936-a66b-5b1af0d6aeb3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "7fe50c24-e846-4c50-9b75-a3caf1b4db58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f08372b-f6b6-4038-beb6-ca6b53c5d7c7", null, "AQAAAAEAACcQAAAAEAqGLsoPCCaEROT6Oe/kQX78jO2JijkqNbARxLEiOrSHuWKNW0/K3iDemEEinVFDRg==", "631d9036-1821-4aeb-9855-3d048df0bacc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1096f101-d1f7-435f-b206-3a05f92575e1", null, "AQAAAAEAACcQAAAAEP6qSyotFJSU42CYmgA8QefG+oGuPwrAex1+Z7Py7Suhhhb1W/F2UHeqxcXBKE7nXg==", "10622e6b-4cb0-45b0-8ce8-5955114d11c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc6c8348-82ac-48e0-810f-eae814c4bcd0", null, "AQAAAAEAACcQAAAAEPWQzHw6Pj/hJGkOTXPv8iIJp+KluNO1yq3d+n67Yj8EbCEruTtkITYBZtVsP17V0Q==", "4e2b5079-41c4-48ca-b8eb-2d7563d1706e" });
        }
    }
}
