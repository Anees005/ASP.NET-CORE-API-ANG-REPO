using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo_Angular_Core.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShirtNo = table.Column<int>(type: "int", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Appearances = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Appearances", "Goals", "Name", "Position", "ShirtNo" },
                values: new object[,]
                {
                    { 1, 500, 54, "C. Ronaldo", 3, 7 },
                    { 2, 285, 28, "Paul Pogba", 2, 6 },
                    { 3, 335, 33, "David de Gea", 0, 2 },
                    { 4, 200, 25, "Phil Jones", 1, 5 },
                    { 5, 430, 50, "Lionel Messi", 4, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
