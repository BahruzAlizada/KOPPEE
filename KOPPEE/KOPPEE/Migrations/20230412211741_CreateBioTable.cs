using Microsoft.EntityFrameworkCore.Migrations;

namespace KOPPEE.Migrations
{
    public partial class CreateBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");
        }
    }
}
