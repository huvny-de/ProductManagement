using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCore.Migrations
{
    public partial class seedrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "lastname");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "7efb45fb-2db6-4976-b4d4-b46afd1c0f82", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "lastname" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "cf8ecd18-5e1d-43d5-a185-def1b9c73ebe", "huvny@gmail.com", true, "Henry", false, null, "huvny@gmail.com", "huvny@gmail.com", "AQAAAAEAACcQAAAAEF4EX0o18s/BhfYNQ4WvnhY1l7OD+DwyhXxOcqcnJBNSJvMHYYVO3tY9LyEiAJHz2Q==", "0954683265", false, "dbffcd2f-6810-40d7-b80a-682dc9ead601", false, "huvny@gmail.com", "de Aaron" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "AspNetUsers",
                newName: "LastName");
        }
    }
}
