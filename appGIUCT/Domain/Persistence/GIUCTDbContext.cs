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
    public DbSet<FormacionAcademica> FormacionAcademica {get; set;}
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

    public GIUCTDbContext(){
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseMySql("server=localhost;port=3309;database=FormA;user=root;password=Qzcb1357-",
        new MySqlServerVersion(new Version(8, 0, 34)));  
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<FormacionAcademica>()
        .HasOne(fa => fa.Pid)
        .WithOne()
        .HasForeignKey<Pid>(pid => pid.pkFormacionAcademica);
}


}