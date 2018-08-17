using Microsoft.EntityFrameworkCore.Migrations;

namespace CSVtoDB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    MobileNum = table.Column<string>(nullable: true),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<double>(nullable: false),
                    Union_Ward = table.Column<string>(nullable: true),
                    Thana = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    Distance = table.Column<double>(nullable: false),
                    StreetAddr = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    AverAge6 = table.Column<double>(nullable: false),
                    AverAge7 = table.Column<double>(nullable: false),
                    AverAge8 = table.Column<double>(nullable: false),
                    AverAge9 = table.Column<double>(nullable: false),
                    AverAgeX = table.Column<double>(nullable: false),
                    MFRatio = table.Column<double>(nullable: false),
                    TSRatio = table.Column<double>(nullable: false),
                    SEScore1 = table.Column<double>(nullable: false),
                    SEScore2 = table.Column<double>(nullable: false),
                    SEScore3 = table.Column<double>(nullable: false),
                    SEScore4 = table.Column<double>(nullable: false),
                    SES = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
