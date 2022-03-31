using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_events.Migrations.Identity
{
    public partial class UpgradeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb96894-87ad-4af5-9e02-e3703f2259f7",
                column: "ConcurrencyStamp",
                value: "80433595-a3b8-4180-b455-25d7089120e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fea37b6-ad6c-4122-933b-76da443b4db5",
                column: "ConcurrencyStamp",
                value: "db97659c-73d8-453c-8589-3f29cded8790");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da981ce2-f658-4e40-87c6-d93d5e2ffbe2",
                column: "ConcurrencyStamp",
                value: "cb8a3395-33c7-41cd-ad6c-4d62f128bad8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5cdc66-a621-4c0c-9ccd-f661674dc62d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5174a717-ec4b-4402-bca6-a0279fa1ac8d", "ATTENDEE", "AQAAAAEAACcQAAAAEFPH7zwEu4q2oK45f/NtlMMf2YMGtgtoEDqMWZYdfuNQgeCqVxeVm2pam+umfHO5ug==", "c68aad90-9838-40ea-b5d0-feada1a2a289", "Attendee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748a69e9-fc2f-461f-a2c5-cc3d22771351",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d03d76ed-b1f4-4c73-90bd-d7730bc1f5c9", "ADMIN", "AQAAAAEAACcQAAAAEMnpj0WcH5scTKVlZl+4iFSyTbrWX8Ra3JnzmhU25JU3DrYC53MGG2khGwr+SckBfQ==", "587e280b-bc2a-44f6-854d-ea015afb1972", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "781231d3-90c5-4e55-b7c9-e27bd26be513",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "77ff7f91-8163-47f0-8e98-21fd3496d678", "ORGANIZER", "AQAAAAEAACcQAAAAEK9Zu6mhssi37veWo+JMLV9cAf7cGmeeqoXUJwAFttM6d+gTlmaAoAnNnNmZFEH9wg==", "03cdadc3-ce9f-4305-985b-4309bd696c9a", "Organizer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb96894-87ad-4af5-9e02-e3703f2259f7",
                column: "ConcurrencyStamp",
                value: "4eb06333-bdfd-4e59-a10a-9bb0ec20ee64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fea37b6-ad6c-4122-933b-76da443b4db5",
                column: "ConcurrencyStamp",
                value: "ce044618-01ed-4a28-831c-4163726f877b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da981ce2-f658-4e40-87c6-d93d5e2ffbe2",
                column: "ConcurrencyStamp",
                value: "8be03b45-77be-4717-b9f9-1ceccc08bb3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5cdc66-a621-4c0c-9ccd-f661674dc62d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "42537766-6e69-4355-8a41-a26a436fc8c6", null, "AQAAAAEAACcQAAAAEPPr5bKQ363evVTe9cdJfmrrGfzpdV5Yo0r8uSqwT3ieMs5k/b5UZd7fcL8UkLKw7Q==", "766cbb07-bde3-4653-95e8-7b3408d6f578", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748a69e9-fc2f-461f-a2c5-cc3d22771351",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6336f7ff-20eb-4477-b51e-4196898a67e0", null, "AQAAAAEAACcQAAAAEJVWWjuuzgKYTTAoOQqaS1sqZomJAWq7qLqxuqI0OFQ8Vk3FrOUkbTEE8VIQc07lIA==", "b9f090c1-4131-4fb3-b062-a9271d40bc7c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "781231d3-90c5-4e55-b7c9-e27bd26be513",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "200400d5-e793-4092-b610-eaeceb5fce92", null, "AQAAAAEAACcQAAAAEIVzzgUH6mE6jdV2BvGeFiHr5UuAHl+U//8FXw69XBNUCcHkloAzZxAHJq/SyUty7Q==", "7ff1db89-378c-4768-b6c7-9ca84faf79aa", null });
        }
    }
}
