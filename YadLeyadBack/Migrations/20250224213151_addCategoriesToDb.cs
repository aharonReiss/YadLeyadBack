using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class addCategoriesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                            insert into categories (CategoryName,IsEnable) values (N'דירות למכירה',1);
                            insert into categories (CategoryName,IsEnable) values (N'דירות להשכרה',1);
                            insert into categories (CategoryName,IsEnable) values (N'יחידות דיור',1);
                            insert into categories (CategoryName,IsEnable) values (N'דרושים',1);
                            insert into categories (CategoryName,IsEnable) values (N'דירות לשבת',1);
                            insert into categories (CategoryName,IsEnable) values (N'פרויקטים',1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
