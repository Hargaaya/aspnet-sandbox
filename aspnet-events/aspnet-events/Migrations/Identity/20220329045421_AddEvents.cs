using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_events.Migrations.Identity
{
    public partial class AddEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Events_EventsEventId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizer_OrganizerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizerId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserEventEventId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SpotsAvailable = table.Column<int>(type: "int", nullable: false),
                    OrganizerId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_Organizer_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Organizer",
                        principalColumn: "OrganizerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb96894-87ad-4af5-9e02-e3703f2259f7",
                column: "ConcurrencyStamp",
                value: "ed235168-e431-4e3d-b0be-dff08a28d987");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fea37b6-ad6c-4122-933b-76da443b4db5",
                column: "ConcurrencyStamp",
                value: "ee0750cc-641e-42da-977a-99556ee12c25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da981ce2-f658-4e40-87c6-d93d5e2ffbe2",
                column: "ConcurrencyStamp",
                value: "790fd49d-2c5c-4aa3-a6b4-11a9fd06abbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5cdc66-a621-4c0c-9ccd-f661674dc62d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e27fb12-74d8-4d8d-888f-b0f303f58372", "AQAAAAEAACcQAAAAEJn6WSVE8JvAmqcJCbdoVIYyP4GHgsoK8OY5iKQpyfjD3mPJ7PLLwVA1wpL5T5fDlw==", "c7989d02-82ef-480c-9a97-6341fd202e00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748a69e9-fc2f-461f-a2c5-cc3d22771351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec3ea28f-184c-4775-8d67-816fb343835a", "AQAAAAEAACcQAAAAEK1gU2sa9X65OJKmiyYMn91JD+A6FTj6KHy1VrIT3z9xDh9fgL3/rJ9HFQGQDVhNow==", "f759b1f1-445d-4f06-866f-264af84781d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "781231d3-90c5-4e55-b7c9-e27bd26be513",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e7af10-705c-4793-be54-6f77586ab0f3", "AQAAAAEAACcQAAAAEC/HtRHhYvvCc+fXMDSqcBlVakDG1WPcNV7yyQGluCqM2QpOX9GRb5zva8rptEYj6w==", "644cfcb7-28d0-4fd4-8ab7-14c6426523bb" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Address", "Date", "Description", "Id", "OrganizerId", "Place", "SpotsAvailable", "Title" },
                values: new object[,]
                {
                    { 1, "Grazie 15, 957864 Pregi", new DateTimeOffset(new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Stora affärer is hosting a festival to start of this years spaghetti harvest in Italy", "781231d3-90c5-4e55-b7c9-e27bd26be513", null, "Mi scusi", 40, "Spaghetti harvesting festival" },
                    { 2, "Sveavägen 73, 113 80 Stockholm", new DateTimeOffset(new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "The cockroach Lil Pest is having a listening party for his 9th album", "781231d3-90c5-4e55-b7c9-e27bd26be513", null, "Stadsbiblioteket", 120, "Lil Pest Listening party" },
                    { 3, "Humongous Street 23, 80468 Las Vegas, Nevada", new DateTimeOffset(new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Annual international event dedicated to the commercial concrete and masonry construction industries.", "781231d3-90c5-4e55-b7c9-e27bd26be513", null, "The Gazino", 1500, "World of Concrete" },
                    { 4, "Big Avenue, 90652 Dallas, Texas", new DateTimeOffset(new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "The show will display the next wave of innovation that will shape 2022", "781231d3-90c5-4e55-b7c9-e27bd26be513", null, "Big Avenue", 1000, "CES 2022" },
                    { 5, "Lorem 23, 0xFFFF Ipsum", new DateTimeOffset(new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed to", "781231d3-90c5-4e55-b7c9-e27bd26be513", null, "127.0.0.1", 5, "Lorem ipsum Conference" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserEventEventId",
                table: "AspNetUsers",
                column: "UserEventEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerId",
                table: "Event",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId1",
                table: "Event",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Events_UserEventEventId",
                table: "AspNetUsers",
                column: "UserEventEventId",
                principalTable: "Events",
                principalColumn: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent",
                column: "EventsEventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Events_UserEventEventId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_OrganizerId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserEventEventId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserEventEventId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizerId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb96894-87ad-4af5-9e02-e3703f2259f7",
                column: "ConcurrencyStamp",
                value: "ae4dcc1d-bd52-47fc-8037-7677795739ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fea37b6-ad6c-4122-933b-76da443b4db5",
                column: "ConcurrencyStamp",
                value: "8806454a-2c67-47b5-98bf-28877f235e95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da981ce2-f658-4e40-87c6-d93d5e2ffbe2",
                column: "ConcurrencyStamp",
                value: "1b59a5e0-2670-49f0-a8aa-d077bd0b6903");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5cdc66-a621-4c0c-9ccd-f661674dc62d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05bcf9bb-f212-4b50-b6ac-01b0421e2cc3", "AQAAAAEAACcQAAAAEDhG8Hvdcn6axExRXAFOjftHk6H1Xrmipq8U6jKCbj2lVC6LoW/FhD6+LDAqX5FLKw==", "ff7bf5f1-1a8f-46b1-87fa-2dd47be9b334" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748a69e9-fc2f-461f-a2c5-cc3d22771351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37aaca26-6c8c-450a-8fbe-891dd1d6d7fb", "AQAAAAEAACcQAAAAEEyp/sTgBEEMGeWPQz+Cddo9PVsCeabWPC4QmcUs77BK/jC8Y6rF5l+6TjD96OPfzQ==", "a7b3e496-6e44-4753-8f78-c4d144607a27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "781231d3-90c5-4e55-b7c9-e27bd26be513",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4757b85-f4e2-4afa-9742-449faf99b91a", "AQAAAAEAACcQAAAAEE6QsIwMgHLR46tSldEq1HViCKvxCvX6F1+BRWLQDCZqNo+vzC8auLzjo2PQhfmRtA==", "48d4f026-4ace-435d-84dc-f719b85c6d58" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId1",
                table: "Events",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Events_EventsEventId",
                table: "AttendeeEvent",
                column: "EventsEventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_UserId1",
                table: "Events",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizer_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "Organizer",
                principalColumn: "OrganizerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
