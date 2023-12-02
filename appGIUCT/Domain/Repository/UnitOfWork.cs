using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;

public class UnitOfWork : IUnitOfWork, IDisposable      //Se implementan dos interfaces 
{
    private readonly GIUCTDbContext _context;       //Instancia para acceder a la base de datos 
    private readonly ILogger _logger;       //Instancia de un logger para registrar informacion
   
   
    public IEnsayoCatedraRepo ensayoCatedraRepo {get; set;}
    public IPracticaProfesionalizanteRepo practicaProfesionalizanteRepo {get; set;}
    public IPracticaSupervisadaIngenieria practicaSupervisadaIngenieriaRepo {get; set;}
    public IProyectoFinalIngenieria proyectoFinalIngenieria {get; set;}
    public TesinaLicenciaturaRepo tesinaLicenciatura {get; set;}
    public TesisPosgradoRepo tesisPosgrado {get; set;}    

    public UnitOfWork(GIUCTDbContext context, ILoggerFactory loggerFactory) //Constructor
    {
        _context = context;     
        _logger = loggerFactory.CreateLogger("logs");       //Factoria para crear logs 
        ensayoCatedraRepo = new EnsayoCatedraRepo (context, _logger);
        practicaProfesionalizanteRepo = new PracticaProfesionalizanteRepo (context, _logger);
        practicaSupervisadaIngenieriaRepo = new PracticaSupervisadaIngenieriaRepo (context, _logger);
        tesinaLicenciatura = new TesinaLicenciaturaRepo (context, _logger);
        tesisPosgrado = new TesisPosgradoRepo(context, _logger);
    }


    public async Task CompleteAsync()    
    {
        await _context.SaveChangesAsync(); //Guarda los datos en la base de datos de manera asincronica 
    }

    public void Dispose()       //LIbera recursos no utilizados (no implementado)
    {
        _context.Dispose();
    }
}