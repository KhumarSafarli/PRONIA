using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronia.Migrations
{
    public partial class createdPlantInformationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    InformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantInformations_Informations_InformationId",
                        column: x => x.InformationId,
                        principalTable: "Informations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantInformations_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantInformations_InformationId",
                table: "PlantInformations",
                column: "InformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantInformations_PlantId",
                table: "PlantInformations",
                column: "PlantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantInformations");
        }
    }
}
