using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USSCerritosHelpDesk.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Technical Support" },
                    { 2, "Software Issue" },
                    { 3, "Hardware Issue" },
                    { 4, "Network Issue" },
                    { 5, "Communications" },
                    { 6, "Security Incident" },
                    { 7, "Purchase and Procurement" },
                    { 8, "User Training" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Command" },
                    { 2, "Operations" },
                    { 3, "Sciences" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemImageUrl", "ItemName", "ItemVersion" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/I/51tlGzJRQlL._AC_UF1000,1000_QL80_.jpg", "Crystal Reports 2020", "version 14.3" },
                    { 2, "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6498/6498483_sd.jpg;maxHeight=640;maxWidth=550", "Windows 11 Pro", "version 1321" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Awaiting Customer Review" },
                    { 4, "Resolved" },
                    { 5, "ReOpened" },
                    { 6, "Cancelled" },
                    { 7, "Escalated" }
                });

            migrationBuilder.InsertData(
                table: "TicketItems",
                columns: new[] { "Id", "ItemId", "TicketId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 2, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToUserId", "CategoryId", "CommentDate", "DateCreated", "DepartmentId", "Description", "Priority", "StatusId", "Title", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Captain Freeman is the new commander of this starship please add her to all command functions", "High", 1, "Add Captain Freeman to the Command Console", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 2, 1, 2, new DateTime(2024, 5, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The printer in the main office is not printing documents.", "Medium", 2, "Printer not working", new DateTime(2024, 5, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 1, 3, new DateTime(2024, 5, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Remote users are unable to connect to the VPN.", "High", 3, "Cannot connect to VPN", new DateTime(2024, 5, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 103 },
                    { 4, 2, 4, new DateTime(2024, 5, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Request to install new software on all department computers.", "Low", 3, "Software installation request", new DateTime(2024, 5, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), 104 },
                    { 5, 2, 5, new DateTime(2024, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "The entire office is experiencing a network outage.", "Critical", 4, "Network outage", new DateTime(2024, 5, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 105 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CommBageId", "DepartmentId", "FirstName", "LastName", "Role" },
                values: new object[,]
                {
                    { 1, "Dilligent444444", 1, "Paul", "Patterson", "Engineer" },
                    { 2, "AB1234456USSC", 2, "Andy", "Billups", "Lieutenant Commander" },
                    { 3, "BW123456USSC", 3, "Bingston", "Winger, Jr", "Lieutenant Junior Grade" },
                    { 4, "BB123456USSC", 1, "Brad", "Boimler", "Lieutenant Junior grade" },
                    { 5, "CF111111USSC", 1, "Carol", "Freeman", "Captain" },
                    { 6, "BM123456USSC", 1, "Beckett", "Mariner", "Ensign" },
                    { 7, "SR123456USSC", 1, "Sam", "Rutherford", "Ensign" },
                    { 8, "TDV123456USSC", 3, "Tendi", "D'Vana", "Lieutenant Junior grade" }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "SolveDate", "TicketId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TicketItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
