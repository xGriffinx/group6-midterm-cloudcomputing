using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playersstatistics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Gamesplayed = table.Column<int>(nullable: true),
                    Passescompleted = table.Column<int>(nullable: true),
                    Fantasypoints = table.Column<int>(nullable: true),
                    Pprscoring = table.Column<double>(nullable: true),
                    Posrank = table.Column<int>(nullable: true),
                    Week1 = table.Column<string>(nullable: true),
                    Week2 = table.Column<string>(nullable: true),
                    Week3 = table.Column<string>(nullable: true),
                    Week4 = table.Column<string>(nullable: true),
                    Week5 = table.Column<string>(nullable: true),
                    Week6 = table.Column<string>(nullable: true),
                    Week7 = table.Column<string>(nullable: true),
                    Week8 = table.Column<string>(nullable: true),
                    Week9 = table.Column<string>(nullable: true),
                    Week10 = table.Column<string>(nullable: true),
                    Week11 = table.Column<string>(nullable: true),
                    Week12 = table.Column<string>(nullable: true),
                    Week13 = table.Column<string>(nullable: true),
                    Week14 = table.Column<string>(nullable: true),
                    Week15 = table.Column<string>(nullable: true),
                    Week16 = table.Column<string>(nullable: true),
                    Week17 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playersstatistics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "userType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Member1 = table.Column<string>(nullable: true),
                    Member2 = table.Column<string>(nullable: true),
                    Member3 = table.Column<string>(nullable: true),
                    Member4 = table.Column<string>(nullable: true),
                    Member5 = table.Column<string>(nullable: true),
                    Member6 = table.Column<string>(nullable: true),
                    Member7 = table.Column<string>(nullable: true),
                    Member8 = table.Column<string>(nullable: true),
                    Member9 = table.Column<string>(nullable: true),
                    Member10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userType", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Playersstatistics");

            migrationBuilder.DropTable(
                name: "userType");
        }
    }
}
