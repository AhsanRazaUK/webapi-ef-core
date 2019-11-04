using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2019, 10, 30, 13, 10, 35, 239, DateTimeKind.Utc).AddTicks(8393), "Elizabeth", false, "Gilbert", null, null },
                    { 2, null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(1946), "Alex", false, "Michaelides", null, null },
                    { 3, null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(1966), "Jayson", false, "Greene", null, null },
                    { 4, null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(1967), "Jennifer", false, "Weiner", null, null },
                    { 5, null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(1969), "Yangsze", false, "Choo", null, null },
                    { 6, null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(1971), "Taylor", false, "Jenkins Reid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Novel", null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(7426), false, null, null },
                    { 2, "Thriller", null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(8146), false, null, null },
                    { 3, "Memoir", null, new DateTime(2019, 10, 30, 13, 10, 35, 240, DateTimeKind.Utc).AddTicks(8154), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookName", "CategoryId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, "City of Girls", 1, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(716), false, null, null },
                    { 4, 4, "Mrs. Everything", 1, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(2740), false, null, null },
                    { 5, 5, "The Night Tiger", 1, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(2741), false, null, null },
                    { 6, 6, "Daisy Jones & The Six", 1, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(2742), false, null, null },
                    { 2, 2, "The Silent Patient", 2, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(2725), false, null, null },
                    { 3, 3, "Once More We Saw Stars", 3, null, new DateTime(2019, 10, 30, 13, 10, 35, 241, DateTimeKind.Utc).AddTicks(2739), false, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

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
        }
    }
}
