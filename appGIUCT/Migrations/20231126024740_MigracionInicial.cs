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
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    universidadId = table.Column<int>(type: "int", nullable: false),
                    pkUniversidad = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facultad_Universidades_universidadId",
                        column: x => x.universidadId,
                        principalTable: "Universidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    pkIniciativa = table.Column<int>(type: "int", nullable: false),
                    facultadId = table.Column<int>(type: "int", nullable: false),
                    pkFacultad = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacionAcademica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Facultad_facultadId",
                        column: x => x.facultadId,
                        principalTable: "Facultad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EnsayoCatedra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    docenteId = table.Column<int>(type: "int", nullable: false),
                    tutorId = table.Column<int>(type: "int", nullable: false),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsayoCatedra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnsayoCatedra_FormacionAcademica_formacionAcademicaId",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnsayoCatedra_Person_docenteId",
                        column: x => x.docenteId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnsayoCatedra_Person_tutorId",
                        column: x => x.tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormacionAcademicaPerson",
                columns: table => new
                {
                    formacionAcademicasId = table.Column<int>(type: "int", nullable: false),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacionAcademicaPerson", x => new { x.formacionAcademicasId, x.personId });
                    table.ForeignKey(
                        name: "FK_FormacionAcademicaPerson_FormacionAcademica_formacionAcademi~",
                        column: x => x.formacionAcademicasId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademicaPerson_Person_personId",
                        column: x => x.personId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IniciativaDeInvestigacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IniciativaDeInvestigacion_FormacionAcademica_formacionAcadem~",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pid_FormacionAcademica_formacionAcademicaId",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pid_FormacionAcademica_pkFormacionAcademica",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PracticaProfesionalizante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    docenteId = table.Column<int>(type: "int", nullable: false),
                    tutorId = table.Column<int>(type: "int", nullable: false),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticaProfesionalizante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticaProfesionalizante_FormacionAcademica_formacionAcadem~",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticaProfesionalizante_Person_docenteId",
                        column: x => x.docenteId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticaProfesionalizante_Person_tutorId",
                        column: x => x.tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PracticaSupervisadaIngenieria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    docenteSupervisorId = table.Column<int>(type: "int", nullable: false),
                    tutorId = table.Column<int>(type: "int", nullable: false),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticaSupervisadaIngenieria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticaSupervisadaIngenieria_FormacionAcademica_formacionAc~",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticaSupervisadaIngenieria_Person_docenteSupervisorId",
                        column: x => x.docenteSupervisorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticaSupervisadaIngenieria_Person_tutorId",
                        column: x => x.tutorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProyectoFinalIngenieria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    directorId = table.Column<int>(type: "int", nullable: false),
                    fuenteFinanciemiento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoFinalIngenieria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoFinalIngenieria_FormacionAcademica_formacionAcademic~",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoFinalIngenieria_Person_directorId",
                        column: x => x.directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TesinaLicenciatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    directorId = table.Column<int>(type: "int", nullable: false),
                    fuenteFinanciamiento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesinaLicenciatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TesinaLicenciatura_FormacionAcademica_formacionAcademicaId",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TesinaLicenciatura_Person_directorId",
                        column: x => x.directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TesisPosgrado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    directorId = table.Column<int>(type: "int", nullable: false),
                    fuenteFinanciamiento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formacionAcademicaId = table.Column<int>(type: "int", nullable: false),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesisPosgrado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TesisPosgrado_FormacionAcademica_formacionAcademicaId",
                        column: x => x.formacionAcademicaId,
                        principalTable: "FormacionAcademica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TesisPosgrado_Person_directorId",
                        column: x => x.directorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IniciativaDeInvestigacionPerson",
                columns: table => new
                {
                    iniciativaDeInvestigacionsId = table.Column<int>(type: "int", nullable: false),
                    personId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IniciativaDeInvestigacionPerson", x => new { x.iniciativaDeInvestigacionsId, x.personId });
                    table.ForeignKey(
                        name: "FK_IniciativaDeInvestigacionPerson_IniciativaDeInvestigacion_in~",
                        column: x => x.iniciativaDeInvestigacionsId,
                        principalTable: "IniciativaDeInvestigacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IniciativaDeInvestigacionPerson_Person_personId",
                        column: x => x.personId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonPid",
                columns: table => new
                {
                    personId = table.Column<int>(type: "int", nullable: false),
                    pidsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPid", x => new { x.personId, x.pidsId });
                    table.ForeignKey(
                        name: "FK_PersonPid_Person_personId",
                        column: x => x.personId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPid_Pid_pidsId",
                        column: x => x.pidsId,
                        principalTable: "Pid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_docenteId",
                table: "EnsayoCatedra",
                column: "docenteId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_formacionAcademicaId",
                table: "EnsayoCatedra",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_tutorId",
                table: "EnsayoCatedra",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_universidadId",
                table: "Facultad",
                column: "universidadId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_facultadId",
                table: "FormacionAcademica",
                column: "facultadId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademicaPerson_personId",
                table: "FormacionAcademicaPerson",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_IniciativaDeInvestigacion_formacionAcademicaId",
                table: "IniciativaDeInvestigacion",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_IniciativaDeInvestigacionPerson_personId",
                table: "IniciativaDeInvestigacionPerson",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPid_pidsId",
                table: "PersonPid",
                column: "pidsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pid_formacionAcademicaId",
                table: "Pid",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pid_pkFormacionAcademica",
                table: "Pid",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PracticaProfesionalizante_docenteId",
                table: "PracticaProfesionalizante",
                column: "docenteId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaProfesionalizante_formacionAcademicaId",
                table: "PracticaProfesionalizante",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaProfesionalizante_tutorId",
                table: "PracticaProfesionalizante",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_docenteSupervisorId",
                table: "PracticaSupervisadaIngenieria",
                column: "docenteSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_formacionAcademicaId",
                table: "PracticaSupervisadaIngenieria",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_tutorId",
                table: "PracticaSupervisadaIngenieria",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoFinalIngenieria_directorId",
                table: "ProyectoFinalIngenieria",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoFinalIngenieria_formacionAcademicaId",
                table: "ProyectoFinalIngenieria",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TesinaLicenciatura_directorId",
                table: "TesinaLicenciatura",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_TesinaLicenciatura_formacionAcademicaId",
                table: "TesinaLicenciatura",
                column: "formacionAcademicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TesisPosgrado_directorId",
                table: "TesisPosgrado",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_TesisPosgrado_formacionAcademicaId",
                table: "TesisPosgrado",
                column: "formacionAcademicaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnsayoCatedra");

            migrationBuilder.DropTable(
                name: "FormacionAcademicaPerson");

            migrationBuilder.DropTable(
                name: "IniciativaDeInvestigacionPerson");

            migrationBuilder.DropTable(
                name: "PersonPid");

            migrationBuilder.DropTable(
                name: "PracticaProfesionalizante");

            migrationBuilder.DropTable(
                name: "PracticaSupervisadaIngenieria");

            migrationBuilder.DropTable(
                name: "ProyectoFinalIngenieria");

            migrationBuilder.DropTable(
                name: "TesinaLicenciatura");

            migrationBuilder.DropTable(
                name: "TesisPosgrado");

            migrationBuilder.DropTable(
                name: "IniciativaDeInvestigacion");

            migrationBuilder.DropTable(
                name: "Pid");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "FormacionAcademica");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "Universidades");
        }
    }
}
