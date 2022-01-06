using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShowroom.Migrations
{
    public partial class Bikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeNums = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeModel = table.Column<int>(type: "int", nullable: false),
                    BikeVerison = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeNums);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");
        }
    }
}
