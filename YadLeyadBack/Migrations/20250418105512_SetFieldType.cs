using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class SetFieldType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                           update Fields
                        set FieldType = 5
                        where FieldId in (1,
                        4,
                        5,
                        6,
                        7,
                        7,
                        7,
                        16,
                        17)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
