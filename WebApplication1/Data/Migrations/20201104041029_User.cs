using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserGroupId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5a814e66-9a86-49ff-b31c-d4a7aaad5afb", "管理" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "867f6f7e-f1e0-4936-a66b-5b1af0d6aeb3", "Leader", "リーダー" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "7fe50c24-e846-4c50-9b75-a3caf1b4db58", "Normal", "一般" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DisplayUserName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc6c8348-82ac-48e0-810f-eae814c4bcd0", "管理者user1", "user1", "AQAAAAEAACcQAAAAEPWQzHw6Pj/hJGkOTXPv8iIJp+KluNO1yq3d+n67Yj8EbCEruTtkITYBZtVsP17V0Q==", "4e2b5079-41c4-48ca-b8eb-2d7563d1706e", "user1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayUserName", "Email", "EmailConfirmed", "GroupName", "IsValid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserGroupId", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "1096f101-d1f7-435f-b206-3a05f92575e1", "リーダーuser2", null, false, null, false, false, null, null, "user2", null, "AQAAAAEAACcQAAAAEP6qSyotFJSU42CYmgA8QefG+oGuPwrAex1+Z7Py7Suhhhb1W/F2UHeqxcXBKE7nXg==", null, false, "10622e6b-4cb0-45b0-8ce8-5955114d11c9", false, null, "user2" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "7f08372b-f6b6-4038-beb6-ca6b53c5d7c7", "一般user3", null, false, null, false, false, null, null, "user3", null, "AQAAAAEAACcQAAAAEAqGLsoPCCaEROT6Oe/kQX78jO2JijkqNbARxLEiOrSHuWKNW0/K3iDemEEinVFDRg==", null, false, "631d9036-1821-4aeb-9855-3d048df0bacc", false, null, "user3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb8", "2c5e174e-3b0e-446f-86af-483d56fd7211" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb7", "2c5e174e-3b0e-446f-86af-483d56fd7212" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserGroupId",
                table: "AspNetUsers",
                column: "UserGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserGroup_UserGroupId",
                table: "AspNetUsers",
                column: "UserGroupId",
                principalTable: "UserGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserGroup_UserGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserGroupId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb7", "2c5e174e-3b0e-446f-86af-483d56fd7212" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb8", "2c5e174e-3b0e-446f-86af-483d56fd7211" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserGroupId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "cf285661-5b63-444f-9bdb-e73c28a5dae2", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DisplayUserName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7da60f72-9bf6-460c-95b7-f7734bdb9f41", null, "MYUSER", "AQAAAAEAACcQAAAAEH/78hIXT2inYcf9uDKz7rIEnY6nKEdcrpzzCpBpWIcdxNQcadQWqxUPpCMQgJyYDw==", "d3f8c74a-67cc-454a-9409-8bd1fbbc1b3f", "myuser" });
        }
    }
}
