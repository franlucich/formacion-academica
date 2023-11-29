using appGIUCT.Domain.Repositores;


public interface IUnitOfWork
{
    IFormRepo FormRepo { get; }
    Task CompleteAsync();
}
