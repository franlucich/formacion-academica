using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;

public class UnitOfWork : IUnitOfWork, IDisposable      //Se implementan dos interfaces 
{
    private readonly GIUCTDbContext _context;       //Instancia para acceder a la base de datos 
    private readonly ILogger _logger;       //Instancia de un logger para registrar informacion

    public IFormRepo FormRepo { get; set; }    //Expone una instancia de IPro..

    

    public UnitOfWork(GIUCTDbContext context, ILoggerFactory loggerFactory) //Constructor
    {
        _context = context;     
        _logger = loggerFactory.CreateLogger("logs");       //Factoria para crear logs 
        FormRepo = new FormRepo(context, _logger); //Inicializa una instancia proveedors que utiliza el contexto y el logger
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