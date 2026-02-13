using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeroRPG.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDesignAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StrengthModifier = table.Column<int>(type: "int", nullable: false),
                    DexterityModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionModifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "ConstitutionModifier", "DexterityModifier", "Name", "StrengthModifier" },
                values: new object[,]
                {
                    { 1, 1, 1, "Human", 1 },
                    { 2, -1, 3, "Elf", 0 },
                    { 3, 2, -1, "Dwarf", 2 },
                    { 4, 1, -1, "Orc", 3 },
                    { 5, -1, 4, "Halfling", -1 }
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Constitution", "Description", "Dexterity", "Name", "RaceID", "Strength" },
                values: new object[,]
                {
                    { 1, 8, "A quick-footed scout.", 15, "Arlen Swift", 2, 10 },
                    { 2, 14, "Stout warrior and miner.", 8, "Borin Stonehelm", 3, 16 },
                    { 3, 12, "Fearsome berserker.", 9, "Thora Ironfist", 4, 18 },
                    { 4, 10, "Clever trickster.", 16, "Lysa Meadow", 5, 8 },
                    { 5, 13, "Knight of the realm.", 12, "Sir Gareth", 1, 14 },
                    { 6, 9, "Archer and herbalist.", 14, "Mira Greenleaf", 2, 9 },
                    { 7, 15, "Defender of the halls.", 9, "Torik Broadshield", 3, 15 },
                    { 8, 11, "Headsnatcha extraordinaire.", 10, "Orin Blacktusk", 4, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_RaceID",
                table: "Heroes",
                column: "RaceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
