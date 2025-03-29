using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class AddValuesForTheTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                           insert into NumberOfRooms values (1);
insert into NumberOfRooms values (2);
insert into NumberOfRooms values (3);
insert into NumberOfRooms values (4);
insert into NumberOfRooms values (5);
insert into NumberOfRooms values (6);
insert into NumberOfRooms values (7);
insert into NumberOfRooms values (8);
 insert into FieldTypes values ('TextField');
 insert into FieldTypes values ('SelectField');
 insert into FieldTypes values ('CheckboxField');
 insert into FieldTypes values ('TextareaField');
 insert into FieldTypes values ('Button');
insert into Fields values (1,N'מספר בית','houseNumber','',1,'');
insert into Fields values (1,N'כתובת הנכס','addressCityStreet','',1,'');
insert into Fields values (2,N'מספר חדרים','numberOfRoomsId','',1,'');
insert into Fields values (1,N'שטח במטר','propertySizeInMeters','',1,'');
insert into Fields values (1,N'קומה','floor','',1,'');
insert into Fields values (1,N'מחיר מבוקש','price','',1,'');
insert into Fields values (1,N'מרפסות','porchCount','',1,'');
insert into Fields values (3,N'אופציה+','isThereOptions','',1,'');
insert into Fields values (3,N'מחסן+','isThereWarehouse','',1,'');
insert into Fields values (3,N'חניה+','isThereParcking','',1,'');
insert into Fields values (3,N'מרפסת סוכה+','isThereSukaPorch','',1,'');
insert into Fields values (3,N'נוף+','isThereLandscape','',1,'');
insert into Fields values (3,N'ממד+','isThereSafeRoom','',1,'');
insert into Fields values (3,N'מעלית','isTherElevator','',1,'');
insert into Fields values (3,N'תיווך','isMediation','',1,'');
insert into Fields values (1,N'ארנונה','propertyTax','',1,'');
insert into Fields values (1,N'ועד בית','houseCommittee','',1,'');
insert into Fields values (2,N'סוג הנכס','propertyTypeId','',1,'');
insert into Fields values (3,N'מיזוג אוויר','isThereAirCondition','',1,'');
insert into Fields values (2,N'מצב הנכס','propertyConditionId','',1,'');
insert into Fields values (1,N'שם ליצירת קשר','fullName','',1,'');
insert into Fields values (1,N'טלפון לא חובה','phoneNumbers','',1,'');
insert into Fields values (2,N'ריהוט','furniture','',1,'');

insert into Furniture values (N'מלא');
insert into Furniture values (N'חלקי');
insert into Furniture values (N'ללא');

insert into PropertyConditions values (N'חדש מקבלן');
insert into PropertyConditions values (N'חדש');
insert into PropertyConditions values (N'משופץ');
insert into PropertyConditions values (N'שמור');
insert into PropertyConditions values (N'ישן');

insert into PropertyTypes values (N'בית פרטי')
insert into PropertyTypes values (N'דירת גן')
insert into PropertyTypes values (N'דופלקס')
insert into PropertyTypes values (N'דירה')
insert into PropertyTypes values (N'יחידת דיור')
insert into LevelsForCategories values ('כתובת הנכס',1,'1,2');
insert into LevelsForCategories values ('פרטי הנכס',1,'18,3,4,5,6,16,17,7,10,9,11,12,13,14,19,20,8');
insert into LevelsForCategories values ('פרטי התקשרות',1,'21,22');

insert into LevelsForCategories values ('כתובת הנכס',2,'1,2');
insert into LevelsForCategories values ('פרטי הנכס',2,'18,3,4,5,6,16,17,7,10,9,12,14,19,11,13,20,23');
insert into LevelsForCategories values ('פרטי התקשרות',2,'21,22');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
