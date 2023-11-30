using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appGIUCT.Migrations
{
    /// <inheritdoc />
    public partial class NuevaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                name: "EnsayoCatedra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    docenteId = table.Column<int>(type: "int", nullable: false),
                    tutorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsayoCatedra", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormacionAcademicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    personaId = table.Column<int>(type: "int", nullable: false),
                    pkPersona = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_FormacionAcademicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormacionAcademicas_Facultad_facultadId",
                        column: x => x.facultadId,
                        principalTable: "Facultad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IniciativaDeInvestigacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IniciativaDeInvestigacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IniciativaDeInvestigacion_FormacionAcademicas_Id",
                        column: x => x.Id,
                        principalTable: "FormacionAcademicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    PidId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonaIniciat",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    pkIniciativa = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IniciativaDeInvestigacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaIniciat", x => new { x.PersonaId, x.pkIniciativa });
                    table.ForeignKey(
                        name: "FK_PersonaIniciat_IniciativaDeInvestigacion_IniciativaDeInvesti~",
                        column: x => x.IniciativaDeInvestigacionId,
                        principalTable: "IniciativaDeInvestigacion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonaIniciat_IniciativaDeInvestigacion_pkIniciativa",
                        column: x => x.pkIniciativa,
                        principalTable: "IniciativaDeInvestigacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaIniciat_Person_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Person",
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pid_FormacionAcademicas_pkFormacionAcademica",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pid_Person_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticaProfesionalizante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticaProfesionalizante_FormacionAcademicas_pkFormacionAca~",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticaSupervisadaIngenieria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticaSupervisadaIngenieria_FormacionAcademicas_pkFormacio~",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoFinalIngenieria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoFinalIngenieria_FormacionAcademicas_pkFormacionAcade~",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesinaLicenciatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TesinaLicenciatura_FormacionAcademicas_pkFormacionAcademica",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
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
                    pkFormacionAcademica = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesisPosgrado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TesisPosgrado_FormacionAcademicas_pkFormacionAcademica",
                        column: x => x.pkFormacionAcademica,
                        principalTable: "FormacionAcademicas",
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
                name: "PersonaPID",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    PIDId = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaPID", x => new { x.PersonaId, x.PIDId });
                    table.ForeignKey(
                        name: "FK_PersonaPID_Person_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaPID_Pid_PIDId",
                        column: x => x.PIDId,
                        principalTable: "Pid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_docenteId",
                table: "EnsayoCatedra",
                column: "docenteId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_pkFormacionAcademica",
                table: "EnsayoCatedra",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnsayoCatedra_tutorId",
                table: "EnsayoCatedra",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_universidadId",
                table: "Facultad",
                column: "universidadId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademicas_facultadId",
                table: "FormacionAcademicas",
                column: "facultadId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademicas_personaId",
                table: "FormacionAcademicas",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_IniciativaDeInvestigacion_DirectorId",
                table: "IniciativaDeInvestigacion",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PidId",
                table: "Person",
                column: "PidId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaIniciat_IniciativaDeInvestigacionId",
                table: "PersonaIniciat",
                column: "IniciativaDeInvestigacionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaIniciat_pkIniciativa",
                table: "PersonaIniciat",
                column: "pkIniciativa");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaPID_PIDId",
                table: "PersonaPID",
                column: "PIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Pid_DirectorId",
                table: "Pid",
                column: "DirectorId");

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
                name: "IX_PracticaProfesionalizante_pkFormacionAcademica",
                table: "PracticaProfesionalizante",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PracticaProfesionalizante_tutorId",
                table: "PracticaProfesionalizante",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_docenteSupervisorId",
                table: "PracticaSupervisadaIngenieria",
                column: "docenteSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_pkFormacionAcademica",
                table: "PracticaSupervisadaIngenieria",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PracticaSupervisadaIngenieria_tutorId",
                table: "PracticaSupervisadaIngenieria",
                column: "tutorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoFinalIngenieria_directorId",
                table: "ProyectoFinalIngenieria",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoFinalIngenieria_pkFormacionAcademica",
                table: "ProyectoFinalIngenieria",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TesinaLicenciatura_directorId",
                table: "TesinaLicenciatura",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_TesinaLicenciatura_pkFormacionAcademica",
                table: "TesinaLicenciatura",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TesisPosgrado_directorId",
                table: "TesisPosgrado",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_TesisPosgrado_pkFormacionAcademica",
                table: "TesisPosgrado",
                column: "pkFormacionAcademica",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EnsayoCatedra_FormacionAcademicas_pkFormacionAcademica",
                table: "EnsayoCatedra",
                column: "pkFormacionAcademica",
                principalTable: "FormacionAcademicas",
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
                name: "FK_FormacionAcademicas_Person_personaId",
                table: "FormacionAcademicas",
                column: "personaId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IniciativaDeInvestigacion_Person_DirectorId",
                table: "IniciativaDeInvestigacion",
                column: "DirectorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Pid_PidId",
                table: "Person",
                column: "PidId",
                principalTable: "Pid",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pid_FormacionAcademicas_pkFormacionAcademica",
                table: "Pid");

            migrationBuilder.DropForeignKey(
                name: "FK_Pid_Person_DirectorId",
                table: "Pid");

            migrationBuilder.DropTable(
                name: "EnsayoCatedra");

            migrationBuilder.DropTable(
                name: "PersonaIniciat");

            migrationBuilder.DropTable(
                name: "PersonaPID");

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
                name: "FormacionAcademicas");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "Universidades");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Pid");
        }
    }
}
