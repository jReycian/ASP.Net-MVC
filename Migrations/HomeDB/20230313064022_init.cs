using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo3.Migrations.HomeDB
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnersName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    myProperty = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PropertyValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
