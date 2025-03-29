using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "PropertyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HouseCommittee",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsThereAirCondition",
                table: "PropertyDetails",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyConditionId",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTax",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Furniture",
                columns: table => new
                {
                    FurnitureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FurnitureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furniture", x => x.FurnitureId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyConditions",
                columns: table => new
                {
                    PropertyConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyConditionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyConditions", x => x.PropertyConditionId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.PropertyTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furniture");

            migrationBuilder.DropTable(
                name: "PropertyConditions");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "HouseCommittee",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "IsThereAirCondition",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyConditionId",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyTax",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                table: "PropertyDetails");
        }
    }
}
