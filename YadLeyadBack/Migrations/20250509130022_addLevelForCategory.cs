using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class addLevelForCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
truncate table LevelsForCategories

insert into LevelsForCategories values (N'כתובת הנכס',1,'1,2');
insert into LevelsForCategories values (N'פרטי הנכס',1,'18,3,4,5,6,16,17,7,20');
insert into LevelsForCategories values (N'מאפיינים בנכס',1,'10,9,11,12,13,14,19,8');
insert into LevelsForCategories values (N'פרטי התקשרות',1,'21,22');


insert into LevelsForCategories values (N'כתובת הנכס',2,'1,2');
insert into LevelsForCategories values (N'פרטי הנכס',2,'18,3,4,5,6,16,17,7,20,23');
insert into LevelsForCategories values (N'מאפיינים בנכס',2,'10,9,12,14,19,11,13');
insert into LevelsForCategories values (N'פרטי התקשרות',2,'21,22');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
