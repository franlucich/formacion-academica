using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appGIUCT.Migrations
{
    /// <inheritdoc />
    public partial class NuevaMi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat",
                column: "pkIniciativa",
                principalTable: "IniciativaDeInvestigacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat",
                column: "PersonaId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat",
                column: "pkIniciativa",
                principalTable: "IniciativaDeInvestigacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat",
                column: "PersonaId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
