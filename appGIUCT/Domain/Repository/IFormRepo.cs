using appGIUCT.Domain.Entities;

namespace appGIUCT.Domain.Repositores{
    public interface IFormRepo
    {
        Task<IEnumerable<FormacionAcademica>> GetFormA();
        // Task<FormacionAcademica?> GetFormA( int pkFormacionAcademica);
        // Task<FormacionAcademica?> Add(FormacionAcademica formacionAcademica);
        // Task<FormacionAcademica?> Update(FormacionAcademica formacionAcademica);
        // void Delete(int FormacionAcademica);
    }
}