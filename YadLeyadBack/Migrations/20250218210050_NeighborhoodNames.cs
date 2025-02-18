using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class NeighborhoodNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into Neighborhoods (NeighborhoodName,CityId) values (N'א.ת ברוש,בית שמש מערב',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'א.ת הר-טוב',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'א.ת צפוני',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'א.ת שורק-נוחם',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'א.ת שורק-נוחם',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'גבעת משקפיים',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'גבעת שרת',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'הקריה החרדית',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'חזון עובדיה,רמת בית שמש ג--2',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'ממזרח שמש',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'נווה שמיר ,רמת בית שמש ה-1',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'פסגות השבע',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'קנה בושם,חפציבה',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'קרית אריה,שיינפלד',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת אבי עזרי,רמת בית שמש ג-1',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת אברהם',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת בית שמש ה-2',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת האמוראים,רמת בית שמש ד-1',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת האמוראים,רמת בית שמש ד-2',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת האמוראים,רמת בית שמש ד-3',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת האמוראים,רמת בית שמש ד-4',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת האמוראים,רמת בית שמש ד-5',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת הנחלים,רמת בית שמש א',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת התנאים,רמת בית שמש ב',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'רמת משה,בית שמש הוותיקה',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'שכונת המע""ר',2610);
insert into Neighborhoods (NeighborhoodName,CityId) values (N'שכונת מ-3',2610);
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
