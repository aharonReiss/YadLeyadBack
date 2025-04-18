using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class AddInputNumberField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                           insert into FieldTypes values ('InputNumber');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
