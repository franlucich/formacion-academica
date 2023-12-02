using appGIUCT.Domain.Repository;



public interface IUnitOfWork
{
    IEnsayoCatedraRepo ensayoCatedraRepo {get;}
    IPracticaProfesionalizanteRepo practicaProfesionalizanteRepo {get;}
     IPracticaSupervisadaIngenieria practicaSupervisadaIngenieriaRepo {get;}
     IProyectoFinalIngenieria proyectoFinalIngenieria {get; }
     TesinaLicenciaturaRepo tesinaLicenciatura {get; }
     TesisPosgradoRepo tesisPosgrado {get; }  
    Task CompleteAsync();
}
