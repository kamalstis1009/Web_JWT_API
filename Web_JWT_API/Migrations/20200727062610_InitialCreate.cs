using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_JWT_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MIS_Authenticate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(maxLength: 250, nullable: false),
                    Password = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MIS_Authenticate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MIS_Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 250, nullable: false),
                    ProductQty = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MIS_Product", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MIS_Authenticate");

            migrationBuilder.DropTable(
                name: "MIS_Product");
        }
    }
}
