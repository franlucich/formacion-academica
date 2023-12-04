using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appGIUCT.Migrations
{
    /// <inheritdoc />
    public partial class Nuev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Facultad_facultadId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Person_docenteId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Person_tutorId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticaProfesionalizante_Facultad_facultadId",
                table: "PracticaProfesionalizante");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticaSupervisadaIngenieria_Facultad_facultadId",
                table: "PracticaSupervisadaIngenieria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoFinalIngenieria_Facultad_facultadId",
                table: "ProyectoFinalIngenieria");

            migrationBuilder.DropForeignKey(
                name: "FK_TesinaLicenciatura_Facultad_facultadId",
                table: "TesinaLicenciatura");

            migrationBuilder.DropForeignKey(
                name: "FK_TesisPosgrado_Facultad_facultadId",
                table: "TesisPosgrado");

            migrationBuilder.DropForeignKey(
                name: "FK_TesisPosgrado_Person_directorId",
                table: "TesisPosgrado");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "TesisPosgrado",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "TesisPosgrado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "fuenteFinanciamiento",
                table: "TesisPosgrado",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "TesisPosgrado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "directorId",
                table: "TesisPosgrado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "TesinaLicenciatura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "TesinaLicenciatura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "ProyectoFinalIngenieria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "ProyectoFinalIngenieria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "PracticaSupervisadaIngenieria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "PracticaSupervisadaIngenieria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "PracticaProfesionalizante",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "PracticaProfesionalizante",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "tutorId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "EnsayoCatedra",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "docenteId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Facultad_facultadId",
                table: "EnsayoCatedra",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Person_docenteId",
                table: "EnsayoCatedra",
                column: "docenteId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Person_tutorId",
                table: "EnsayoCatedra",
                column: "tutorId",
                principalTable: "Person",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PracticaProfesionalizante_Facultad_facultadId",
                table: "PracticaProfesionalizante",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PracticaSupervisadaIngenieria_Facultad_facultadId",
                table: "PracticaSupervisadaIngenieria",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoFinalIngenieria_Facultad_facultadId",
                table: "ProyectoFinalIngenieria",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TesinaLicenciatura_Facultad_facultadId",
                table: "TesinaLicenciatura",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TesisPosgrado_Facultad_facultadId",
                table: "TesisPosgrado",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TesisPosgrado_Person_directorId",
                table: "TesisPosgrado",
                column: "directorId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Facultad_facultadId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Person_docenteId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_EnsayoCatedra_Person_tutorId",
                table: "EnsayoCatedra");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaIniciat_Person_PersonaId",
                table: "PersonaIniciat");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticaProfesionalizante_Facultad_facultadId",
                table: "PracticaProfesionalizante");

            migrationBuilder.DropForeignKey(
                name: "FK_PracticaSupervisadaIngenieria_Facultad_facultadId",
                table: "PracticaSupervisadaIngenieria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoFinalIngenieria_Facultad_facultadId",
                table: "ProyectoFinalIngenieria");

            migrationBuilder.DropForeignKey(
                name: "FK_TesinaLicenciatura_Facultad_facultadId",
                table: "TesinaLicenciatura");

            migrationBuilder.DropForeignKey(
                name: "FK_TesisPosgrado_Facultad_facultadId",
                table: "TesisPosgrado");

            migrationBuilder.DropForeignKey(
                name: "FK_TesisPosgrado_Person_directorId",
                table: "TesisPosgrado");

            migrationBuilder.UpdateData(
                table: "TesisPosgrado",
                keyColumn: "tipo",
                keyValue: null,
                column: "tipo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "TesisPosgrado",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "TesisPosgrado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TesisPosgrado",
                keyColumn: "fuenteFinanciamiento",
                keyValue: null,
                column: "fuenteFinanciamiento",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "fuenteFinanciamiento",
                table: "TesisPosgrado",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "TesisPosgrado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "directorId",
                table: "TesisPosgrado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "TesinaLicenciatura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "TesinaLicenciatura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "ProyectoFinalIngenieria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "ProyectoFinalIngenieria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "PracticaSupervisadaIngenieria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "PracticaSupervisadaIngenieria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "PracticaProfesionalizante",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "PracticaProfesionalizante",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tutorId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pkIniciativa",
                table: "EnsayoCatedra",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facultadId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "docenteId",
                table: "EnsayoCatedra",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Facultad_facultadId",
                table: "EnsayoCatedra",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Person_docenteId",
                table: "EnsayoCatedra",
                column: "docenteId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_Person_tutorId",
                table: "EnsayoCatedra",
                column: "tutorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PracticaProfesionalizante_Facultad_facultadId",
                table: "PracticaProfesionalizante",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PracticaSupervisadaIngenieria_Facultad_facultadId",
                table: "PracticaSupervisadaIngenieria",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoFinalIngenieria_Facultad_facultadId",
                table: "ProyectoFinalIngenieria",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TesinaLicenciatura_Facultad_facultadId",
                table: "TesinaLicenciatura",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TesisPosgrado_Facultad_facultadId",
                table: "TesisPosgrado",
                column: "facultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TesisPosgrado_Person_directorId",
                table: "TesisPosgrado",
                column: "directorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
