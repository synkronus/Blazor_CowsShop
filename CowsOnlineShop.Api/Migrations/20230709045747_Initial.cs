using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CowsOnlineShop.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Qty = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sex = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    StockAvailable = table.Column<int>(type: "INTEGER", nullable: false),
                    BreedCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_BreedCategories_BreedCategoryId",
                        column: x => x.BreedCategoryId,
                        principalTable: "BreedCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BreedCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Holstein" });

            migrationBuilder.InsertData(
                table: "BreedCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Hereford" });

            migrationBuilder.InsertData(
                table: "BreedCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Aberdeen" });

            migrationBuilder.InsertData(
                table: "BreedCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Belgian" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 1, "User01" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 2, "User02" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 1, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "International breed or group of breeds of dairy cattle", "/Images/Holstein/Holstein1.png", "Holstein Friesian", 100m, 0, 1, 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 2, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "International breed or group of breeds of dairy cattle", "/Images/Holstein/Holstein2.png", "Holstein Friesian", 50m, 0, 1, 45 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 3, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "International breed or group of breeds of dairy cattle", "/Images/Holstein/Holstein3.png", "Holstein Friesian", 20m, 0, 1, 30 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 4, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "International breed or group of breeds of dairy cattle", "/Images/Holstein/Holstein4.png", "Holstein Friesian", 50m, 0, 1, 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 5, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "International breed or group of breeds of dairy cattle", "/Images/Holstein/Holstein4.png", "Holstein Friesian", 50m, 0, 1, 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 6, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Originally from Herefordshire in the West Midlands of England", "/Images/Hereford/Hereford3.png", "Hereford cattle", 70m, 0, 1, 90 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 7, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Originally from Herefordshire in the West Midlands of England", "/Images/Hereford/Hereford4.png", "Hereford cattle", 120m, 0, 1, 95 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 8, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Originally from Herefordshire in the West Midlands of England", "/Images/Hereford/Hereford6.png", "Hereford cattle", 15m, 0, 1, 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 9, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Originally from Herefordshire in the West Midlands of England", "/Images/Hereford/Hereford1.png", "Hereford cattle", 50m, 0, 1, 212 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 10, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Originally from Herefordshire in the West Midlands of England", "/Images/Hereford/Hereford2.png", "Hereford cattle", 50m, 0, 1, 112 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 11, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sometimes simply Angus, is a Scottish breed of small beef cattle", "/Images/Aberdeen/Aberdeen2.png", "Aberdeen Angus", 40m, 0, 1, 200 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 12, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sometimes simply Angus, is a Scottish breed of small beef cattle", "/Images/Aberdeen/Aberdeen3.png", "Aberdeen Angus", 40m, 0, 1, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 13, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sometimes simply Angus, is a Scottish breed of small beef cattle", "/Images/Aberdeen/Aberdeen4.png", "Aberdeen Angus", 600m, 0, 1, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 14, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sometimes simply Angus, is a Scottish breed of small beef cattle", "/Images/Aberdeen/Aberdeen5.png", "Aberdeen Angus", 500m, 0, 1, 15 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 15, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sometimes simply Angus, is a Scottish breed of small beef cattle", "/Images/Aberdeen/Aberdeen1.png", "Aberdeen Angus", 100m, 0, 1, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 16, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil", "/Images/Belgian/Belgian2.png", "Belgian Blue", 150m, 0, 1, 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 17, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil", "/Images/Belgian/Belgian3.png", "Belgian Blue", 200m, 0, 1, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 18, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil", "/Images/Belgian/Belgian4.png", "Belgian Blue", 120m, 0, 1, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 19, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil", "/Images/Belgian/Belgian5.png", "Belgian Blue", 200m, 0, 1, 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BirthDate", "BreedCategoryId", "Description", "ImageURL", "Name", "Price", "Sex", "Status", "StockAvailable" },
                values: new object[] { 20, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, " It may also be known as the Race de la Moyenne et Haute Belgique, or dikbil", "/Images/Belgian/Belgian1.png", "Belgian Blue", 100m, 0, 1, 50 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BreedCategoryId",
                table: "Products",
                column: "BreedCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BreedCategories");
        }
    }
}
