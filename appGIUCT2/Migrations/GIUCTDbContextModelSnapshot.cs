﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace appGIUCT.Migrations
{
    [DbContext(typeof(GIUCTDbContext))]
    partial class GIUCTDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PersonaIniciat", b =>
                {
                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("pkIniciativa")
                        .HasColumnType("int");

                    b.Property<int?>("IniciativaDeInvestigacionId")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PersonaId", "pkIniciativa");

                    b.HasIndex("IniciativaDeInvestigacionId");

                    b.HasIndex("pkIniciativa");

                    b.ToTable("PersonaIniciat");
                });

            modelBuilder.Entity("PersonaPID", b =>
                {
                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("PIDId")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PersonaId", "PIDId");

                    b.HasIndex("PIDId");

                    b.ToTable("PersonaPID");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.EnsayoCatedra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("docenteId")
                        .HasColumnType("int");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("docenteId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.HasIndex("tutorId");

                    b.ToTable("EnsayoCatedra");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Facultad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("pkUniversidad")
                        .HasColumnType("int");

                    b.Property<int>("universidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("universidadId");

                    b.ToTable("Facultad");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.FormacionAcademica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("facultadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("personaId")
                        .HasColumnType("int");

                    b.Property<int>("pkFacultad")
                        .HasColumnType("int");

                    b.Property<int>("pkIniciativa")
                        .HasColumnType("int");

                    b.Property<int>("pkPersona")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("facultadId");

                    b.HasIndex("personaId");

                    b.ToTable("FormacionAcademicas");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("codigo")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("IniciativaDeInvestigacion");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PidId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("celular")
                        .HasColumnType("int");

                    b.Property<int>("cuil")
                        .HasColumnType("int");

                    b.Property<int>("direccionPostal")
                        .HasColumnType("int");

                    b.Property<string>("emailInsitucional")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("emailPersonal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("horasSemInvestigadas")
                        .HasColumnType("int");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PidId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Pid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("codigo")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.ToTable("Pid");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.PracticaProfesionalizante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("docenteId")
                        .HasColumnType("int");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("docenteId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.HasIndex("tutorId");

                    b.ToTable("PracticaProfesionalizante");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.PracticaSupervisadaIngenieria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("docenteSupervisorId")
                        .HasColumnType("int");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("docenteSupervisorId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.HasIndex("tutorId");

                    b.ToTable("PracticaSupervisadaIngenieria");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.ProyectoFinalIngenieria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("directorId")
                        .HasColumnType("int");

                    b.Property<string>("fuenteFinanciemiento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("directorId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.ToTable("ProyectoFinalIngenieria");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.TesinaLicenciatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("directorId")
                        .HasColumnType("int");

                    b.Property<string>("fuenteFinanciamiento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("directorId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.ToTable("TesinaLicenciatura");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.TesisPosgrado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("directorId")
                        .HasColumnType("int");

                    b.Property<string>("fuenteFinanciamiento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("pkFormacionAcademica")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("directorId");

                    b.HasIndex("pkFormacionAcademica")
                        .IsUnique();

                    b.ToTable("TesisPosgrado");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Universidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Universidades");
                });

            modelBuilder.Entity("PersonaIniciat", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", null)
                        .WithMany("Integrantes")
                        .HasForeignKey("IniciativaDeInvestigacionId");

                    b.HasOne("appGIUCT.Domain.Entities.Person", "person")
                        .WithMany("IIComoIntegrante")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", "iniciativaDeInvestigacion")
                        .WithMany("persona")
                        .HasForeignKey("pkIniciativa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("iniciativaDeInvestigacion");

                    b.Navigation("person");
                });

            modelBuilder.Entity("PersonaPID", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Pid", "PID")
                        .WithMany("Integrantes")
                        .HasForeignKey("PIDId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.Person", "person")
                        .WithMany("PIDsComoIntegrante")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PID");

                    b.Navigation("person");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.EnsayoCatedra", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "docente")
                        .WithMany()
                        .HasForeignKey("docenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("ensayoCatedra")
                        .HasForeignKey("appGIUCT.Domain.Entities.EnsayoCatedra", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.Person", "tutor")
                        .WithMany()
                        .HasForeignKey("tutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("docente");

                    b.Navigation("formacionAcademicas");

                    b.Navigation("tutor");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Facultad", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Universidad", "universidad")
                        .WithMany("facultades")
                        .HasForeignKey("universidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("universidad");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.FormacionAcademica", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Facultad", "facultad")
                        .WithMany()
                        .HasForeignKey("facultadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.Person", "persona")
                        .WithMany()
                        .HasForeignKey("personaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("facultad");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "Director")
                        .WithMany("iniciativaDeInvestigacions")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", null)
                        .WithOne("IniciativaDeInvestigacion")
                        .HasForeignKey("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Person", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Pid", null)
                        .WithMany("person")
                        .HasForeignKey("PidId");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Pid", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "Director")
                        .WithMany("PIDsDirigidos")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademica")
                        .WithOne("Pid")
                        .HasForeignKey("appGIUCT.Domain.Entities.Pid", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("formacionAcademica");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.PracticaProfesionalizante", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "docente")
                        .WithMany()
                        .HasForeignKey("docenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("practicaProfesionalizante")
                        .HasForeignKey("appGIUCT.Domain.Entities.PracticaProfesionalizante", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.Person", "tutor")
                        .WithMany()
                        .HasForeignKey("tutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("docente");

                    b.Navigation("formacionAcademicas");

                    b.Navigation("tutor");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.PracticaSupervisadaIngenieria", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "docenteSupervisor")
                        .WithMany()
                        .HasForeignKey("docenteSupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("practicaSupervisadaIngenieria")
                        .HasForeignKey("appGIUCT.Domain.Entities.PracticaSupervisadaIngenieria", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.Person", "tutor")
                        .WithMany()
                        .HasForeignKey("tutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("docenteSupervisor");

                    b.Navigation("formacionAcademicas");

                    b.Navigation("tutor");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.ProyectoFinalIngenieria", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "director")
                        .WithMany()
                        .HasForeignKey("directorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("proyectoFinalIngenieria")
                        .HasForeignKey("appGIUCT.Domain.Entities.ProyectoFinalIngenieria", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("director");

                    b.Navigation("formacionAcademicas");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.TesinaLicenciatura", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "director")
                        .WithMany()
                        .HasForeignKey("directorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("tesinaLicenciatura")
                        .HasForeignKey("appGIUCT.Domain.Entities.TesinaLicenciatura", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("director");

                    b.Navigation("formacionAcademicas");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.TesisPosgrado", b =>
                {
                    b.HasOne("appGIUCT.Domain.Entities.Person", "director")
                        .WithMany()
                        .HasForeignKey("directorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("appGIUCT.Domain.Entities.FormacionAcademica", "formacionAcademicas")
                        .WithOne("tesisPosgrado")
                        .HasForeignKey("appGIUCT.Domain.Entities.TesisPosgrado", "pkFormacionAcademica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("director");

                    b.Navigation("formacionAcademicas");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.FormacionAcademica", b =>
                {
                    b.Navigation("IniciativaDeInvestigacion")
                        .IsRequired();

                    b.Navigation("Pid")
                        .IsRequired();

                    b.Navigation("ensayoCatedra")
                        .IsRequired();

                    b.Navigation("practicaProfesionalizante")
                        .IsRequired();

                    b.Navigation("practicaSupervisadaIngenieria")
                        .IsRequired();

                    b.Navigation("proyectoFinalIngenieria")
                        .IsRequired();

                    b.Navigation("tesinaLicenciatura")
                        .IsRequired();

                    b.Navigation("tesisPosgrado")
                        .IsRequired();
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.IniciativaDeInvestigacion", b =>
                {
                    b.Navigation("Integrantes");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Person", b =>
                {
                    b.Navigation("IIComoIntegrante");

                    b.Navigation("PIDsComoIntegrante");

                    b.Navigation("PIDsDirigidos");

                    b.Navigation("iniciativaDeInvestigacions");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Pid", b =>
                {
                    b.Navigation("Integrantes");

                    b.Navigation("person");
                });

            modelBuilder.Entity("appGIUCT.Domain.Entities.Universidad", b =>
                {
                    b.Navigation("facultades");
                });
#pragma warning restore 612, 618
        }
    }
}
