using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using appGIUCT.Domain.entities;
using System.Data.Entity;

public class GIUCTDbContext : DbContext 
{
    // entities 
    public Dbset<EnsayoCatedra> EnsayoCatedra {get; set;}
    public Dbset<Facultad> Facultad {get; set;}
    public Dbset<FormacionAcademica> FormacionAcademica {get; set;}
    public Dbset<IniciativaDeInvestigacion> IniciativaDeInvestigacion {get; set;}
    public Dbset<Person> Person {get; set;}
    public Dbset<Pid> Pid {get; set;}
    public Dbset<PracticaProfesionalizante> PracticaProfesionalizante {get; set;}
    public Dbset<PracticaSupervisadaIngenieria> PracticaSupervisadaIngenieria {get; set;}
    public Dbset<ProyectoFinalIngenieria> ProyectoFinalIngenieria {get; set;}
    public Dbset<TesinaLicenciatura> TesinaLicenciatura {get; set;}
    public Dbset<TesisPosgrado> TesisPosgrado {get; set;}
    public Dbset<Universidad> Universidades {get; set;}

    public GIUCTDbContext(){
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;port=3309;database=FormA;user=root;password=Qzcb579-",
            new MySqlServerVersion(new Version(8, 0, 34)));
    }
    
      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

}