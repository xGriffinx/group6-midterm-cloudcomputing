using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class AddProperty2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playersstatistics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(nullable: false),
                    Player = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gamesplayed = table.Column<int>(nullable: false),
                    Passescompleted = table.Column<int>(nullable: false),
                    Fantasypoints = table.Column<int>(nullable: false),
                    Pprscoring = table.Column<float>(nullable: false),
                    Posrank = table.Column<int>(nullable: false),
                    week1 = table.Column<string>(nullable: true),
                    week2 = table.Column<string>(nullable: true),
                    week3 = table.Column<string>(nullable: true),
                    week4 = table.Column<string>(nullable: true),
                    week5 = table.Column<string>(nullable: true),
                    week6 = table.Column<string>(nullable: true),
                    week7 = table.Column<string>(nullable: true),
                    week8 = table.Column<string>(nullable: true),
                    week9 = table.Column<string>(nullable: true),
                    week10 = table.Column<string>(nullable: true),
                    week11 = table.Column<string>(nullable: true),
                    week12 = table.Column<string>(nullable: true),
                    week13 = table.Column<string>(nullable: true),
                    week14 = table.Column<string>(nullable: true),
                    week15 = table.Column<string>(nullable: true),
                    week16 = table.Column<string>(nullable: true),
                    week17 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playersstatistics", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Playersstatistics");
        }
    }
}
