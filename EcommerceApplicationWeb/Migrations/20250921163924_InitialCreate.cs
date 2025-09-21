using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApplicationWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4251), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4254), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4256), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4257), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4259), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4261), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4263), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4265), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4266), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4268), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4397), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4404), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4406), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4408), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4411), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4413), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4415), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4417), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4419), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsActive" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 39, 23, 303, DateTimeKind.Utc).AddTicks(4421), true });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
