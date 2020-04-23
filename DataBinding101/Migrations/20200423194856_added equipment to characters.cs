using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBinding101.Migrations
{
    public partial class addedequipmenttocharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    OwnerCharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipment_Characters_OwnerCharacterId",
                        column: x => x.OwnerCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_OwnerCharacterId",
                table: "Equipment",
                column: "OwnerCharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}
