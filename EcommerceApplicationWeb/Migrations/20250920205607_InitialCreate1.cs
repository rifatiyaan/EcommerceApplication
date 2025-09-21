using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceApplicationWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Products_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Metadata", "ParentId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3360), "All electronic devices", "{\"ProductCount\":\"50\",\"Department\":\"Tech\"}", null, "Electronics", null },
                    { 2, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3366), "Fashion and apparel", "{\"ProductCount\":\"120\",\"Department\":\"Fashion\"}", null, "Clothing", null },
                    { 3, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3368), "All kinds of books", "{\"ProductCount\":\"200\",\"Department\":\"Literature\"}", null, "Books", null },
                    { 4, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3370), "Appliances for home", "{\"ProductCount\":\"80\",\"Department\":\"Home\"}", null, "Home Appliances", null },
                    { 5, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3372), "Sports equipment", "{\"ProductCount\":\"60\",\"Department\":\"Sports\"}", null, "Sports", null },
                    { 6, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3374), "Toys for children", "{\"ProductCount\":\"100\",\"Department\":\"Kids\"}", null, "Toys", null },
                    { 7, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3376), "Beauty and personal care", "{\"ProductCount\":\"70\",\"Department\":\"Cosmetics\"}", null, "Beauty", null },
                    { 8, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3378), "Car and bike accessories", "{\"ProductCount\":\"90\",\"Department\":\"Automotive\"}", null, "Automotive", null },
                    { 9, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3379), "Daily groceries", "{\"ProductCount\":\"150\",\"Department\":\"Food\"}", null, "Grocery", null },
                    { 10, new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3381), "Home and office furniture", "{\"ProductCount\":\"40\",\"Department\":\"Home\"}", null, "Furniture", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Code", "CreatedAt", "ImageUrl", "Metadata", "ParentId", "Price", "Stock", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "IP15-001", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3568), "https://example.com/iphone15.jpg", "{\"Description\":\"Latest iPhone\",\"Color\":\"Black\",\"Warranty\":\"2 Years\"}", null, 1299.99m, 10, "iPhone 15", null },
                    { 2, 1, "TV-002", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3622), "https://example.com/samsungtv.jpg", "{\"Description\":\"Smart LED TV\",\"Color\":\"Silver\",\"Warranty\":\"3 Years\"}", null, 899.50m, 15, "Samsung TV", null },
                    { 3, 2, "MJKT-003", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3624), "https://example.com/jacket.jpg", "{\"Description\":\"Warm winter jacket\",\"Color\":\"Brown\",\"Warranty\":\"1 Year\"}", null, 199.50m, 25, "Men's Jacket", null },
                    { 4, 3, "BK-004", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3627), "https://example.com/alchemist.jpg", "{\"Description\":\"Fiction book\",\"Color\":null,\"Warranty\":null}", null, 12.99m, 100, "Novel: The Alchemist", null },
                    { 5, 4, "MO-005", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3629), "https://example.com/microwave.jpg", "{\"Description\":\"800W Microwave\",\"Color\":\"White\",\"Warranty\":\"2 Years\"}", null, 299.00m, 20, "Microwave Oven", null },
                    { 6, 5, "SP-006", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3631), "https://example.com/football.jpg", "{\"Description\":\"Official size 5 football\",\"Color\":\"White/Black\",\"Warranty\":null}", null, 29.99m, 50, "Football", null },
                    { 7, 6, "TOY-007", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3634), "https://example.com/lego.jpg", "{\"Description\":\"Creative Lego set\",\"Color\":\"Multi-color\",\"Warranty\":null}", null, 59.99m, 30, "Lego Set", null },
                    { 8, 7, "BTY-008", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3636), "https://example.com/lipstick.jpg", "{\"Description\":\"Matte lipstick\",\"Color\":\"Red\",\"Warranty\":null}", null, 49.99m, 40, "Lipstick Set", null },
                    { 9, 8, "AUTO-009", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3638), "https://example.com/carvac.jpg", "{\"Description\":\"Portable vacuum for car\",\"Color\":\"Black\",\"Warranty\":\"6 Months\"}", null, 79.99m, 18, "Car Vacuum Cleaner", null },
                    { 10, 10, "FUR-010", new DateTime(2025, 9, 20, 20, 56, 6, 849, DateTimeKind.Utc).AddTicks(3641), "https://example.com/chair.jpg", "{\"Description\":\"Ergonomic chair\",\"Color\":\"Black\",\"Warranty\":\"1 Year\"}", null, 149.99m, 12, "Office Chair", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ParentId",
                table: "Products",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
