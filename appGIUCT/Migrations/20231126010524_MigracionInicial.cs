using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appGIUCT.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IniciativaDeInvestigacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IniciativaDeInvestigacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    cuil = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    celular = table.Column<int>(type: "int", nullable: false),
                    direccionPostal = table.Column<int>(type: "int", nullable: false),
                    emailPersonal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailInsitucional = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    horasSemInvestigadas = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pid", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Universidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universidades", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormacionAcademica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docenteId = table.Column<int>(type: "int", nullable: true),
                    tutorId = table.Column<int>(type: "int", nullable: true),
                    PracticaProfesionalizante_docenteId = table.Column<int>(type: "int", nullable: true),
                    PracticaProfesionalizante_tutorId = table.Column<int>(type: "int", nullable: true),
                    docenteSupervisorId = table.Column<int>(type: "int", nullable: true),
                    PracticaSupervisadaIngenieria_tutorId = table.Column<int>(type: "int", nullable: true),
                    directorId = table.Column<int>(type: "int", nullable: true),
                    fuenteFinanciemiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TesinaLicenciatura_directorId = table.Column<int>(type: "int", nullable: true),
                    fuenteFinanciamiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TesisPosgrado_directorId = table.Column<int>(type: "int", nullable: true),
                    TesisPosgrado_fuenteFinanciamiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacionAcademica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_PracticaProfesionalizante_docenteId",
                        column: x => x.PracticaProfesionalizante_docenteId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_PracticaProfesionalizante_tutorId",
                        column: x => x.PracticaProfesionalizante_tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_PracticaSupervisadaIngenieria_tuto~",
                        column: x => x.PracticaSupervisadaIngenieria_tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_TesinaLicenciatura_directorId",
                        column: x => x.TesinaLicenciatura_directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_TesisPosgrado_directorId",
                        column: x => x.TesisPosgrado_directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_directorId",
                        column: x => x.directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_docenteId",
                        column: x => x.docenteId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_docenteSupervisorId",
                        column: x => x.docenteSupervisorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Person_tutorId",
                        column: x => x.tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_directorId",
                table: "FormacionAcademica",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_docenteId",
                table: "FormacionAcademica",
                column: "docenteId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_docenteSupervisorId",
                table: "FormacionAcademica",
                column: "docenteSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_PracticaProfesionalizante_docenteId",
                table: "FormacionAcademica",
                column: "PracticaProfesionalizante_docenteId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_PracticaProfesionalizante_tutorId",
                table: "FormacionAcademica",
                column: "PracticaProfesionalizante_tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_PracticaSupervisadaIngenieria_tutorId",
                table: "FormacionAcademica",
                column: "PracticaSupervisadaIngenieria_tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_TesinaLicenciatura_directorId",
                table: "FormacionAcademica",
                column: "TesinaLicenciatura_directorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_TesisPosgrado_directorId",
                table: "FormacionAcademica",
                column: "TesisPosgrado_directorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_tutorId",
                table: "FormacionAcademica",
                column: "tutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "FormacionAcademica");

            migrationBuilder.DropTable(
                name: "IniciativaDeInvestigacion");

            migrationBuilder.DropTable(
                name: "Pid");

            migrationBuilder.DropTable(
                name: "Universidades");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
