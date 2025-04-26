using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class updateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                           truncate table fieldtypes;

INSERT INTO fieldtypes VALUES ('TextField');
INSERT INTO fieldtypes VALUES ('SelectField');
INSERT INTO fieldtypes VALUES ('CheckboxField');
INSERT INTO fieldtypes VALUES ('TextareaField');
INSERT INTO fieldtypes VALUES ('ButtonField');
INSERT INTO fieldtypes VALUES ('InputNumberField');
INSERT INTO fieldtypes VALUES ('AutoCompleteField');


update fields
set fieldtype = 6
where fieldtype = 5;


update fields
set fieldtype = 7
where fieldid = 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
