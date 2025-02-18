using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YadLeyadBack.Migrations
{
    /// <inheritdoc />
    public partial class AddInsertRecordsFromXmlProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE [dbo].[usp_InsertRecordsFromXml]
                @XmlData XML
            AS
            BEGIN
                SET NOCOUNT ON;

                DECLARE @RecordsTable TABLE (
                    _id INT PRIMARY KEY,
                    TableName NVARCHAR(100),
                    CityID INT,
                    CityName NVARCHAR(255),
                    StreetID INT,
                    StreetName NVARCHAR(255)
                );

                INSERT INTO @RecordsTable (_id, TableName, CityID, CityName, StreetID, StreetName)
                SELECT 
                    T.X.value('_id[1]', 'INT'),
                    T.X.value('Table[1]', 'NVARCHAR(100)'),
                    T.X.value('CityID[1]', 'INT'),
                    T.X.value('CityName[1]', 'NVARCHAR(255)'),
                    T.X.value('StreetID[1]', 'INT'),
                    T.X.value('StreetName[1]', 'NVARCHAR(255)')
                FROM @XmlData.nodes('/Records/Record') AS T(X);

	            select rt.*
	            into #StreesNotInDB
	            from @RecordsTable rt
	            left join Streets s on rt.StreetID = s.StreetID and rt.CityID = s.CityId
	            where s.StreetID is null;


                INSERT INTO Streets(StreetName,CityId,StreetID)
                SELECT StreetName,CityID,StreetID
	            FROM #StreesNotInDB;

	            update s
	            set s.StreetName = r.StreetName
	            from Streets s join @RecordsTable r
	            on s.StreetID = r.StreetID
	            where s.CityId = r.CityID;
            END;
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
