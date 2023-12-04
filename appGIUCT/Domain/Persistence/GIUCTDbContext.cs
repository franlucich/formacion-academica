using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using appGIUCT.Domain.Entities;


public class GIUCTDbContext : DbContext 
{
    // entities 
    public DbSet<EnsayoCatedra> EnsayoCatedra { get; set; }
    public DbSet<Facultad> Facultad {get; set;}
    public DbSet<IniciativaDeInvestigacion> IniciativaDeInvestigacion {get; set;}
    public DbSet<Person> Person {get; set;}
    public DbSet<Pid> Pid {get; set;}
    public DbSet<PracticaProfesionalizante> PracticaProfesionalizante {get; set;}
    public DbSet<PracticaSupervisadaIngenieria> PracticaSupervisadaIngenieria {get; set;}
    public DbSet<ProyectoFinalIngenieria> ProyectoFinalIngenieria {get; set;}
    public DbSet<TesinaLicenciatura> TesinaLicenciatura {get; set;}
    public DbSet<TesisPosgrado> TesisPosgrado {get; set;}
    public DbSet<Universidad> Universidades {get; set;}

    public string DbPath { get; }
    public object FormacionAcademicas { get; internal set; }

    public GIUCTDbContext(){
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseMySql("server=localhost;port=3311;database=pruebaDis;user=root;password=Qzcb1357-",
        new MySqlServerVersion(new Version(8, 0, 34)));  
    }

    
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    
    //RELACION UNO A UNO ENTRE FORMACADEMICA Y PID
    modelBuilder.Entity<FormacionAcademica>()
        .HasOne(fa => fa.Pid)
        .WithOne(pid => pid.formacionAcademica)
        .HasForeignKey<Pid>(pid => pid.pkFormacionAcademica);

    //RELACION UNO A UNO ENTRE FORMACION ACADEMICA E INICIATIVA DE INVESTIGACION

    modelBuilder.Entity<FormacionAcademica>()
    .HasOne(fa => fa.IniciativaDeInvestigacion)
    .WithOne()
    .HasForeignKey<IniciativaDeInvestigacion>(ii => ii.Id);
    

 //RELACION MUCHOS A MUCHOS PERSONA FORM ACADEMICA

    modelBuilder.Entity<Person>()
    .HasMany(p => p.FormacionesAcademicas)
    .WithMany(fa => fa.persona)
    .UsingEntity(j => j.ToTable("PersonFormacionAcademica"))
        
    ;
   

modelBuilder.Entity<PersonaIniciat>()
    .HasOne(pi => pi.person)
    .WithMany(p => p.IIComoIntegrante)
    .HasForeignKey(pi => pi.PersonaId);

modelBuilder.Entity<PersonaIniciat>()
    .HasOne(pi => pi.iniciativaDeInvestigacion)
    .WithMany(ii => ii.persona)
    .HasForeignKey(pi => pi.pkIniciativa);


    

    //RELACION ENTRE PERSONA Y II

     // Configuración para la relación uno a muchos (un director puede estar asociado a más de una II)
        modelBuilder.Entity<Person>()
        .HasMany(p => p.iniciativaDeInvestigacions)
        .WithOne(pid => pid.Director)
        .HasForeignKey(pid => pid.DirectorId)
        .OnDelete(DeleteBehavior.Restrict);


        // Configuración para la relación muchos a uno (una II tiene un director)
        modelBuilder.Entity<IniciativaDeInvestigacion>()
            .HasOne(ii => ii.Director)
            .WithMany(p => p.iniciativaDeInvestigacions)
            .HasForeignKey(ii => ii.DirectorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configuración para la relación muchos a muchos (una II puede tener varios integrantes)
        modelBuilder.Entity<PersonaIniciat>()
            .HasKey(pp => new { pp.PersonaId, pp.pkIniciativa});

    
        modelBuilder.Entity<PersonaPID>()
            .HasOne(pp => pp.PID)
            .WithMany(pid => pid.Integrantes)
            .HasForeignKey(pp => pp.PIDId)
            .OnDelete(DeleteBehavior.Restrict);

    


     // Relación uno a muchos (un director puede estar asociado a más de un PID)
        modelBuilder.Entity<Person>()
            .HasMany(p => p.PIDsDirigidos)
            .WithOne(pid => pid.Director)
            .HasForeignKey(pid => pid.DirectorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación muchos a uno (un PID tiene un director)
        modelBuilder.Entity<Pid>()
            .HasOne(pid => pid.Director)
            .WithMany(p => p.PIDsDirigidos)
            .HasForeignKey(pid => pid.DirectorId)
            .OnDelete(DeleteBehavior.Restrict)
    
           .IsRequired(false);

        //Relación muchos a muchos (un PID puede tener varios integrantes)
        modelBuilder.Entity<PersonaPID>()
            .HasKey(pp => new { pp.PersonaId, pp.PIDId });

        modelBuilder.Entity<PersonaPID>()
            .HasOne(pp => pp.person)
            .WithMany(p => p.PIDsComoIntegrante)
            .HasForeignKey(pp => pp.PersonaId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PersonaPID>()
            .HasOne(pp => pp.PID)
            .WithMany(pid => pid.Integrantes)
            .HasForeignKey(pp => pp.PIDId)
            .OnDelete(DeleteBehavior.Restrict);


    //HERENCIA DE FORMACION ACADEMICA

    modelBuilder.Entity<FormacionAcademica>().UseTpcMappingStrategy();
    modelBuilder.Entity<EnsayoCatedra>();
    modelBuilder.Entity<TesisPosgrado>();
    modelBuilder.Entity<TesinaLicenciatura>();
    modelBuilder.Entity<ProyectoFinalIngenieria>();
    modelBuilder.Entity<PracticaSupervisadaIngenieria>();
    modelBuilder.Entity<PracticaProfesionalizante>();

  

    }


}