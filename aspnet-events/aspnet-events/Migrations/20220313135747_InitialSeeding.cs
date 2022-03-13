using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_events.Migrations
{
    public partial class InitialSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "AttendeeId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "CautiousCow@animail.com", "CautiousCow", "+4689424241" },
                    { 2, "ReasonableShark@animail.com", "ReasonableShark", "+4689428761" },
                    { 3, "AmusedCat@animail.com", "AmusedCat", "+4646228051" },
                    { 4, "JoblessRat@animail.com", "JoblessRat", "+4689574051" }
                });

            migrationBuilder.InsertData(
                table: "Organizers",
                columns: new[] { "OrganizerId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "contact@storaaffarer.se", "Stora affärer AB", "+4639401402" },
                    { 2, "contact@großesgeschäft.ge", "Großes geschäft AG", "+4639401402" },
                    { 3, "contact@grosseaffaire.fr", "Grosse affaire SA", "+4639401402" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Address", "Date", "Description", "OrganizerId", "Place", "SpotsAvailable", "Title" },
                values: new object[,]
                {
                    { 1, "Grazie 15, 957864 Pregi", new DateTimeOffset(new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Stora affärer is hosting a festival to start of this years spaghetti harvest in Italy", 1, "Mi scusi", 40, "Spaghetti harvesting festival" },
                    { 2, "Sveavägen 73, 113 80 Stockholm", new DateTimeOffset(new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "The cockroach Lil Pest is having a listening party for his 9th album", 2, "Stadsbiblioteket", 120, "Lil Pest Listening party" },
                    { 3, "Humongous Street 23, 80468 Las Vegas, Nevada", new DateTimeOffset(new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Annual international event dedicated to the commercial concrete and masonry construction industries.", 2, "The Gazino", 1500, "World of Concrete" },
                    { 4, "Big Avenue, 90652 Dallas, Texas", new DateTimeOffset(new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "The show will display the next wave of innovation that will shape 2022", 3, "Big Avenue", 1000, "CES 2022" },
                    { 5, "Lorem 23, 0xFFFF Ipsum", new DateTimeOffset(new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed to", 3, "127.0.0.1", 5, "Lorem ipsum Conference" }
                });

            migrationBuilder.InsertData(
                table: "AttendeeEvent",
                columns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "AttendeeEvent",
                keyColumns: new[] { "AttendeesAttendeeId", "EventsEventId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "AttendeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "AttendeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "AttendeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "AttendeeId",
                keyValue: 4);

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
                table: "Organizers",
                keyColumn: "OrganizerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizers",
                keyColumn: "OrganizerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organizers",
                keyColumn: "OrganizerId",
                keyValue: 3);
        }
    }
}
