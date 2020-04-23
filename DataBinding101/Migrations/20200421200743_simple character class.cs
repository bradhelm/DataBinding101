using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBinding101.Migrations
{
    public partial class simplecharacterclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Wisdom = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Charisma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
