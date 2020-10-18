using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "userType");
        }
    }
}
