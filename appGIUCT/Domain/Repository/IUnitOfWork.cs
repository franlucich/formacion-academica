using appGIUCT.Domain.Repository;



public interface IUnitOfWork
{
    IFormRepo FormRepo { get; }
    Task CompleteAsync();
}
