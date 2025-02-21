using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesPropertyParasha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "NumberOfRooms",
                columns: table => new
                {
                    NumberOfRoomsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfRoomsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberOfRooms", x => x.NumberOfRoomsId);
                });

            migrationBuilder.CreateTable(
                name: "Parashot",
                columns: table => new
                {
                    ParashaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParashaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parashot", x => x.ParashaId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    ProprtyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StreeId = table.Column<int>(type: "int", nullable: false),
                    AdressNumber = table.Column<int>(type: "int", nullable: true),
                    HouseNumber = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.ProprtyId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    PropertyDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    NumberOfRoomsId = table.Column<int>(type: "int", nullable: false),
                    IsPrivateHouse = table.Column<bool>(type: "bit", nullable: false),
                    PorchCount = table.Column<int>(type: "int", nullable: false),
                    IsThereSukaPorch = table.Column<bool>(type: "bit", nullable: false),
                    IsThereParcking = table.Column<bool>(type: "bit", nullable: false),
                    IsThereWarehouse = table.Column<bool>(type: "bit", nullable: false),
                    IsThereOptions = table.Column<bool>(type: "bit", nullable: false),
                    IsThereLandscape = table.Column<bool>(type: "bit", nullable: false),
                    PropertySizeInMeters = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    IsTherElevator = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: true),
                    IsThereSafeRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsFurnished = table.Column<bool>(type: "bit", nullable: false),
                    IsMediation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyDetailId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyDetailId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_PropertyDetails_PropertyDetailId",
                        column: x => x.PropertyDetailId,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyForShabatDetails",
                columns: table => new
                {
                    PropertyForShabatDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyDetailId = table.Column<long>(type: "bigint", nullable: false),
                    CountBeds = table.Column<int>(type: "int", nullable: false),
                    ParashaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyForShabatDetails", x => x.PropertyForShabatDetailId);
                    table.ForeignKey(
                        name: "FK_PropertyForShabatDetails_PropertyDetails_PropertyDetailId",
                        column: x => x.PropertyDetailId,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_PropertyDetailId",
                table: "PhoneNumbers",
                column: "PropertyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyForShabatDetails_PropertyDetailId",
                table: "PropertyForShabatDetails",
                column: "PropertyDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "NumberOfRooms");

            migrationBuilder.DropTable(
                name: "Parashot");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "PropertyForShabatDetails");

            migrationBuilder.DropTable(
                name: "PropertyDetails");
        }
    }
}
